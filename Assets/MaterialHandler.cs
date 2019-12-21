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
        print("I'm enabled");
    }

    public void DisableButton()
    {
        print("I'm disabled");
    }

}
