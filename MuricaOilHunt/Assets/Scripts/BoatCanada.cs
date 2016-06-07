using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BoatCanada : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(CanadaCutscene());
    }
    IEnumerator CanadaCutscene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("ScotlandEnter");
    }

}