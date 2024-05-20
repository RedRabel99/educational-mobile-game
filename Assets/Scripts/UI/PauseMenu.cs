using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject endMenu;
    public GameObject PauseCover;
    [SerializeField] GameController gameController;


    private void Start()
    {
       
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        //Time.timeScale = 0f;
        gameController.pauseController.PauseFallingObjects();
        PauseCover.SetActive(true);
        isPaused = true;

    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        PauseCover.SetActive(false);
        StartCoroutine(ResumeAfterCountdown());
    }

    IEnumerator ResumeAfterCountdown()
    {
        yield return StartCoroutine(gameController.countdown.CountdownToStart(3));
        gameController.pauseController.UnpauseFallingObjects();
        isPaused = false;
    }

    public void Restart()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ActivateEndMenu()
    {
        isPaused = true;
        Time.timeScale = 0f;
        gameController.bestScoreController.SetBestScoreText(gameController.score.GetCurrentScore());
        gameController.coinAdder.AddCoins(gameController.score.GetCurrentScore(), gameController.mistakeCounter.GetAllMistakes());
        endMenu.SetActive(true);
        PauseCover.SetActive(true);


    }

    public void OpenMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
