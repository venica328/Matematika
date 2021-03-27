using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class Cloud : MonoBehaviour
{
    [SerializeField]
    public Button cloud, cloud2, cloud3, cloud4, cloud5;

    public void onCloudClick()
    {
        var colors = cloud.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        cloud.GetComponent<Button>().colors = colors;

        if (ReadFile.instance.cloud1Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {            
            colors.selectedColor = Color.green;
            cloud.GetComponent<Button>().colors = colors;
            Game.instance.increaseScore();
        } 
        else
        {
            colors.selectedColor = Color.red;
            cloud.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud1Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
        }
        ReadFile.instance.displayRandomLine();
    }


    public void onCloudClick2()
    {
        var colors = cloud2.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        cloud2.GetComponent<Button>().colors = colors;

        if (ReadFile.instance.cloud2Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {          
            colors.selectedColor = Color.green;
            cloud2.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud2Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            cloud2.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud2Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
        }
        ReadFile.instance.displayRandomLine();
    }

    public void onCloudClick3()
    {
        var colors = cloud3.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        cloud3.GetComponent<Button>().colors = colors;

        if (ReadFile.instance.cloud3Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            colors.selectedColor = Color.green;
            cloud3.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud3Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            cloud3.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud3Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
        }
        ReadFile.instance.displayRandomLine();
    }

    public void onCloudClick4()
    {
        var colors = cloud4.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        cloud4.GetComponent<Button>().colors = colors;

        if (ReadFile.instance.cloud4Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            colors.selectedColor = Color.green;
            cloud4.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud4Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            cloud4.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud4Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
        }
        ReadFile.instance.displayRandomLine();
    }

    public void onCloudClick5()
    {
        var colors = cloud5.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        cloud5.GetComponent<Button>().colors = colors;

        if (ReadFile.instance.cloud5Text.GetComponent<Text>().text == ReadFile.instance.vysledok)
        {
            colors.selectedColor = Color.green;
            cloud5.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud5Text.GetComponent<Text>().text);
            Game.instance.increaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            cloud5.GetComponent<Button>().colors = colors;
            print(ReadFile.instance.cloud5Text.GetComponent<Text>().text);
            Game.instance.increaseFaults();
        }
        ReadFile.instance.displayRandomLine();
    }


}
