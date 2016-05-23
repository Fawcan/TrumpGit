using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Scene_1");
            Debug.Log("Scene Loaded");
        }
	
	}
}
