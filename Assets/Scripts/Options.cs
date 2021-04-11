using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public static Options instance;
    [SerializeField]
    public Button button30, button60, button90, button120, buttonLowLevel, buttonHighLevel, buttonMixLevel;
    private int Timer;
    private string FileName;

    private void Awake()
    {
        if (instance == null) instance = this;
    }
    public void ChangeFileNameToLow()
    {
        FileName = "lowLevel.txt";
        PlayerPrefs.SetString("fileName", FileName);
    }
    public void ChangeFileNameToHigh()
    {
        FileName = "highLevel.txt";
        PlayerPrefs.SetString("fileName", FileName);
    }
    public void ChangeFileNameToMix()
    {
        FileName = "mixLevel.txt";
        PlayerPrefs.SetString("fileName", FileName);
    }
    public void ChangeTimeTo30()
    {
        var colors = button30.GetComponent<Button>().colors;
        var but60 = button60.GetComponent<Button>().colors;
        var but90 = button90.GetComponent<Button>().colors;
        var but120 = button120.GetComponent<Button>().colors;

        Timer = 30;
        PlayerPrefs.SetInt("timer", Timer);
        if (PlayerPrefs.GetInt("timer") == 30)
        {
            colors.normalColor = Color.green;
            button30.GetComponent<Button>().colors = colors;
            but60.normalColor = Color.white;
            but90.normalColor = Color.white;
            but120.normalColor = Color.white;
            button60.GetComponent<Button>().colors = but60;
            button90.GetComponent<Button>().colors = but90;
            button120.GetComponent<Button>().colors = but120;
        }
    }
    public void ChangeTimeTo60()
    {
        var colors = button60.GetComponent<Button>().colors;
        var but30 = button30.GetComponent<Button>().colors;
        var but90 = button90.GetComponent<Button>().colors;
        var but120 = button120.GetComponent<Button>().colors;

        Timer = 60;
        PlayerPrefs.SetInt("timer", Timer);
        if (PlayerPrefs.GetInt("timer") == 60)
        {
            colors.normalColor = Color.green;
            button60.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but90.normalColor = Color.white;
            but120.normalColor = Color.white;
            button30.GetComponent<Button>().colors = but30;
            button90.GetComponent<Button>().colors = but90;
            button120.GetComponent<Button>().colors = but120;
        }
    }
    public void ChangeTimeTo90()
    {
        var colors = button90.GetComponent<Button>().colors;
        var but30 = button30.GetComponent<Button>().colors;
        var but60 = button60.GetComponent<Button>().colors;
        var but120 = button120.GetComponent<Button>().colors;

        Timer = 90;
        PlayerPrefs.SetInt("timer", Timer);
        if (PlayerPrefs.GetInt("timer") == 90)
        {
            colors.normalColor = Color.green;
            button90.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but60.normalColor = Color.white;
            but120.normalColor = Color.white;
            button30.GetComponent<Button>().colors = but30;
            button60.GetComponent<Button>().colors = but60;
            button120.GetComponent<Button>().colors = but120;
        }
    }
    public void ChangeTimeTo120()
    {
        var colors = button120.GetComponent<Button>().colors;
        var but30 = button30.GetComponent<Button>().colors;
        var but60 = button60.GetComponent<Button>().colors;
        var but90 = button90.GetComponent<Button>().colors;

        Timer = 120;
        PlayerPrefs.SetInt("timer", Timer);
        if(PlayerPrefs.GetInt("timer") == 120)
        {
            colors.normalColor = Color.green;
            button120.GetComponent<Button>().colors = colors;
            but30.normalColor = Color.white;
            but60.normalColor = Color.white;
            but90.normalColor = Color.white;
            button30.GetComponent<Button>().colors = but30;
            button60.GetComponent<Button>().colors = but60;
            button90.GetComponent<Button>().colors = but90;
        }
    }
}
