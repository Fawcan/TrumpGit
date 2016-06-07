using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SandRussia : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(RussiaCutscene());
    }
    IEnumerator RussiaCutscene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("RussiaEnter");
    }
}
