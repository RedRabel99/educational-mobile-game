using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject shopMenu;


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
}
