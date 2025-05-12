using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Item_Container : MonoBehaviour
{
    public GameObject Item;

    private void Start()
    {
        for(int i = 0; i < GameState.ItemCount; i++)
        {
            Clone_Items(i);
        }
    }

    void Clone_Items(int id)
    {
        Vector3 randomSphere = Random.insideUnitSphere * 0.15f;
        randomSphere.y = 0f;
        Vector3 randomPos = randomSphere + transform.position;

        float randomAngleX = Random.value * 360f;
        float randomAngleY = Random.value * 360f;
        float randomAngleZ = Random.value * 360f;
        Quaternion randomRot = Quaternion.Euler(randomAngleX, randomAngleY, randomAngleZ);
        GameObject Clone = Instantiate(Item, randomPos, randomRot);
        Clone.transform.localScale= Vector3.one*2f;
        Clone.SetActive(true);
        Clone.transform.SetParent(transform);
        Clone.name = "Clone-" + string.Format("{0:D4}", id);
    }
}
