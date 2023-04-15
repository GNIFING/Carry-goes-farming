using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpgradeScene : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = score.ToString();
    }

    public void UpdateScore()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        scoreText.text = score.ToString();
    }

    public void GoBackToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void PlusScore()
    {
        PlayerPrefs.SetInt("Score", score + 1);
        UpdateScore();
    }

    public void MinusScore()
    {
        PlayerPrefs.SetInt("Score", score - 1);
        UpdateScore();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("Score", 0);
        UpdateScore();
    }
}
