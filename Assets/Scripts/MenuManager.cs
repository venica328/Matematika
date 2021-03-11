using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
    public void LoadSceneGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadOptionScene()
    {
        SceneManager.LoadScene("Options");
    }

    public void LoadInputDataScene()
    {
        if (Game.instance.timer == 0)
        {
            SceneManager.LoadScene("InputData");
        }
    }

    public void QuitApplication()
    {
        Debug.Log("koniec");
        QuitApplication();
    }


}
