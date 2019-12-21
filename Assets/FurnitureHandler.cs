using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureHandler : MonoBehaviour
{
    GameObject furn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddFurniture()
    {
        Transform clone;

        //get prefab object
        furn = (GameObject)Resources.Load("Assets/Sphere");

        //add it as child of image target
        GameObject.Instantiate(furn, new Vector3(2, 2, 0), Quaternion.identity);
    }
}
