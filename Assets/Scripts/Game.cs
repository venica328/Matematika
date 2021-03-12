using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game instance;
    [SerializeField]
    public Text timeCountDown, score, fault;
    public int timer = 10;
    public int curScore, curFaults;


    private void Awake()
    {
        if (instance == null) instance = this;
    }
    void Start()
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
        score.text = "" + 0;
        fault.text = "" + 0;

    }

    // Update is called once per frame
    void Update()
    {
        timeCountDown.text = ("" + timer);
        if (timer == 0)
        {
            MenuManager.instance.LoadInputDataScene();
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
    }

    public void increaseScore()
    {
        curScore++;
        score.text = "" + curScore;
    }

    public void increaseFaults()
    {
        curFaults++;
        fault.text = "" + curFaults;
    }


}
