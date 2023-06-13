using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    private int Player1Score = 0;
    private int Player2Score = 0;

    public int ScoreToReach;
    public Text player1scoreText;
    public Text player2scoreText;


    public void Player1Goal()
    {
        Player1Score++;
        player1scoreText.text = Player1Score.ToString();
        CheckScore();
    }

    public void Player2Goal()
    {
        Player2Score++;
        player2scoreText.text = Player2Score.ToString();
        CheckScore();
    }

    private void CheckScore()
    {
        if (Player1Score == ScoreToReach || Player2Score == ScoreToReach)
        {
            SceneManager.LoadScene(11);
        }

    }

}
