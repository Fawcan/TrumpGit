using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*
    Script handles all input from the mouse and seperates it from battle into
    use within the world map. Script should only handel input accordingly.
    -- Created By Albin Frisk Pettersson
*/
public class InputManager : MonoBehaviour
{

    [SerializeField]
    private int interactRange;
    protected int layerMask;
    float rayLength = 100f;
    public bool isClicked = true;

    void Awake()
    {
        layerMask = LayerMask.GetMask("Ground");
        //player = GetComponent<Player>();
    }

    void Start()
    {
    
    }

    void Update()
    {
        HandleMouse();
    }

    void HandleMouse()
    {
        //Debug.Log("TEST");
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, rayLength))
            {
                if(hit.transform.tag == "Node" && isClicked)
                {                
                    Vector3 newPosition = hit.transform.position;
                    newPosition.z = 5f;
                    transform.position = newPosition;
                    SceneManager.LoadScene("Scene_1");
                    
                    //Vector3 x,y,z
                     
                    

                }
            }
        }
        
        
    }
    
    


 
	
}
