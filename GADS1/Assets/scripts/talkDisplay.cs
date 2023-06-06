using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talkDisplay : MonoBehaviour
{
    public chats talk;

    public GameObject left;
    public GameObject right;

    private speaker Lspeaker;
    private speaker Rspeaker;

    private int activeLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        Lspeaker = left.GetComponent<speaker>();
        Rspeaker = right.GetComponent<speaker>();

        Lspeaker.Speaker = talk.left;
        Rspeaker.Speaker = talk.right;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            advance();
        }
    }

    void advance()
    {
        if(activeLine < talk.lines.Length)
        {
            display();
            activeLine++;
        }
        else
        {
            Lspeaker.gameObject.SetActive(false);
            Rspeaker.gameObject.SetActive(false);
            activeLine = 0;
        }
    }

    void display()
    {
        line l = talk.lines[activeLine];
        people pe = l.people;

        if (Lspeaker.isSpeaking(pe))
        {
            setdia(Lspeaker, Rspeaker, l.title);
        }
        else
        {
            setdia(Rspeaker,Lspeaker,l.title);
        }

    }

    void setdia(speaker active,speaker inactive,string text)
    {
        active.dialogue = text;
        active.gameObject.SetActive(true);
        inactive.gameObject.SetActive(false);
    }
}
