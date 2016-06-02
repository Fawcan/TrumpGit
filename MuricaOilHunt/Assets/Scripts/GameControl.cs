using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    //[SerializeField]
    //private WorldManager worldManager;



    void Awake()
    {
        if (control == null)
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
        SceneManager.LoadScene("WorldMapStart");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}


