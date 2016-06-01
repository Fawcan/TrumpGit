using UnityEngine;
using System.Collections;

public class MovieHandler : MonoBehaviour
{
    [SerializeField]
    private MovieTexture movieClip;
    public void playClip()
    {
        Renderer movieRenderer = GetComponent<Renderer>();
        MovieTexture movieClip = (MovieTexture)movieRenderer.material.mainTexture;

        if(movieClip.isPlaying)
        {
            movieClip.Pause();
        }
        else
        {
            movieClip.Play();
        }

    }
    

	
}
