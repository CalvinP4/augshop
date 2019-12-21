using UnityEngine;
using System.Collections;

public class DragObject1 : MonoBehaviour
{

    private Vector3 dist;
    private float posX;
    private float posY;


    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;

        MaterialHandler materialHandler = new MaterialHandler();
        materialHandler.EnableButton();
        materialHandler.DisableButton();
        // todo show color edit button for 10s
        // todo if button pressed pass reference of gameObject and open Scene
        
    }


    void ShowButton()
    {

    }


    void HideButton()
    {

    }

    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - posX,Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
