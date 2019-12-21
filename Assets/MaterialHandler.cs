using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using UnityEngine.UIElements;

public class MaterialHandler : MonoBehaviour
{
    [SerializeField]GameObject materialButton;

    public void EnableButton()
    {
        print("Enable the button");
        materialButton.SetActive(true);
    }

    public void DisableButton()
    {
        print("Disable the button");
        materialButton.SetActive(false);
    }

}
