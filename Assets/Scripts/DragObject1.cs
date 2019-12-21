using UnityEngine;
using System.Collections;

public class DragObject1 : MonoBehaviour
{

    private Vector3 dist;
    private float posX;
    private float posY;
    [SerializeField] GameObject materialButton;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;


        //materialHandler.EnableButton();  
        materialButton.SetActive(true);
    }

    void OnMouseExit()
    {
        //materialHandler.DisableButton();
        //materialHandler.DisableButton();
        materialButton.SetActive(false);
    }


    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - posX,Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
