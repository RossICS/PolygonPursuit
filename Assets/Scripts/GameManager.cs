using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    private int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    public GameObject tutorialScreen;
    public GameObject creditScreen;
    public GameObject Trapezoid;
    public GameObject Music;
    public TextMeshProUGUI healthText;
    private int health;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToTitle()
    {
        Debug.Log("BackToTitle called");  // Add this line

        if (tutorialScreen != null)
        {
            Debug.Log("titleScreen is not null");  // Add this line
            tutorialScreen.gameObject.SetActive(false);
            Trapezoid.gameObject.SetActive(false);
            titleScreen.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("titleScreen is null");  // Add this line
        }
    }

    public void BackToTitle2()
    {
        Debug.Log("BackToTitle2 called");  // Add this line

        if (creditScreen != null)
        {
            Debug.Log("titleScreen is not null");  // Add this line
            creditScreen.gameObject.SetActive(false);
            titleScreen.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("titleScreen is null");  // Add this line
        }
    }

    public void StartGame()
    {
        Debug.Log("StartGame called");  // Add this line
        score = 0;
        UpdateScore(0);
        UpdateHealth(1000);
        isGameActive = true;

        if (titleScreen != null)
        {
            Debug.Log("titleScreen is not null");  // Add this line
            titleScreen.gameObject.SetActive(false);
            Music.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("titleScreen is null");  // Add this line
        }
    }

    public void TutorialStart()
    {
        Debug.Log("TutorialStart called");  // Add this line

        if (titleScreen != null)
        {
            Debug.Log("titleScreen is not null");  // Add this line
            titleScreen.gameObject.SetActive(false);
            tutorialScreen.gameObject.SetActive(true);
            Trapezoid.gameObject.SetActive(true);

        }
        else
        {
            Debug.Log("titleScreen is null");  // Add this line
        }
    }

    public void CreditsStart()
    {
        Debug.Log("CreditsStart called");  // Add this line

        if (titleScreen != null)
        {
            Debug.Log("titleScreen is not null");  // Add this line
            titleScreen.gameObject.SetActive(false);
            creditScreen.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("titleScreen is null");  // Add this line
        }
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void UpdateHealth(int healthToChange)
    {
        health += healthToChange;
        healthText.text = "Health: " + health;
        if (health <= 0)
        {
            GameOver();
        }
    }
}
