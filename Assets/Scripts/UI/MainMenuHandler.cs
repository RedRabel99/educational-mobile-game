using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject shopMenu;
    [SerializeField] GameObject bestScoreMenu;
    [SerializeField] GameObject aboutMenu;


    public void LoadFirstGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSecondGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadThirdGame()
    {
        SceneManager.LoadScene(3);
    }
    public void OpenShop()
    {
        mainMenu.SetActive(false);
        shopMenu.SetActive(true);
    }  

    public void FromShopToMainMenu()
    {
        shopMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenBestScore()
    {
        mainMenu.SetActive(false);
        bestScoreMenu.SetActive(true);
    }

    public void FromBestScoreToMainMenu()
    {
        bestScoreMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenAbout()
    {
        mainMenu.SetActive(false);
        aboutMenu.SetActive(true);
    }

    public void FromAboutToMainMenu()
    {
        aboutMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
