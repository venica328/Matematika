using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class ReadFile : MonoBehaviour
{
    public static ReadFile instance;

    private string Pom, Priklad, Zly1, Zly2, Zly3, Zly4;
    private string[] StringArray;
    private int Rand, Number;

    [SerializeField]
    public Button buttonLow, buttonHigh, buttonMix;
    public GameObject cloud1Text, cloud2Text, cloud3Text, cloud4Text, cloud5Text, tableText;
    public string vysledok, fileName, filePath;
    
    
    private void Awake()
    {
        if (instance == null) instance = this;

        if(PlayerPrefs.GetString("fileName") == "mixLevel.txt")
        {
            Mix();
        }
        else if(fileName == "")
        {
            fileName = "lowLevel.txt";
            Debug.Log("filename: " +fileName);
            filePath = Application.dataPath + (@"\Files\" + fileName);
        }
        
        Debug.Log(filePath);
        ReadAllLines();
        DisplayRandomLine();
    }

    private void Update()
    {
        Number = PlayerPrefs.GetInt("number");
        Mix();
    }

    private void Mix()
    {
        if(Number < 10)
        {
            fileName = "lowLevel.txt";
            Debug.Log("filename: " + fileName);
            PlayerPrefs.SetString("fileName", fileName);
            filePath = Application.dataPath + (@"\Files\" + fileName);
            ReadAllLines();
            Debug.Log(filePath);
        }
        else if (Number >= 10 && Number < 15)
        {
            fileName = "highLevel.txt";
            Debug.Log("filename: " + fileName);
            PlayerPrefs.SetString("fileName", fileName);
            filePath = Application.dataPath + (@"\Files\" + fileName);
            ReadAllLines();
            Debug.Log(filePath);
        }
        else if (Number >= 15)
        {
            fileName = "mixLevel.txt";
            Debug.Log("filename: " + fileName);
            PlayerPrefs.SetString("fileName", fileName);
            filePath = Application.dataPath + (@"\Files\" + fileName);
            ReadAllLines();
            Debug.Log(filePath);
        }
    }

    private void ReadAllLines()
    {
        StringArray = File.ReadAllLines(filePath);
        foreach (string line in StringArray)
        {
            // print(line);
        }
    }
    private void SortRandom()
    {
        Rand = UnityEngine.Random.Range(1, 5);
        if (Rand == 1)
        {
            cloud1Text.GetComponent<Text>().text = vysledok;
        }
        else if (Rand == 2)
        {
            Pom = cloud2Text.GetComponent<Text>().text;
            cloud2Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = Pom;
        }
        else if (Rand == 3)
        {
            Pom = cloud3Text.GetComponent<Text>().text;
            cloud3Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = Pom;
        }
        else if (Rand == 4)
        {
            Pom = cloud4Text.GetComponent<Text>().text;
            cloud4Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = Pom;
        }
        else if (Rand == 5)
        {
            Pom = cloud5Text.GetComponent<Text>().text;
            cloud5Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = Pom;
        }
    }
    public void DisplayRandomLine()
    {
        int randomNumber = UnityEngine.Random.Range(0, StringArray.Length);
        var splitLine = StringArray[randomNumber].Split(';');
        Priklad = splitLine[0];
        vysledok = splitLine[1];
        Zly1 = splitLine[2];
        Zly2 = splitLine[3];
        Zly3 = splitLine[4];
        Zly4 = splitLine[5];
        cloud1Text.GetComponent<Text>().text = vysledok;
        cloud2Text.GetComponent<Text>().text = Zly1;
        cloud3Text.GetComponent<Text>().text = Zly2;
        cloud4Text.GetComponent<Text>().text = Zly3;
        cloud5Text.GetComponent<Text>().text = Zly4;
        tableText.GetComponent<Text>().text = Priklad;
        SortRandom();
    }
    public void LowLevel()
    {
        var colors = buttonLow.GetComponent<Button>().colors;
        var butHigh = buttonHigh.GetComponent<Button>().colors;
        var butMix = buttonMix.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        buttonLow.GetComponent<Button>().colors = colors;

        butHigh.normalColor = Color.white;
        buttonHigh.GetComponent<Button>().colors = butHigh;
        butMix.normalColor = Color.white;
        buttonMix.GetComponent<Button>().colors = butMix;
    }

    public void HighLevel()
    {
        var colors = buttonHigh.GetComponent<Button>().colors;
        var butLow = buttonLow.GetComponent<Button>().colors;
        var butMix = buttonMix.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        buttonHigh.GetComponent<Button>().colors = colors;

        butLow.normalColor = Color.white;
        buttonLow.GetComponent<Button>().colors = butLow;
        butMix.normalColor = Color.white;
        buttonMix.GetComponent<Button>().colors = butMix;
    }

    public void MixLevel()
    {
        var colors = buttonMix.GetComponent<Button>().colors;
        var butLow = buttonLow.GetComponent<Button>().colors;
        var butHigh = buttonHigh.GetComponent<Button>().colors;

        colors.normalColor = Color.green;
        buttonMix.GetComponent<Button>().colors = colors;

        butLow.normalColor = Color.white;
        buttonLow.GetComponent<Button>().colors = butLow;
        butHigh.normalColor = Color.white;
        buttonHigh.GetComponent<Button>().colors = butHigh;
    }

}
