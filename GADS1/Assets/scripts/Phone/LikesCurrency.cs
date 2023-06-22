using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LikesCURRENCY : MonoBehaviour
{
    public int time;
    public int min;
    public bool phoneoff = false;
    public Text likesAmount;
    public int likes;
    // Start is called before the first frame update
    void Start()
    {

        min = 0;
        likes = min;
    }

    // Update is called once per frame
    void Update()
    {

        likesAmount.text = likes.ToString();
    }


    public void switchOff(int time)
    {
        likes -= time;

    }

    public void AddLikes(int _likes)
    {
        likes += _likes;
    }
}
