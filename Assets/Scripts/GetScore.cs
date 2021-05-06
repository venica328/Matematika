using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class GetScore : MonoBehaviour
{
    public static GetScore Instance;
    public string HighscoreURL = "http://unity-matematika.cekuj.net/display.php";
    public Text GetScoreText;

    /// <summary>
    /// metóda, ktorá zavolá metódu GetScore() a zobrazí v hre skóre hráčov
    /// </summary>
    void Start()
    {
        StartCoroutine(GetScores());
    }

    /// <summary>
    /// metóda, ktorá zobrazí skóre hráčov zo servera
    /// </summary>
    /// <returns>vráti dáta zo servera alebo error</returns>
    IEnumerator GetScores()
    {
        GetScoreText.text = "Loading data";
        UnityWebRequest www = UnityWebRequest.Get(HighscoreURL);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            GetScoreText.text = "Loading data failed!";
            Debug.Log(www.error);
        }
        else
        {
            string input = www.downloadHandler.text;
            input.Substring(133);
            Debug.Log(input.Substring(133));
            GetScoreText.text = input.Substring(133);
        }
    }
}
