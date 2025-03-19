using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{
    public int score;
    public Transform title;
    public Text Score;

    void Start()
    {
        score = 0;
        Score.text = "0";
        Time.timeScale = 1; // Oyunu ba�larken tekrar h�zland�r
    }

    void Update()
    {
        // Oyun bitince bir �ey yapmaya gerek yok
    }

    public void ScoreAdd()
    {
        score++;
        Score.text = score.ToString();
    }

    public void GameOver()
    {
        title.localPosition = new Vector3(0f, 300f, 0f);
        Time.timeScale = 0; // Oyunu durdur
    }

    public void NewGame()
    {
        SceneManager.LoadScene(0); // Oyunu yeniden ba�lat
    }
}
