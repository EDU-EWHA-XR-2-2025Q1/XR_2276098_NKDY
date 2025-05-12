using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_Controller : MonoBehaviour
{
    public GameObject UI;

    public void Increase_PickCount(GameObject Clone)
    {
        GameState.PickCount++;
        GameState.ItemCount--;
        print($"pick count: {GameState.PickCount}");
        Destroy(Clone);
        UI.GetComponent<UI_Controller>().Display_PickCounts();
    }
}
