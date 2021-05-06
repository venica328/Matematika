using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;
using UnityEditor;

public class ReadFile : MonoBehaviour
{
    public static ReadFile Instance;

    private string pom, example, bad1, bad2, bad3, bad4;
    private string[] stringArray;
    private int rand, number;

    [SerializeField]
    public Button ButtonLow, ButtonHigh, ButtonMix;
    public GameObject Cloud1Text, Cloud2Text, Cloud3Text, Cloud4Text, Cloud5Text, TableText;
    public string Result, FileName, FilePath;
    public int ResultFilename = 0;


    /// <summary>
    /// metóda, ktorá vytvorí inštanciu triedy a zisťuje z akého súboru si hráč zvolil načítať dáta
    /// </summary>
    private void Awake()
    {
        if (Instance == null) Instance = this;

        if (PlayerPrefs.GetString("fileName") == "mixLevel.txt")
        {
            stringArray = ((TextAsset)Resources.Load("mixLevel", typeof(TextAsset))).text.Split('\n');
        }
        else if (PlayerPrefs.GetString("fileName") == "lowLevel.txt")
        {
            stringArray = ((TextAsset)Resources.Load("lowLevel", typeof(TextAsset))).text.Split('\n');
        }
        else if (PlayerPrefs.GetString("fileName") == "highLevel.txt")
        {
            stringArray = ((TextAsset)Resources.Load("highLevel", typeof(TextAsset))).text.Split('\n');
        }
        else
        {
            stringArray = ((TextAsset)Resources.Load("lowLevel", typeof(TextAsset))).text.Split('\n');
        }

        DisplayRandomLine();
    }
    /// <summary>
    /// metóda, ktorá aktualizuje číslo, v ktorom je hráčovo skóre
    /// </summary>
    private void Update()
    {
        number = PlayerPrefs.GetInt("number");
    }

    /// <summary>
    /// metóda, ktorá roztriedi výsledky zo súboru do objektov
    /// </summary>
    private void SortRandom()
    {
        rand = UnityEngine.Random.Range(1, 5);
        if (rand == 1)
        {
            Cloud1Text.GetComponent<Text>().text = Result;
        }
        else if (rand == 2)
        {
            pom = Cloud2Text.GetComponent<Text>().text;
            Cloud2Text.GetComponent<Text>().text = Result;
            Cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 3)
        {
            pom = Cloud3Text.GetComponent<Text>().text;
            Cloud3Text.GetComponent<Text>().text = Result;
            Cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 4)
        {
            pom = Cloud4Text.GetComponent<Text>().text;
            Cloud4Text.GetComponent<Text>().text = Result;
            Cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 5)
        {
            pom = Cloud5Text.GetComponent<Text>().text;
            Cloud5Text.GetComponent<Text>().text = Result;
            Cloud1Text.GetComponent<Text>().text = pom;
        }
    }

    /// <summary>
    /// metóda, ktorá číta random riadky a triedi dáta
    /// </summary>
    public void DisplayRandomLine()
    {
        int randomNumber = UnityEngine.Random.Range(0, stringArray.Length);
        var splitLine = stringArray[randomNumber].Split(';');

        example = splitLine[0];
        Result = splitLine[1];
        bad1 = splitLine[2];
        bad2 = splitLine[3];
        bad3 = splitLine[4];
        bad4 = splitLine[5];

        Cloud1Text.GetComponent<Text>().text = Result;
        Cloud2Text.GetComponent<Text>().text = bad1;
        Cloud3Text.GetComponent<Text>().text = bad2;
        Cloud4Text.GetComponent<Text>().text = bad3;
        Cloud5Text.GetComponent<Text>().text = bad4;
        TableText.GetComponent<Text>().text = example;
        SortRandom();
    }

    /// <summary>
    /// metóda pre button, kde si hráč volí variantu hry malá násobilka
    /// </summary>
    public void LowLevel()
    {
        var colors = ButtonLow.GetComponent<Button>().colors;
        var butHigh = ButtonHigh.GetComponent<Button>().colors;
        var butMix = ButtonMix.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        ButtonLow.GetComponent<Button>().colors = colors;

        butHigh.normalColor = Color.white;
        ButtonHigh.GetComponent<Button>().colors = butHigh;
        butMix.normalColor = Color.white;
        ButtonMix.GetComponent<Button>().colors = butMix;
    }

    /// <summary>
    /// metóda pre button, kde si hráč volí variantu hry vyššia násobilka
    /// </summary>
    public void HighLevel()
    {
        var colors = ButtonHigh.GetComponent<Button>().colors;
        var butLow = ButtonLow.GetComponent<Button>().colors;
        var butMix = ButtonMix.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        ButtonHigh.GetComponent<Button>().colors = colors;

        butLow.normalColor = Color.white;
        ButtonLow.GetComponent<Button>().colors = butLow;
        butMix.normalColor = Color.white;
        ButtonMix.GetComponent<Button>().colors = butMix;
    }

    /// <summary>
    /// metóda pre button, kde si hráč volí variantu hry Mix
    /// </summary>
    public void MixLevel()
    {
        var colors = ButtonMix.GetComponent<Button>().colors;
        var butLow = ButtonLow.GetComponent<Button>().colors;
        var butHigh = ButtonHigh.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        ButtonMix.GetComponent<Button>().colors = colors;

        butLow.normalColor = Color.white;
        ButtonLow.GetComponent<Button>().colors = butLow;
        butHigh.normalColor = Color.white;
        ButtonHigh.GetComponent<Button>().colors = butHigh;
    }

}