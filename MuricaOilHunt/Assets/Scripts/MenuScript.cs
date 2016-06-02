using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public void OnGUI()
    {
        if (GUI.Button(new Rect(870, 600, 200, 30), "Start Game"))
        {
            GameControl.control.NewGame();
        }

        if (GUI.Button(new Rect(870, 640, 200, 30), "Save Game"))
        {
            //GameControl.control.Save();
        }

        if (GUI.Button(new Rect(870, 680, 200, 30), "Load Game"))
        {
            //GameControl.control.Load();
        }

        if (GUI.Button(new Rect(870, 720, 200, 30), "Quit Game"))
        {
            GameControl.control.QuitGame();
        }
    }

    
}




//float countDown = 3f;
//IEnumerator Delay()
//{
//    yield return new WaitForSeconds(3);
//    print(countDown);        
//}


//public void StartButton()
//{
//    StartCoroutine(Delay());
//    SceneManager.LoadScene("WorldMap");



//}
//public void QuitButton()
//{
//    Application.Quit();
//}
