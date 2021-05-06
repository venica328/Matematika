using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using UnityEngine.UI;

public class Cloud : MonoBehaviour
{
    public Button Cloud1, Cloud2, Cloud3, Cloud4, Cloud5;

    /// <summary>
    /// metóda pre button Cloud1, ktorá po kliknutí overuje či hráč klikol správne alebo nesprávne
    /// podľa toho sa button sfarbí nazeleno alebo načerveno
    /// </summary>
    public void OnCloudClick()
    {
        var colors = Cloud1.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        Cloud1.GetComponent<Button>().colors = colors;

        if (ReadFile.Instance.Cloud1Text.GetComponent<Text>().text == ReadFile.Instance.Result)
        {            
            colors.selectedColor = Color.green;
            Cloud1.GetComponent<Button>().colors = colors;
            Game.Instance.IncreaseScore();
        } 
        else
        {
            colors.selectedColor = Color.red;
            Cloud1.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud1Text.GetComponent<Text>().text);
            Game.Instance.IncreaseFaults();
        }
        ReadFile.Instance.DisplayRandomLine();
    }
    /// <summary>
    /// metóda pre button Cloud2, ktorá po kliknutí overuje či hráč klikol správne alebo nesprávne
    /// podľa toho sa button sfarbí nazeleno alebo načerveno
    /// </summary>
    public void OnCloudClick2()
    {
        var colors = Cloud2.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        Cloud2.GetComponent<Button>().colors = colors;

        if (ReadFile.Instance.Cloud2Text.GetComponent<Text>().text == ReadFile.Instance.Result)
        {          
            colors.selectedColor = Color.green;
            Cloud2.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud2Text.GetComponent<Text>().text);
            Game.Instance.IncreaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            Cloud2.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud2Text.GetComponent<Text>().text);
            Game.Instance.IncreaseFaults();
        }
        ReadFile.Instance.DisplayRandomLine();
    }
    /// <summary>
    /// metóda pre button Cloud3, ktorá po kliknutí overuje či hráč klikol správne alebo nesprávne
    /// podľa toho sa button sfarbí nazeleno alebo načerveno
    /// </summary>
    public void OnCloudClick3()
    {
        var colors = Cloud3.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        Cloud3.GetComponent<Button>().colors = colors;

        if (ReadFile.Instance.Cloud3Text.GetComponent<Text>().text == ReadFile.Instance.Result)
        {
            colors.selectedColor = Color.green;
            Cloud3.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud3Text.GetComponent<Text>().text);
            Game.Instance.IncreaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            Cloud3.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud3Text.GetComponent<Text>().text);
            Game.Instance.IncreaseFaults();
        }
        ReadFile.Instance.DisplayRandomLine();
    }
    /// <summary>
    /// metóda pre button Cloud4, ktorá po kliknutí overuje či hráč klikol správne alebo nesprávne
    /// podľa toho sa button sfarbí nazeleno alebo načerveno
    /// </summary>
    public void OnCloudClick4()
    {
        var colors = Cloud4.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        Cloud4.GetComponent<Button>().colors = colors;

        if (ReadFile.Instance.Cloud4Text.GetComponent<Text>().text == ReadFile.Instance.Result)
        {
            colors.selectedColor = Color.green;
            Cloud4.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud4Text.GetComponent<Text>().text);
            Game.Instance.IncreaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            Cloud4.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud4Text.GetComponent<Text>().text);
            Game.Instance.IncreaseFaults();
        }
        ReadFile.Instance.DisplayRandomLine();
    }

    /// <summary>
    /// metóda pre button Cloud5, ktorá po kliknutí overuje či hráč klikol správne alebo nesprávne
    /// podľa toho sa button sfarbí nazeleno alebo načerveno
    /// </summary>
    public void OnCloudClick5()
    {
        var colors = Cloud5.GetComponent<Button>().colors;
        colors.selectedColor = Color.white;
        Cloud5.GetComponent<Button>().colors = colors;

        if (ReadFile.Instance.Cloud5Text.GetComponent<Text>().text == ReadFile.Instance.Result)
        {
            colors.selectedColor = Color.green;
            Cloud5.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud5Text.GetComponent<Text>().text);
            Game.Instance.IncreaseScore();
        }
        else
        {
            colors.selectedColor = Color.red;
            Cloud5.GetComponent<Button>().colors = colors;
            print(ReadFile.Instance.Cloud5Text.GetComponent<Text>().text);
            Game.Instance.IncreaseFaults();
        }
        ReadFile.Instance.DisplayRandomLine();
    }
}
