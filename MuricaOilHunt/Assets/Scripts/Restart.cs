using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
	void Update ()
    {
        if(Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}
}
