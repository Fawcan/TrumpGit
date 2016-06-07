using UnityEngine;
using System.Collections;

public class VideoController : MonoBehaviour
{
    [SerializeField]
    MovieTexture movie;
    bool loop;

    void Start()
    {
        ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
        movie.loop = true;

    }
}
