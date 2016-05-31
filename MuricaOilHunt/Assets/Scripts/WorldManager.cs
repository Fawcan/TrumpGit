using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class WorldManager : MonoBehaviour
{
    [SerializeField]
   public Vector3 playerPosition;
    [SerializeField]
    public GameObject player;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        DontDestroyOnLoad(gameObject);
        GameObject[] Managers = GameObject.FindGameObjectsWithTag("WorldManager");
        if (Managers.Length > 1)
        {
            Destroy(gameObject);
        }

    }

    void OnLevelWasLoaded()
    {
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
