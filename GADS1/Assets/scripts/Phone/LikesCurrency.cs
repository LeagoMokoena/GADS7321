using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LikesCURRENCY : MonoBehaviour
{
    public int time;
    public float min;
    public bool phoneoff = false;
    public float likes;
    // Start is called before the first frame update
    void Start()
    {
        likes = 50;
        
    }

    // Update is called once per frame
    void Update()
    {

        GameObject.FindWithTag("likesText").GetComponent<amount>().likesAmount.text = likes.ToString();
    }


    public void switchOff(int time)
    {
        likes--;

    }

    public void AddLikes(float _likes)
    {
        likes += _likes;
    }
}
