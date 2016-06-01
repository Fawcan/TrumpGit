using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class WorldManager : MonoBehaviour
{
    [SerializeField]
    public Vector3 playerPosition; 
    [SerializeField]
    public GameObject player;

    private static WorldManager worldManager;

    void Awake()
    {
        if (worldManager == null)
        {
            DontDestroyOnLoad(gameObject);
            worldManager = this;
        }
        else if (worldManager != this)
        {
            Destroy(gameObject);
        }
        
        player = GameObject.FindGameObjectWithTag("Player");


    }

    void OnLevelWasLoaded()
    {
        if (playerPosition == null)
            playerPosition = new Vector3(0f, 0f, -0.5f);
        if (SceneManager.GetActiveScene().name == "WorldMap")
        {
            player = GameObject.FindGameObjectWithTag("Player");
            player.transform.position = playerPosition;
            Debug.Log(playerPosition);
        }
    }

    public void EnemyDefeted(string name)
    {
        Debug.Log(name);

        switch (name)
        {
            case "William":
                CanadaDefeted();
                break;


            default:
                break;
        }
    }
    private void CanadaDefeted()
    {
        //TODO: Set bonus shit
    }
    



}
