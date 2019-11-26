using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slender : MonoBehaviour
{
    public GameObject LowerLight;
    public GameObject Light1;
    public GameObject Light2;
    public float LightStep;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (LowerLight.tag == "ambient")
        {
            Light1.GetComponent<Light>().intensity -= LightStep * Time.deltaTime;
            Light2.GetComponent<Light>().intensity -= LightStep * Time.deltaTime;
            RenderSettings.ambientLight = new Color(0.3f, 0.3f, 0.3f, 1);
        }
      
       

    }
        
}
