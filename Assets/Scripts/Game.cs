using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game instance;
    private int CurScore, CurFaults, number;
    public Text timeCountDown, score, fault;
    public int timer = 60;
    public int finalScore;

    //metóda, ktorá vytvorí inštanciu triedy a nastaví čas
    private void Awake()
    {
        if (instance == null) instance = this;
        //ak čas nezadá hráč je automatikcy nastavený na 60 sekúnd
        if(PlayerPrefs.GetInt("timer") != 0)
        {
            timer = PlayerPrefs.GetInt("timer");
        }
        timer = 60;
        Debug.Log(timer);
    }

    //metóda, ktorá nastaví počiatočný stav hry
    private void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        score.text = "" + 0;
        fault.text = "" + 0;
    }

    //metóda, ktorá aktualizuje čas v hre
    private void Update()
    {
        timeCountDown.text = ("" + timer);
        //ak čas uplynie, vyhodnotí sa skóre a nastaví sa nové UI
        if (timer == 0)
        {
            MenuManager.instance.LoadInputDataScene();
            finalScore = CurScore - CurFaults;
        }
        number = CurScore;
        PlayerPrefs.SetInt("number", number);
    }

    //metóda, ktorá odpočítava čas hry
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
    }

    //metóda, ktorá zvyšuje skóre
    public void IncreaseScore()
    {
        CurScore++;
        score.text = "" + CurScore;
    }

    //metóda, ktorá zvyšuje nesprávny ťah hráča
    public void IncreaseFaults()
    {
        CurFaults++;
        fault.text = "" + CurFaults;
    }
}
