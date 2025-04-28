using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int vidas = 3;
    public int puntajes = 0;

    public TextMeshProUGUI vida;
    public TextMeshProUGUI puntaje;
    public GameObject gameOverPanel;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateUI();
    }

    private void Update()
    {
        puntajes += (int)(Time.deltaTime * 10); 
        UpdateUI();
    }

    public void TakeDamage()
    {
        vidas--;
        if (vidas <= 0 && vidas == 0)
        {
            GameOver();
        }
        UpdateUI();
    }

    public void AddPoints(int amount)
    {
        puntajes += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        vida.text = "Vidas: " + vidas;
        puntaje.text = "Puntaje: " + puntajes;
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

