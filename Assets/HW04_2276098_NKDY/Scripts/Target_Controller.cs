using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target_Controller : MonoBehaviour
{
    public GameObject UI;

    public void OnTrackingFound()
    {
        if (UI != null)
        {            UI.GetComponent<UI_Controller>()?.HideInfo();
        }
    }

    public void OnTrackingLost()
    {
        if (UI != null)
        {            UI.GetComponent<UI_Controller>()?.ShowInfo();
        }
    }
}
