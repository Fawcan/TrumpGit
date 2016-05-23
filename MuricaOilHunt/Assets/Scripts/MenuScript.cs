using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour
{

	void Update ()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Scene_1");
            Debug.Log("asd");
        }
	
	}
}
