using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class optionController : MonoBehaviour
{
    public question que;
    public Text queText;
    public Button Chbutton;

    private List<talkController> talkControllers = new List<talkController>();

    public void change(question _question)
    {
        Removed();
        que = _question;
        gameObject.SetActive(true);
        Initialized();
    }

    public void hid(chats _chats) 
    {
        Removed();
        gameObject.SetActive(false);
    }

    private void Removed()
    {
        foreach(talkController controller in talkControllers)
        {
            Destroy(controller.gameObject);
        }

        talkControllers.Clear();
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Initialized()
    {
        queText.text = que.tex;

        for(int  i = 0; i < que.options.Length; i++)
        {
            talkController t = talkController.addbutton(Chbutton, que.options[i],i);
            talkControllers.Add(t);
        }

        Chbutton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
