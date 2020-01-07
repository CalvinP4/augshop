using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DragObject1 : MonoBehaviour
{

    private Vector3 dist;
    private float posX;
    private float posY;
    public GameObject gameObject;
    public Button matButton;

    void Start()
    {
        gameObject = GameObject.FindGameObjectWithTag("materialButton");
        matButton = gameObject.GetComponent<Button>();
    }

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;


        matButton.interactable = true;
       
    }



    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - posX,Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
