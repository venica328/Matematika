using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game Instance;
    private int curScore, curFaults, number;
    public Text TimeCountDown, Score, Fault;
    public int Timer;
    public int FinalScore;

    /// <summary>
    /// metóda, ktorá vytvorí inštanciu triedy a nastaví čas
    /// </summary>
    private void Awake()
    {
        if (Instance == null) Instance = this;
        //ak čas nezadá hráč je automatikcy nastavený na 60 sekúnd
        if (PlayerPrefs.GetInt("timer") != 0)
        {
            Debug.Log(PlayerPrefs.GetInt("timer"));
            Timer = PlayerPrefs.GetInt("timer");
        }
        else
        {
            Timer = 60;
            Debug.Log(Timer);
        }
    }

    /// <summary>
    /// metóda, ktorá nastaví počiatočný stav hry a mana6uje plynutie času
    /// </summary>
    private void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        Score.text = "" + 0;
        Fault.text = "" + 0;
    }

    /// <summary>
    /// metóda, ktorá aktualizuje čas v hre
    /// </summary>
    private void Update()
    {
        TimeCountDown.text = ("" + Timer);
        //ak čas uplynie, vyhodnotí sa skóre a nastaví sa nové UI
        if (Timer == 0)
        {
            MenuManager.Instance.LoadInputDataScene();
            FinalScore = curScore - curFaults;
            Timer = 60;
        }
        number = curScore;
        PlayerPrefs.SetInt("number", number);
        Debug.Log("skore" + number);
    }

    /// <summary>
    /// metóda, ktorá odpočítava čas hry
    /// </summary>
    /// <returns>vráti vždy aktuálny odpočet</returns>
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Timer--;
        }
    }

    /// <summary>
    /// metóda, ktorá zvyšuje skóre
    /// </summary>
    public void IncreaseScore()
    {
        curScore++;
        Score.text = "" + curScore;
    }

    /// <summary>
    /// metóda, ktorá zvyšuje nesprávny ťah hráča
    /// </summary>
    public void IncreaseFaults()
    {
        curFaults++;
        Fault.text = "" + curFaults;
    }
}
