using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 100f;
    public GameObject CanvasSim;
    public GameObject CanvasXR;


    [SerializeField] Text countdownText;
    private void Start()
    {
        currentTime = startingTime;
        
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();
        
        if (CanvasSim.tag == "reset" || CanvasXR.tag=="reset" )
        {
            currentTime = startingTime;
            CanvasSim.tag = "EndReset";
            CanvasXR.tag = "EndReset";

        }
    }
}
