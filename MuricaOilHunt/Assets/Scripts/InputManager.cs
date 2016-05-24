using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    protected Player player;

    //public bool isClicked = false;
    int layerMask;

    void Awake()
    {
        layerMask = LayerMask.GetMask("Button");
        player = GetComponent<Player>();
    }
    void Update()
    {
        HandleMouse();
    }

    void HandleMouse()
    {
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Button Left is released ");
            //isClicked = false;
        }
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Button Left is clicked ");
            //isClicked = true;
        }
    }
    
    


 
	
}
