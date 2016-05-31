using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public WorldManager worldManager;
   
    
	// Use this for initialization
	void Awake ()
    {
        worldManager = GameObject.FindGameObjectWithTag("WorldManager").GetComponent<WorldManager>();
        if(control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }        
	
	}

    public void NewGame()
    {
        SceneManager.LoadScene("WorldMap");   
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //void OnGUI()
    //{
    //    GUI.Label(new Rect(10, 10, 100, 30), "Health: " + health);
    //}

    public void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/playerInfo.dat");
        Debug.Log(Application.persistentDataPath);
        PlayerData data = new PlayerData();
        data.worldManager = worldManager;
        bf.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/playerInfo.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            Debug.Log(Application.persistentDataPath);
            file.Close();
            worldManager = data.worldManager;
        }
        
    }

    
	
	
}
[System.Serializable]
class PlayerData
{
    public WorldManager worldManager;   
}
