using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour
{
    public GameObject phonePrefab;
    public GameObject timer;
    public GameObject timerPrefab;
    public bool phoneoff = false;
    public Text timerText;
    public float likes;
    public Text likesAmount;
    public int offmount;
    //public Slider healthSlider;
    public health _hea;
    public enum times
    {
        none,
        One_min,
        One_hour,
        One_day,
        One_week

    }

    // Start is called before the first frame update
    void Start()
    {
        _hea = new health();
        timerText.text = "How long do you want the phone off";
        phoneoff = true;
        var drop = transform.GetComponent<Dropdown>();   
        drop.options.Clear();
        /*healthSlider.minValue = 0;
        healthSlider.maxValue = 100;
        healthSlider.value = 50;*/
        drop.options.Add(new Dropdown.OptionData() { text = times.none.ToString() });
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
        likesAmount.text = likes.ToString();
    
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
            if(num ==  1)
            {
                timerPrefab.GetComponent<LikesCURRENCY>().likes--;
                timerPrefab.GetComponent<health>().healthSlider.value++;
            }
            else if(num == 2)
            {
                timerPrefab.GetComponent<LikesCURRENCY>().likes-=5;
                timerPrefab.GetComponent <health>().healthSlider.value+=10;
            }
            else if (num == 3)
            {
                timerPrefab.GetComponent<LikesCURRENCY>().likes-=10;
                timerPrefab.GetComponent<health>().healthSlider.value +=15;
            }
            else
            {
                timerPrefab.GetComponent<LikesCURRENCY>().likes-=15;
                timerPrefab.GetComponent<health>().healthSlider.value +=20;
            }
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
