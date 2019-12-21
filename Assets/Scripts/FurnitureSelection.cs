using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FurnitureSelection : MonoBehaviour
{
    private GameObject[] furnitureList;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        index = PlayerPrefs.GetInt("FurnitureSelected");

        furnitureList = new GameObject[transform.childCount];

        for(int i=0;i < transform.childCount; i++)
        {
            furnitureList[i] = transform.GetChild(i).gameObject;
        }

        foreach(GameObject go in furnitureList)
        {
            go.SetActive(false);
        }

        if (furnitureList[index])
            furnitureList[index].SetActive(true);
    }

    public void ToggleLeft()
    {
        furnitureList[index].SetActive(false);

        index--;
        if (index < 0)
            index = furnitureList.Length - 1;

        furnitureList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        furnitureList[index].SetActive(false);

        index++;
        if (index == furnitureList.Length)
            index = 0;

        furnitureList[index].SetActive(true);
    }

    public void SelectButton()
    {
        PlayerPrefs.SetInt("FurnitureSelected", index);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
