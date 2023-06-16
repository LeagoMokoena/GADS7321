using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[System.Serializable]
public class talkevent : UnityEvent<chats> { }

public class talkController : MonoBehaviour
{
    public cho choice;
    public talkevent talkchange;

    public static talkController addbutton(Button button, cho choice,int num)
    {
        int butSpace = -44;
        Button button1 = Instantiate(button);

        button1.transform.SetParent(button.transform.parent);
        button1.transform.localScale = Vector3.one;
        button1.transform.localPosition = new Vector3(0,num * butSpace,0);
        button1.name = "Choice " + (num + 1);
        button1.gameObject.SetActive(true);

        talkController TalkController = button1.GetComponent<talkController>();
        TalkController.choice = choice;
        return TalkController;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(talkchange == null)
        {
            talkchange = new talkevent();
        }

        GetComponent<Button>().GetComponentInChildren<Text>().text = choice.tex;
    }

    public void makle()
    {
        talkchange.Invoke(choice._chats);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
