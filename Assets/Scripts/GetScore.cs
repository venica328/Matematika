using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour
{
    public static GetScore instance;
    public string highscoreURL = "http://unity-matematika.cekuj.net/display.php";
    public Text getScoreText;

    //metóda, ktorá zavolá metódu GetScore() a zobrazí v hre skóre hráčov
    void Start()
    {
        StartCoroutine(GetScores());
    }

    //metóda, ktorá zobrazí skóre hráčov zo servera
    IEnumerator GetScores()
    {
        getScoreText.text = "Loading data";
        UnityWebRequest www = UnityWebRequest.Get(highscoreURL);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            string input = www.downloadHandler.text;
            input.Substring(133);
            Debug.Log(input.Substring(133));
            getScoreText.text = input.Substring(133);
        }
    }
}
