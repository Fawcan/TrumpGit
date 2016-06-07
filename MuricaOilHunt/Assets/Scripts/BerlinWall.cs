using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BerlinWall : MonoBehaviour

{
    void Start()
    {
        StartCoroutine(BerlinCutscene());
    }
    IEnumerator BerlinCutscene()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("GermanyBeat");
    }

}
