using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GermanySand : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GermanyCutscene());
    }
    IEnumerator GermanyCutscene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("SandEnter");
    }

}
