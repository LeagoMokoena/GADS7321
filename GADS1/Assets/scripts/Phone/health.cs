using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int healths;
    public GameObject won;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("healthsil").GetComponent<Slider>().minValue = 0;
        GameObject.FindWithTag("healthsil").GetComponent<Slider>().maxValue = 100;
        healths = 10;
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.FindWithTag("healthsil").GetComponent<Slider>().minValue = 0;
        GameObject.FindWithTag("healthsil").GetComponent<Slider>().maxValue = 100;
        GameObject.FindWithTag("healthsil").GetComponent<Slider>().value = healths; 

        if (healths > 50)
        {
            won.gameObject.SetActive(true);
        }
    }
}
