using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;

    void OnMouseDown()
    {
        print($"{gameObject.name} clicked");
        Pick_Controller.GetComponent<Pick_Controller>().Increase_PickCount(gameObject);
    }
}
