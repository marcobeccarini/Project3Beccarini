using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public GameObject Scaler;
    public Vector3 newScale;
    public Vector3 stopScale;
    public Vector3 normScale;
    public GameObject countdownSIM;
    public GameObject countdownXR;
    //public float speed = 2.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Scaler.tag == "fly")
        {
            Scaler.transform.localScale += newScale;
            countdownSIM.SetActive(true);
            countdownXR.SetActive(true);
            if (Scaler.transform.localScale == stopScale)
                Scaler.tag = "EndFly";
        }

        if (Scaler.tag == "FlyDown")
        {   if(Scaler.transform.localScale != normScale)
            {
                Scaler.transform.localScale -= newScale;
                 if (Scaler.transform.localScale == normScale)
                     Scaler.tag = "EndFly";
            }
           
        }
    }
}
