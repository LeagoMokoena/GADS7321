using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider healthSlider;
    private LikesCURRENCY currency;
    // Start is called before the first frame update
    void Start()
    {
        currency = new LikesCURRENCY();
        healthSlider.minValue = 0;
        healthSlider.maxValue = 100;
        healthSlider.value = 50;

    }

    // Update is called once per frame
    void Update()
    {
        if(currency.likes > 30)
        {
            healthSlider.value -=10;
        }
    }
}
