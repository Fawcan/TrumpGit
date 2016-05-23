using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform mPlayer;
    [SerializeField]
    private Vector3 offset;

    void Update()
    {
        transform.position = new Vector3(mPlayer.position.x + offset.x, mPlayer.position.y + offset.y, offset.z); // Camera follows the mPlayer with specified offset position
    }
}