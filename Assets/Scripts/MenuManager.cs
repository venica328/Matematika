using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    /// <summary>
    /// metóda, ktorá vytvorí inštanciu triedy
    /// </summary>
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    /// <summary>
    /// metóda, ktorá načíta Menu UI
    /// </summary>
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    /// <summary>
    /// metóda, ktorá načíta Game UI
    /// </summary>
    public void LoadSceneGame()
    {
        SceneManager.LoadScene("Game");
    }

    /// <summary>
    /// metóda, ktorá načíta GameOver UI
    /// </summary>
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    /// <summary>
    /// metóda, ktorá načíta Options UI
    /// </summary>
    public void LoadOptionScene()
    {
        SceneManager.LoadScene("Options");
    }

    /// <summary>
    /// metóda, ktorá načíta InputData UI
    /// </summary>
    public void LoadInputDataScene()
    {
        if (Game.Instance.Timer == 0)
        {
            SceneManager.LoadScene("InputData");
        }
    }

    /// <summary>
    /// metóda, ktorá ukončí hru
    /// </summary>
    public void QuitApplication()
    {
        Application.Quit();
    }
}
