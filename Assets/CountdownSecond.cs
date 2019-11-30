using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownSecond : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 20f;
    public GameObject CanvasSIM;
    public GameObject CanvasXR;

    public GameObject Scaler;
    public GameObject InteractableMaze;
    public GameObject LowerLight;


    [SerializeField] Text countdownText;
    private void Start()
    {
        currentTime = startingTime;

    }

    private void Update()
    {
      
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString();
            if(currentTime < 0f)
            {
            Scaler.tag = "FlyDown";
            InteractableMaze.tag = "BackOn";
            LowerLight.tag = "BackOn";
            CanvasSIM.SetActive(false);
            CanvasXR.SetActive(false);
            currentTime = startingTime;
            }

       
        
               
    }
}

