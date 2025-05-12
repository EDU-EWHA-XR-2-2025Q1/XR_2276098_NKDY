using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket_Controller : MonoBehaviour
{
    public GameObject UI_Controller;
    public float moveRadius = 0.3f;

    private Vector3 basePosition;
    private bool isMoving = false;

    void Start()
    {
        basePosition = transform.localPosition;
        StartMoving();
    }

    void StartMoving()
    {
        if (!isMoving)
        {
            isMoving = true;
            StartCoroutine(MoveRandomly());
        }
    }

    IEnumerator MoveRandomly()
    {
        while (isMoving)
        {
            Vector3 offset = new Vector3(
                Random.Range(-moveRadius, moveRadius),
                0f,
                Random.Range(-moveRadius, moveRadius)
            );
            transform.localPosition = basePosition + offset;

            yield return new WaitForSeconds(Random.Range(0.5f, 1f));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("충돌 감지됨: " + other.name); // 이게 찍혀야 충돌

        if (other.tag == "Item")
        {
            GameState.PutCount++;
            UI_Controller.GetComponent<UI_Controller>().Display_PutCounts();
            Destroy(other.gameObject);
        }
    }
}
