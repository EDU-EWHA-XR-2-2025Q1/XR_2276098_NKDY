using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Put_Controller : MonoBehaviour
{
    public GameObject TargetObjectToThrow;
    public Transform PlayerCamera;
    public Transform AimPoint;
    public GameObject UI;
    public Button ThrowButton;

    void Start()
    {
        UpdateFireButtonState();
    }

    void Update()
    {
        UpdateFireButtonState();
    }

    public void OnClick_Throw()
    {
        if (GameState.PickCount <= 0) return;

        Throw();
        GameState.PickCount--;
        GameState.PutCount++;

        UI.GetComponent<UI_Controller>()?.Display_PickCounts();
        UI.GetComponent<UI_Controller>()?.Display_PutCounts();
    }

    void Throw()
    {
        Vector3 startPos = PlayerCamera.position + PlayerCamera.forward*0.3f;
        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);

        GameObject Clone = Instantiate(TargetObjectToThrow, startPos, randomRot);
        // Clone.transform.localScale = Vector3.one * 5.0f;

        Clone.SetActive(true);
        Clone.GetComponent<Collider>().isTrigger = false;
        Clone.GetComponent<Rigidbody>().useGravity = false;

        Vector3 direction = (AimPoint.position - startPos).normalized;
        Clone.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);

        Destroy(Clone, 3f);
    }

    void UpdateFireButtonState()
    {
        ThrowButton.interactable = (GameState.PickCount > 0);
    }
}