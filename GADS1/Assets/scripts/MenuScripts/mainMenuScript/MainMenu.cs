using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(3);
    }

    
    public void ReadMe()
    {
        SceneManager.LoadScene(15);
    }

    public void PlayTennis()
    {
        SceneManager.LoadScene(6);
    }

    public void PlayMatch3()
    {
        SceneManager.LoadScene(4);
    }

    public void PlaySnake()
    {
        SceneManager.LoadScene(5);
    }

    public void PlayStory()
    {
        SceneManager.LoadScene(1);
    }

    public void ToTutorial()
    {
        SceneManager.LoadScene(8);
    }

    public void ToOptions()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);

    }

    public void ToAchievements()
    {
        SceneManager.LoadScene(7);
    }

}
