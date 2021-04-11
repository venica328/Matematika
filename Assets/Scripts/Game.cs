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

    private void Awake()
    {
        if (instance == null) instance = this;
        if(PlayerPrefs.GetInt("timer") != 0)
        {
            timer = PlayerPrefs.GetInt("timer");
        }
        timer = 60;
        Debug.Log(timer);
    }
    private void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        score.text = "" + 0;
        fault.text = "" + 0;
    }
    private void Update()
    {
        timeCountDown.text = ("" + timer);
        if (timer == 0)
        {
            MenuManager.instance.LoadInputDataScene();
            finalScore = CurScore - CurFaults;
        }
        number = CurScore;
        PlayerPrefs.SetInt("number", number);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
    }
    public void IncreaseScore()
    {
        CurScore++;
        score.text = "" + CurScore;
    }
    public void IncreaseFaults()
    {
        CurFaults++;
        fault.text = "" + CurFaults;
    }
}
