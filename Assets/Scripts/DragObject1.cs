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
    public PanelHandler panelHandler;

    void Start()
    {
        GetMaterialButtonReference();
        GetColorPickerPanel();
    }

    private void GetColorPickerPanel()
    {
        //get reference of the colour picker panel
        panelHandler = GameObject.FindObjectOfType(typeof(PanelHandler)) as PanelHandler;
    }

    private void GetMaterialButtonReference()
    {
        gameObject = GameObject.FindGameObjectWithTag("materialButton");
        matButton = gameObject.GetComponent<Button>();
        matButton.interactable = false;
    }

    void OnMouseDown()
    {
        SetDistanceFromCamera();

        //just an experiment to change the color
        //transform.GetComponent<Renderer>().material.color = Color.black;

        EnableMatButtonDisablePanel();
    }

    private void EnableMatButtonDisablePanel()
    {
        matButton.interactable = true;

        //if a new prefab is selected hide the panel
        panelHandler.SetPanelInvisible();
    }

    private void SetDistanceFromCamera()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }

    void OnMouseDrag()
    {
        Vector3 curPos =
         new Vector3(Input.mousePosition.x - posX,Input.mousePosition.y - posY, dist.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(curPos);
        transform.position = worldPos;
    }
}
