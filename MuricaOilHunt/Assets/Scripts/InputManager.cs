﻿using UnityEngine;
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
    public bool textDelay = false;
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
        StartCoroutine(TextDelay());
    }

    void Update()
    {
        //Debug.LogWarning("Update()");
        HandleMouse();
    }

    IEnumerator TextDelay()
    {
        yield return new WaitForSeconds(3f);
        textDelay = true;
    }

    void HandleMouse()
    {

        //if (SceneManager.GetActiveScene().name == "WorldMapStart")
        {



            //Debug.LogWarning("HandleMouse()");
            if (Input.GetMouseButtonDown(0) && textDelay == true)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                //Combat Canada
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
                //To Scotland
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToScotland" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneCanada");
                    }
                }
                //Combat Scotland
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeScotland" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Stonehenge");
                    }
                }

                //To Norway
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToNorway" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneNorway");
                    }
                }
                //Combat Norway
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeNorway" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Norway");
                    }
                }

                //To Finland
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToFinland" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("FinlandEnter");
                    }
                }
                //Combat Finland
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeFinland" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Finland");
                    }
                }

                //To Sweden
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToSweden" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("SwedenEnter");
                    }

                }
                //Combat Sweden
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeSweden" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Sweden");
                    }
                }

                //To Germany
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToGermany" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("GermanyEnter");
                    }
                }
                //Combat Germany
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeGermany" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Germany");
                    }
                }

                //To Sand
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToSand" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneAirplane");
                    }
                }
                //Combat Sand
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeSand" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Sand");
                    }
                }

                //To Russia
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToRussia" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneRussia");
                    }

                }
                //Combat Russia
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeRussia" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("Russia");
                    }
                }

                //To China
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToChina" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneChina");
                    }

                }
                //Combat China
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "NodeChina" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("China");
                    }
                }

                //To USA
                if (Physics.Raycast(ray, out hit, rayLength))
                {
                    if (hit.transform.tag == "ToUSA" && isClicked)//"node"
                    {
                        newPosition = hit.transform.position;
                        newPosition.z = -0.5f;
                        transform.position = newPosition;
                        //int i = Application.loadedLevel;
                        //Application.LoadLevel(i + 1);
                        SceneManager.LoadScene("CutsceneUSA");
                    }

                }
                //Code above this
            }
        }
    }
}
