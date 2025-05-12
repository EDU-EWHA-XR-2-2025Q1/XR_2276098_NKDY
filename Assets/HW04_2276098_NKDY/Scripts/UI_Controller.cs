using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Controller : MonoBehaviour
{
    public TMP_Text PickCounts;
    public TMP_Text PutCounts;
    public GameObject InfoPanel;

    private void Start()
    {
        Display_PickCounts();
        Display_PutCounts();
        ShowInfo();
    }

    public void Display_PickCounts()
    {
        PickCounts.text = GameState.PickCount.ToString();

    }

    public void Display_PutCounts()
    {
        PutCounts.text = GameState.PutCount.ToString();
    }

    public void HideInfo()
    {
        InfoPanel.SetActive(false);
    }

    public void ShowInfo()
    {
        InfoPanel.SetActive(true);
    }

}
