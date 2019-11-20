using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSmall : MonoBehaviour
{
    private Vector3 shrinkScale = new Vector3(.1f, .1f, .1f);

    public GameObject SimulatedCameraRig; 
    
    

    void OnCollisionEnter(Collision col)//When Object Collides
    {
        SimulatedCameraRig.transform.localScale = shrinkScale;

    }
    
}