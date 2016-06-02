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
    public Vector3 newPosition;
    //public WorldManager worldManager;


    void Awake()
    {
        Debug.LogWarning("Input Manager Awake()");
        layerMask = LayerMask.GetMask("Ground");
        //player = GetComponent<Player>();
        //worldManager = GameObject.FindGameObjectWithTag("WorldManager").GetComponent<WorldManager>();
    }

    void Start()
    {
    
    }

    void Update()
    {
        //Debug.LogWarning("Update()");
        HandleMouse();
    }

    void HandleMouse()
    {
        //if (SceneManager.GetActiveScene().name == "WorldMapStart")
        {
            //Debug.LogWarning("HandleMouse()");
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeCanada" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CanadaRink");
                    }                   

                }

                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToScotland" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        //SceneManager.LoadScene("CanadaRink");
                    }

                }

                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeNorway" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        //SceneManager.LoadScene("CanadaRink");
                    }

                }
            }


        }
    }
    
    


 
	
}
