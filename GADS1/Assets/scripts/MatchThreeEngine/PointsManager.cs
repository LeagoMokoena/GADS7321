using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointsManager : MonoBehaviour
{

    private int PlayerScore = 0;
    public int PointsToReach;
    public Text PlayerScoreText;
    public PointsManager pointsManager;


    private void CheckPoints()
    {
        if (PlayerScore == PointsToReach)
        {
            SceneManager.LoadScene(11);
        }

    }

    public void PlayerMatched()
    {
        PlayerScore++;
        PlayerScoreText.text = PlayerScore.ToString();
        CheckPoints();
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
