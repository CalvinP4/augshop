using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour
{
    [SerializeField] GameObject panel;  //the reference of the panel
    public static Transform selectedBlock;
    public Slider rotationSlider;

    
    

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

    public void RotateMyObject()
    {
        float sliderValue = rotationSlider.value;
        selectedBlock.localRotation = Quaternion.Euler( 0f, sliderValue * 360f ,0f);
    }
}
