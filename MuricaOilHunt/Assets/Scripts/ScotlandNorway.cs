using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScotlandNorway : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(NorwayCutscene());
    }
    IEnumerator NorwayCutscene()
    {
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("NorwayEnter");
    }

}
