using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private Text feedBack; 
    public ScrollRect scrollRect;
    public RectTransform scrollableText;

    private int maxCharacters = 150;

    void Start()
    {
        //scrollRect.content = scrollableText;
    }

    public void Print(string output)
    {
        feedBack.text += "\n" + output;
        feedBack.text = feedBack.text.Remove(0, Mathf.Max(0, feedBack.text.Length - maxCharacters));
    }
    

}
