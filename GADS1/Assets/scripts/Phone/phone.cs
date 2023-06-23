using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour
{
    public GameObject phonePrefab;
    public GameObject timer;
    public bool phoneoff = false;
    private LikesCURRENCY likes;
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
        phoneoff = true;
        var drop = transform.GetComponent<Dropdown>();
        likes = new LikesCURRENCY();    
        drop.options.Clear();  

        drop.options.Add(new Dropdown.OptionData() { text = times.One_min.ToString() }); 
        drop.options.Add(new Dropdown.OptionData() { text = times.One_hour.ToString() }); 
        drop.options.Add(new Dropdown.OptionData() { text = times.One_day.ToString() }); 
        drop.options.Add(new Dropdown.OptionData() { text = times.One_week.ToString() });

        OffTime(drop);
        drop.onValueChanged.AddListener(delegate { OffTime(drop); });
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void Off()
    {
        phoneoff = true;
        timer.gameObject.SetActive(true);
    }

    void OffTime(Dropdown down)
    {
        int num = down.value;
        
        timerText.text = num.ToString();

        if(num > 0)
        {
            phoneoff = false;
            likes.switchOff(num);
            timer.gameObject.SetActive(false);
            phonePrefab.gameObject.SetActive(true);
        }

        /*if (down. == 0)
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
        */

    }
}
