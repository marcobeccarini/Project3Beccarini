using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongSimon : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource DoSound;
    public GameObject DoG;
    public AudioSource ReSound;
    public GameObject ReG; 
    public AudioSource MiSound;
    public GameObject MiG; 
    public AudioSource FaSound;
    public GameObject FaG; 
    public AudioSource LaSound;
    public GameObject LaG; 
    public AudioSource SiSound;
    public GameObject SiG;
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator waiter()
    {
       //do re mi  mi la la fa
        //Wait for 4 seconds
        yield return new WaitForSeconds(4);
        DoSound.Play();
        DoG.SetActive(true);
        yield return new WaitForSeconds(1);
        DoG.SetActive(false);

        ReSound.Play();
        ReG.SetActive(true);
        yield return new WaitForSeconds(1);
        ReG.SetActive(false);

        MiSound.Play();
        MiG.SetActive(true);
        yield return new WaitForSeconds(1);
        MiG.SetActive(false);

        LaSound.Play();
        LaG.SetActive(true);
        yield return new WaitForSeconds(1);
        LaG.SetActive(false);


        FaSound.Play();
        FaG.SetActive(true);
        yield return new WaitForSeconds(1);
        FaG.SetActive(false);

    }
}
