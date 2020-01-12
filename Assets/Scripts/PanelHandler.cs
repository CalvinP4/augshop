using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    [SerializeField] GameObject panel;  //the reference of the panel
    public static Transform selectedBlock;

    public void SetPanelVisible()
    {
        if (panel != null)
            panel.SetActive(true);
    }

    public void SetPanelInvisible()
    {
        if (panel != null)
            panel.SetActive(false);
    }

    public void SetColorRed()
    {
        selectedBlock.GetComponent<Renderer>().material.color = Color.red;
    }

    public void SetColorGreen()
    {
        selectedBlock.GetComponent<Renderer>().material.color = Color.green;
    }

    public void SetColorBlue()
    {
        selectedBlock.GetComponent<Renderer>().material.color = Color.blue;
    }

}
