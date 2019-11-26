using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsBackOn : MonoBehaviour
{
    public GameObject SpotLight;
    public GameObject Lightning;
    public GameObject Slander;
    public GameObject Penny;
    public GameObject InteractableMaze;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InteractableMaze.tag == "ambient")
        {
            RenderSettings.ambientLight = Color.black;
            print("Hello");
        }
        if(InteractableMaze.tag == "BackOn")
        {
            SpotLight.SetActive(false);
            Lightning.SetActive(true);
            RenderSettings.ambientLight = Color.grey;
            Slander.SetActive(false);
            Penny.SetActive(false);
            
        }
        
    }
}
