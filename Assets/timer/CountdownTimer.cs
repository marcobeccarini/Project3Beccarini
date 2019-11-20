using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 100f;

    [SerializeField] Text countdownText;
    private void Start()
    {
        currentTime = startingTime;
        countdownText.tag = "endReset";
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString();

        if (countdownText.tag == "reset")
        {    currentTime = startingTime;
            countdownText.tag = "endReset";
        }
    }
}
