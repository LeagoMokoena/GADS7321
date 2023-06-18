using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEditor;

[System.Serializable]
public class questionEvent : UnityEvent<question> { } 

public class talkDisplay : MonoBehaviour
{
    public chats talk;
    public chats deflaut;
    public questionEvent QuestionEvent;

    public GameObject left;
    public GameObject right;

    private speaker Lspeaker;
    private speaker Rspeaker;

    private int activeLine = 0;
    private bool talkstArt = false;

    public void changes(chats ch)
    {
        talkstArt = false;
        talk = ch;
        advance();
    }

    // Start is called before the first frame update
    void Start()
    {
        Lspeaker = left.GetComponent<speaker>();
        Rspeaker = right.GetComponent<speaker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            advance();
        }
        else if(Input.GetKeyDown("z"))
        {
            endtalk();
        }
    }

    private void endtalk()
    {
        talk = null;
        talkstArt= false;
        Lspeaker.gameObject.SetActive(false);
        Rspeaker.gameObject.SetActive(false);
    }

    private void Initialize()
    {
        talkstArt=true;
        activeLine = 0;
        Lspeaker.Speaker = talk.left;
        Rspeaker.Speaker = talk.right;
    }

    void advance()
    {
        if (talk == null) return;
        if (!talkstArt) 
        {
            Initialize();
        
        }

        if(activeLine < talk.lines.Length)
        {
            display();
        }
        else
        {
            Advancetalk();
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

        activeLine++;

    }

    private void Advancetalk()
    {
        if(talk.question != null)
            QuestionEvent.Invoke(talk.question);
        else if(talk.nextchat != null)
            changes(talk.nextchat);
        else
        {
            endtalk();
        }
    }

    void setdia(speaker active,speaker inactive,string text)
    {
        active.dialogue = text;
        active.gameObject.SetActive(true);
        inactive.gameObject.SetActive(false);


    }

}
