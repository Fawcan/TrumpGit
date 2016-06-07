using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RussiaChina : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ChinaCutscene());
    }
    IEnumerator ChinaCutscene()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("ChinaEnter");
    }
}
