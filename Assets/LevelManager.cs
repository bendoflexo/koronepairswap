using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deathScreen;
    public TextMeshProUGUI scoreText;

    public int score;

    private void Awake()
    {
        manager = this;
    }

    public void GameOver()
    {
        deathScreen.SetActive(true);
        scoreText.text = "Score: " + score.ToString();
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }
}
