using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    //metóda, ktorá vytvorí inštanciu triedy
    private void Awake()
    {
        if (instance == null) instance = this;
    }

    //metóda, ktorá načíta Menu UI
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    //metóda, ktorá načíta Game UI
    public void LoadSceneGame()
    {
        SceneManager.LoadScene("Game");
    }

    //metóda, ktorá načíta GameOver UI
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    //metóda, ktorá načíta Options UI
    public void LoadOptionScene()
    {
        SceneManager.LoadScene("Options");
    }

    //metóda, ktorá načíta InputData UI
    public void LoadInputDataScene()
    {
        if (Game.instance.timer == 0)
        {
            SceneManager.LoadScene("InputData");
        }
    }

    //metóda, ktorá ukončí hru
    private void QuitApplication()
    {
        QuitApplication();
    }
}
