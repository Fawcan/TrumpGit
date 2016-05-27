using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    float countDown = 3f;
    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3);
        print(countDown);        
    }


    public void StartButton()
    {
        StartCoroutine(Delay());
        SceneManager.LoadScene("WorldMap");
      

    }
    public void QuitButton()
    {
        Application.Quit();
    }
}
