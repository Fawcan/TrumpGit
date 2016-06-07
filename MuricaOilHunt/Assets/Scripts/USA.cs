using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class USA : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(USACutscene());
    }
    IEnumerator USACutscene()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("BackUSA");
    }
}
