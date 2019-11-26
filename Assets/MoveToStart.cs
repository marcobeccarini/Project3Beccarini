using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStart : MonoBehaviour
{
    public GameObject player;
    public GameObject CanvasSIM;
    public GameObject CanvasXR;
    public Vector3 startPos;
  

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = startPos;
        
            CanvasSIM.tag = "reset";
            CanvasXR.tag = "reset";
    }
}
