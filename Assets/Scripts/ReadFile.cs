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
    public GameObject cloud1Text;
    public GameObject cloud2Text;
    public GameObject cloud3Text;
    public GameObject cloud4Text;
    public GameObject cloud5Text;
    public GameObject tableText;
    public string priklad;
    public string vysledok;
    public string zly1;
    public string zly2;
    public string zly3;
    public string zly4;
    public string pom;
    public int rand;
    public int actualLine = 0;
    public string fileName, filePath;
    public string[] stringArray;

    public void Awake()
    {
        if (instance == null) instance = this;
    }
    private void Start()
    {
        fileName = "lowLevel.txt";
        filePath = Application.dataPath + (@"\Files\" + fileName);
        readAllLines();
    }

    public void readAllLines()
    {
        stringArray = File.ReadAllLines(filePath);
        foreach(string line in stringArray)
        {
            print(line);
        }
    }
    public void displayRandomLine()
    {
        int randomNumber = UnityEngine.Random.Range(0, stringArray.Length);
        var splitLine = stringArray[randomNumber].Split( ';' );
        priklad = splitLine[0];
        vysledok = splitLine[1];
        zly1 = splitLine[2];
        zly2 = splitLine[3];
        zly3 = splitLine[4];
        zly4 = splitLine[5];
        cloud1Text.GetComponent<Text>().text = vysledok;
        cloud2Text.GetComponent<Text>().text = zly1;
        cloud3Text.GetComponent<Text>().text = zly2;
        cloud4Text.GetComponent<Text>().text = zly3;
        cloud5Text.GetComponent<Text>().text = zly4;
        tableText.GetComponent<Text>().text = priklad;
        sortRandom();
    }
    public void sortRandom()
    {
        rand = UnityEngine.Random.Range(1, 5);
        if (rand == 1)
        {
            cloud1Text.GetComponent<Text>().text = vysledok;
        }
        else if (rand == 2)
        {
            pom = cloud2Text.GetComponent<Text>().text;
            cloud2Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 3)
        {
            pom = cloud3Text.GetComponent<Text>().text;
            cloud3Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 4)
        {
            pom = cloud4Text.GetComponent<Text>().text;
            cloud4Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = pom;
        }
        else if (rand == 5)
        {
            pom = cloud5Text.GetComponent<Text>().text;
            cloud5Text.GetComponent<Text>().text = vysledok;
            cloud1Text.GetComponent<Text>().text = pom;
        }
    }


    

}
