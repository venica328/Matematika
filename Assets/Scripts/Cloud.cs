using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class Cloud : MonoBehaviour
{
    public void onCloudClick()
    {
        if(ReadFile.instance.cloud1Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            print(ReadFile.instance.cloud1Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
            ReadFile.instance.displayRandomLine();
        } else
        {
            print(ReadFile.instance.cloud1Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
            ReadFile.instance.displayRandomLine();
        }
    }

    public void onCloudClick2()
    {
        if (ReadFile.instance.cloud2Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            print(ReadFile.instance.cloud2Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
            ReadFile.instance.displayRandomLine();
        }
        else
        {
            print(ReadFile.instance.cloud2Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
            ReadFile.instance.displayRandomLine();
        }
    }

    public void onCloudClick3()
    {
        if (ReadFile.instance.cloud3Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            print(ReadFile.instance.cloud3Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
            ReadFile.instance.displayRandomLine();
        }
        else
        {
            print(ReadFile.instance.cloud3Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
            ReadFile.instance.displayRandomLine();
        }
    }

    public void onCloudClick4()
    {
        if (ReadFile.instance.cloud4Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            print(ReadFile.instance.cloud4Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
            ReadFile.instance.displayRandomLine();
        }
        else
        {
            print(ReadFile.instance.cloud4Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
            ReadFile.instance.displayRandomLine();
        }
    }

    public void onCloudClick5()
    {
        if (ReadFile.instance.cloud5Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            print(ReadFile.instance.cloud5Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
            ReadFile.instance.displayRandomLine();
        }
        else
        {
            print(ReadFile.instance.cloud5Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
            ReadFile.instance.displayRandomLine();
        }
    }


}
