using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject NoteDoG;
    public GameObject NoteReG;
    public GameObject NoteMiG;
    public GameObject NoteFaG;
    public GameObject NoteLaG;
    public GameObject NoteSiG;
    public GameObject Simon;
    private int a;
    private int b;
    private int c;
    private int d;
    private int e;
    private int f;
    private int g;

    private int ok = 0;
    void Start()
    {
        a = 0;
        b = 0;
        c = 0;
        d = 0;
        e = 0;
        f = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (NoteDoG.tag == "glow" || a==1)
        {
            print("Ciao");
            a = 1;
            print(a);
            if (NoteReG.tag == "glow" || b == 1)
            {
                b = 1;
                if (NoteMiG.tag == "glow" || c == 1)
                {
                    c=1;
                    if (NoteMiG.tag == "glow" || d == 1)
                    {
                        d = 1;
                        if (NoteLaG.tag == "glow" || e == 1)
                        {
                            e = 1;
                            if (NoteLaG.tag == "glow" || f == 1)
                            {
                               f=1;
                                if (NoteFaG.tag == "glow" || g == 1)
                                {
                                    g =1 ;
                                    ok = 1;
                                }
                                else if (NoteDoG.tag == "glow" || NoteReG.tag == "glow" || NoteMiG.tag == "glow" || NoteSiG.tag == "glow")
                                {
                                    a = 0;
                                    b = 0;
                                    c = 0;
                                    d = 0;
                                    e = 0;
                                    f = 0;
                                }
                            }
                            else if (NoteDoG.tag == "glow" || NoteReG.tag == "glow" || NoteFaG.tag == "glow" || NoteMiG.tag == "glow" || NoteSiG.tag == "glow")
                            {
                                a = 0;
                                b = 0;
                                c = 0;
                                d = 0;
                                e = 0;
                                f = 0;
                            }
                        }
                        else if (NoteDoG.tag == "glow" || NoteReG.tag == "glow" || NoteFaG.tag == "glow" || NoteSiG.tag == "glow")
                        {
                            a = 0;
                            b = 0;
                            c = 0;
                            d = 0;
                            e = 0;
                            f = 0;
                        }
                    }
                    else if (NoteDoG.tag == "glow" || NoteReG.tag == "glow" || NoteFaG.tag == "glow" || NoteLaG.tag == "glow" || NoteSiG.tag == "glow")
                    {
                        a = 0;
                        b = 0;
                        c = 0;
                        d = 0;
                        e = 0;
                        f = 0;
                    }
                }
                else if (NoteDoG.tag == "glow" ||  NoteFaG.tag == "glow" || NoteLaG.tag == "glow" || NoteSiG.tag == "glow")
                {
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    e = 0;
                    f = 0;
                }
            }
            else if (NoteMiG.tag == "glow" || NoteFaG.tag == "glow" || NoteLaG.tag == "glow" || NoteSiG.tag == "glow")
            { a = 0;
               b = 0;
                c = 0;
                d = 0;
                e = 0;
                f = 0;
            }
                

        }

        else if (NoteReG.tag == "glow" || NoteMiG.tag == "glow" || NoteFaG.tag == "glow" || NoteLaG.tag == "glow" || NoteSiG.tag == "glow")
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
        }
        print("a");
        print(a);
        print("b");
        print(b);

        if (ok == 1)
            Simon.SetActive(false);
    }
}
