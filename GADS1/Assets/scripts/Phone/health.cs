using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider = GetComponent<Slider>();
        healthSlider.minValue = 0;
        healthSlider.maxValue = 100;
        healthSlider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
