using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class GameOverManager : MonoBehaviour
{
    public int vidas = 3;
    public GameObject gameOverPanel;

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (vidas <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);  
        Time.timeScale = 0f;  
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}

