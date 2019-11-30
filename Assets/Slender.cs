using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slender : MonoBehaviour
{
    public GameObject LowerLight;
    public GameObject Light1;
    public GameObject Light2;
    public float LightStep;
    public GameObject Sword;
    public GameObject Penny;
    public GameObject PennyInter;
    public GameObject Slander;

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
      
       if (LowerLight.tag == "BackOn")
        {
            Light1.GetComponent<Light>().intensity = 1f;
            Light2.GetComponent<Light>().intensity = 1f;
            RenderSettings.ambientLight = Color.grey;
            Sword.SetActive(false);
            Penny.SetActive(false);
            PennyInter.SetActive(false);
            Slander.SetActive(false);
        }

    }
        
}
