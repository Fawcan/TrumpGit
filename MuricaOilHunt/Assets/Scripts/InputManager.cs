using UnityEngine;
using System.Collections;

/*
    Script handles all input from the mouse and seperates it from battle into
    use within the world map. Script should only handel input accordingly.
    -- Created By Albin Frisk Pettersson
*/
public class InputManager : MonoBehaviour
{
    [SerializeField]
    protected Player player;

    //public bool isClicked = false;
    //int layerMask;

    void Awake()
    {
        //layerMask = LayerMask.GetMask("Ground");
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
