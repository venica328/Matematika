using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public static Options Instance;
    [SerializeField]
    public Button Button30, Button60, Button90, Button120, ButtonLowLevel, ButtonHighLevel, ButtonMixLevel;
    private int timer = 0;
    private string fileName;

    /// <summary>
    /// metóda, ktorá vytvorí inštanciu triedy
    /// </summary>
    private void Awake()
    {
        if (Instance == null) Instance = this;
        // FileName = "lowLevel.txt";
        timer = 0;
        PlayerPrefs.SetInt("timer", timer);
    }

    /// <summary>
    /// metóda, ktorá určí z akého súboru sa má čítať
    /// </summary>
    public void ChangeFileNameToLow()
    {
        fileName = "lowLevel.txt";
        PlayerPrefs.SetString("fileName", fileName);
    }

    /// <summary>
    /// metóda, ktorá určí z akého súboru sa má čítať
    /// </summary>
    public void ChangeFileNameToHigh()
    {
        fileName = "highLevel.txt";
        PlayerPrefs.SetString("fileName", fileName);
    }

    /// <summary>
    /// metóda, ktorá určí z akého súboru sa má čítať
    /// </summary>
    public void ChangeFileNameToMix()
    {
        fileName = "mixLevel.txt";
        PlayerPrefs.SetString("fileName", fileName);
    }

    /// <summary>
    /// metóda, ktorá nastaví čas hry na 30 sekúnd
    /// </summary>
    public void ChangeTimeTo30()
    {
        var colors = Button30.GetComponent<Button>().colors;
        var but60 = Button60.GetComponent<Button>().colors;
        var but90 = Button90.GetComponent<Button>().colors;
        var but120 = Button120.GetComponent<Button>().colors;

        timer = 30;
        PlayerPrefs.SetInt("timer", timer);

        if (PlayerPrefs.GetInt("timer") == 30)
        {
            colors.normalColor = Color.green;
            Button30.GetComponent<Button>().colors = colors;
            but60.normalColor = Color.white;
            but90.normalColor = Color.white;
            but120.normalColor = Color.white;
            Button60.GetComponent<Button>().colors = but60;
            Button90.GetComponent<Button>().colors = but90;
            Button120.GetComponent<Button>().colors = but120;
        }
    }

    /// <summary>
    /// metóda, ktorá nastaví čas hry na 60 sekúnd
    /// </summary>
    public void ChangeTimeTo60()
    {
        var colors = Button60.GetComponent<Button>().colors;
        var but30 = Button30.GetComponent<Button>().colors;
        var but90 = Button90.GetComponent<Button>().colors;
        var but120 = Button120.GetComponent<Button>().colors;

        timer = 60;
        PlayerPrefs.SetInt("timer", timer);

        if (PlayerPrefs.GetInt("timer") == 60)
        {
            colors.normalColor = Color.green;
            Button60.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but90.normalColor = Color.white;
            but120.normalColor = Color.white;
            Button30.GetComponent<Button>().colors = but30;
            Button90.GetComponent<Button>().colors = but90;
            Button120.GetComponent<Button>().colors = but120;
        }
    }
    /// <summary>
    /// metóda, ktorá nastaví čas hry na 90 sekúnd
    /// </summary>
    public void ChangeTimeTo90()
    {
        var colors = Button90.GetComponent<Button>().colors;
        var but30 = Button30.GetComponent<Button>().colors;
        var but60 = Button60.GetComponent<Button>().colors;
        var but120 = Button120.GetComponent<Button>().colors;

        timer = 90;
        PlayerPrefs.SetInt("timer", timer);

        if (PlayerPrefs.GetInt("timer") == 90)
        {
            colors.normalColor = Color.green;
            Button90.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but60.normalColor = Color.white;
            but120.normalColor = Color.white;
            Button30.GetComponent<Button>().colors = but30;
            Button60.GetComponent<Button>().colors = but60;
            Button120.GetComponent<Button>().colors = but120;
        }
    }

    /// <summary>
    /// metóda, ktorá nastaví čas hry na 120 sekúnd
    /// </summary>
    public void ChangeTimeTo120()
    {
        var colors = Button120.GetComponent<Button>().colors;
        var but30 = Button30.GetComponent<Button>().colors;
        var but60 = Button60.GetComponent<Button>().colors;
        var but90 = Button90.GetComponent<Button>().colors;

        timer = 120;
        PlayerPrefs.SetInt("timer", timer);

        if (PlayerPrefs.GetInt("timer") == 120)
        {
            colors.normalColor = Color.green;
            Button120.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but60.normalColor = Color.white;
            but90.normalColor = Color.white;
            Button30.GetComponent<Button>().colors = but30;
            Button60.GetComponent<Button>().colors = but60;
            Button90.GetComponent<Button>().colors = but90;
        }
    }
}
