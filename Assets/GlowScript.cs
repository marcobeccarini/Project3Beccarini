using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NoteDoGLight;
    public GameObject NoteReGLight;
    public GameObject NoteMiGLight;
    public GameObject NoteFaGLight;
    public GameObject NoteLaGLight;
    public GameObject NoteSiGLight;
    public GameObject NoteDoG;
    public GameObject NoteReG;
    public GameObject NoteMiG;
    public GameObject NoteFaG;
    public GameObject NoteLaG;
    public GameObject NoteSiG;
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (NoteDoG.tag == "glow")
        {
            NoteDoGLight.SetActive(true);

        }
            

       if (NoteReG.tag == "glow")
        {
            NoteReGLight.SetActive(true);

        }

        if (NoteMiG.tag == "glow")
        {
            NoteMiGLight.SetActive(true);
        }
         if (NoteFaG.tag == "glow")
        {
            NoteFaGLight.SetActive(true);
        }
        if (NoteLaG.tag == "glow")
        {
            NoteLaGLight.SetActive(true);
        }
       if (NoteSiG.tag == "glow")
        {
            NoteSiGLight.SetActive(true);
        }
        if (NoteDoG.tag == "noGlow")
        {
            NoteDoGLight.SetActive(false);

        }

        if (NoteReG.tag == "noGlow")
        {
            NoteReGLight.SetActive(false);

        }
        if (NoteMiG.tag == "noGlow")
        {
            NoteMiGLight.SetActive(false);

        }
        if (NoteFaG.tag == "noGlow")
        {
            NoteFaGLight.SetActive(false);

        }
        if (NoteLaG.tag == "noGlow")
        {
            NoteLaGLight.SetActive(false);

        }
        if (NoteSiG.tag == "noGlow")
        {
            NoteSiGLight.SetActive(false);

        }

    }
}