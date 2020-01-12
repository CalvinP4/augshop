using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    //public Transform spawnpoint;
    private GameObject[] furnModels;
    private List<GameObject> furnList;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        furnModels = new GameObject[3];
        furnList = new List<GameObject>();
    }

    public void SpawnCube()
    {
        /*
        Debug.Log("gameObject.transform.position = "+gameObject.transform.position);

        prefab = Instantiate(prefab, gameObject.transform);

        Debug.Log("prefab.transform.position = " + prefab.transform.position);
        Debug.Log("prefab.transform.parent.position = " + prefab.transform.parent.position);
        prefab.transform.SetParent(gameObject.transform);
        */

        
        if(i < furnModels.Length)
        {
            furnModels[i] = Instantiate(prefab, gameObject.transform);          
            furnModels[i].transform.SetParent(gameObject.transform);
            i += 1;
        }
        
        

        /*
        if (i < 3)
        {
            furnList.Add(Instantiate(prefab, gameObject.transform));
            furnList.
            i += 1;
        }
        else
        {
            Debug.Log(furnModels[0] == furnModels[1]);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
