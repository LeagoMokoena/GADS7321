using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class speaker : MonoBehaviour
{
    public Image speakerImage;
    public Text speakerText;
    public Text voiceText;

    private people speak;
    public people Speaker
    {
        get { return speak; }
        set { speak = value; speakerImage.sprite = speak._sprite;speakerText.text = speak._name; }
    }
    public string dialogue
    {
        set { voiceText.text = value; }
    }

    public bool has()
    {
        return speak != null;
    }
    public bool isSpeaking(people person)
    {
        return speak == person;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
