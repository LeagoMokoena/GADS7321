using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour
{
    public GameObject phonePrefab;
    public GameObject timer;
    public bool phoneoff = false;
    public Dropdown timerselect;
    public LikesCURRENCY likes;
    public Text timerText;
    public enum times
    {
        One_min,
        One_hour,
        One_day,
        One_week

    }

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "How long do you want the phone off";

    }

    // Update is called once per frame
    void Update()
    {
        if (phoneoff)
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

    void Off()
    {
        phoneoff = true;
        timer.gameObject.SetActive(true);
    }

    void OffTime(int num)
    {
        if (num == 0)
        {
            likes.switchOff(0);
            phoneoff = false;
            timer.gameObject.SetActive(false);
        }
        if (num == 1)
        {
            likes.switchOff(10);
            phoneoff = false;
            timer.gameObject.SetActive(false);
        }
        if (num == 2)
        {
            likes.switchOff(20);
            phoneoff = false;
            timer.gameObject.SetActive(false);
        }
        if (num == 3)
        {
            likes.switchOff(50);
            phoneoff = false;
            timer.gameObject.SetActive(false);
        }


    }
}
