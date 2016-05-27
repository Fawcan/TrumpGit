using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{


    public void StartButton()
    {
        SceneManager.LoadScene("WorldMap");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
