using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigScale : MonoBehaviour
{
    public GameObject Scaler;//The Broken Object


    private Vector3 increaseScale = new Vector3(6f, 6f, 6f);

    void OnCollisionEnter(Collision col)//When Object Collides
    {

        Scaler.transform.localScale = increaseScale;
        Scaler.transform.position = new Vector3(-12.41f, 0f, -4.99f);
    }

}