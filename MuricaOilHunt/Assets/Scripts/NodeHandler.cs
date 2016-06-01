﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NodeHandler : MonoBehaviour
{
    [SerializeField]
    private string nodeName;
    [SerializeField]
    private Animation animationClip;
    [SerializeField]
    private Scene scene;


    public void NodeClick()
    {
        //animationClip.Play(name);

        SceneManager.LoadScene(nodeName);
     //TODO: Play.animation(name);
     //TODO: Loadscene(name);   
    }

	
}
