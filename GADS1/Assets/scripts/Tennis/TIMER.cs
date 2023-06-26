using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TIMER : MonoBehaviour
{
    public float time = 30;
    public Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0)
        {
            time = 10;
            GameObject.FindWithTag("pone").GetComponent<LikesCURRENCY>().likes -= 10;
            GameObject.FindWithTag("pone").GetComponent<health>().healths += 10;
            _text.text = time.ToString();
            SceneManager.LoadScene("DemoScene");
        }
    }
}
