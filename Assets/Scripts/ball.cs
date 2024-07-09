using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{
    PauseMenu pm;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverMenuUI;
    public static bool gameIsOver = false;

    void Start()
    {
        pm = GameObject.FindObjectOfType<PauseMenu>();
        scoreText.text = "0";
        gameIsOver = false;
    }

    int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kuzelka"))
        {
            score++;
            scoreText.text = score.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("kill"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pm.soundtrack.Pause();
        gameIsOver = true;
    }

}
