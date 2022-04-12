using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pauseMenu;
    public GameObject endMenu;
    public Toggle SoundToggle;
    public Toggle MusicToggle;


    private void Start()
    {
       
    }

    public void OnSoundToggleChange()
    {
        Debug.Log(SoundToggle.isOn);
        SoundToggle.isOn = !SoundToggle.isOn;
    }


    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
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
        endMenu.SetActive(true);


    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
