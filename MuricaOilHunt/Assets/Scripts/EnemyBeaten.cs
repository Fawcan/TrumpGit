using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyBeaten : MonoBehaviour
{


    public void CanadaBeaten()
    {
    //       SceneManager.LoadScene("WorldMapCanadaBeaten"); 
    //   
    int i = Application.loadedLevel;
    Application.LoadLevel(i + 1);
}
	
}
