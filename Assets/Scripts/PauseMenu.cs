using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public AudioSource soundtrack;

    // Update is called once per frame
    void Update()
    {
        if(ball.gameIsOver == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (gameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        soundtrack.Play();
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        soundtrack.Pause();
        gameIsPaused = true;
    }

    public void LoadMenu()
    {
        //Debug.Log("Loading menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
    }

}
