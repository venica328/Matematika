using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Server : MonoBehaviour
{
    public static Server Instance;
    public string AddScoreURL = "http://unity-matematika.cekuj.net/addscore.php?"; 
    private readonly string secretKey = "janko"; 

    [SerializeField]
    public Text SendScoreText, SendName;

    /// <summary>
    /// metóda, ktorá vytvorí inštanciu triedy
    /// </summary>
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    /// <summary>
    /// metóda, ktorá zakóduje dáta, ktorá sa budú posielať na server
    /// </summary>
    /// <param name="strToEncrypt"></param>
    /// <returns>hash</returns>
    private string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }
        return hashString.PadLeft(32, '0');
    }

    /// <summary>
    /// metóda pre button, kedy sa po kliknutí naň pošlú dáta na server
    /// </summary>
    public void PostScoreButton()
    {
        StartCoroutine(PostScores(SendName.text, SendScoreText.text));
    }

    /// <summary>
    /// metóda, ktorá zabezpčuje aké dáta sa budú posielať na server
    /// </summary>
    /// <param name="curName"></param>
    /// <param name="curScore"></param>
    /// <returns>vráti buď, že sa dáta poslali alebo nie</returns>
    IEnumerator PostScores(string curName, string curScore)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormFileSection("name", curName));
        formData.Add(new MultipartFormFileSection("score", curScore));
        string hash = Md5Sum(curName + curScore + secretKey);
        string post_url = AddScoreURL + "name=" + curName + "&score=" + curScore + "&hash=" + hash;

        UnityWebRequest www = UnityWebRequest.Post(post_url, formData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log("Form upload failed!");
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
            Debug.Log(www);
        }
    }
}
