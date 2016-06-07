using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stonehenge : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(StonehengeCutscene());
    }
    IEnumerator StonehengeCutscene()
    {
        yield return new WaitForSeconds(4f);

        SceneManager.LoadScene("ScotlandBeat");
	}

}
