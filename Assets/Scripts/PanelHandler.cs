using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelHandler : MonoBehaviour
{
    [SerializeField] GameObject panel;  //the reference of the panel
    
    public void SetPanelVisible()
    {
        if (panel != null)
            panel.SetActive(true);

        //anchor the panel so it gets displayed properly

    }

    public void SetPanelInvisible()
    {
        if (panel != null)
            panel.SetActive(false);
    }
}
