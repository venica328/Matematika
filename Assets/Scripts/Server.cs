using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Server : MonoBehaviour
{
    public static Server instance;
    public string addScoreURL = "http://unity-matematika.cekuj.net/addscore.php?"; 
    private string secretKey = "janko"; // Edit this value and make sure it's the same as the one stored on the server
    [SerializeField]
    public Text sendScoreText, sendName;
    public string[] items;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        
        
    }

    public string Md5Sum(string strToEncrypt)
    {
        System.Text.UTF8Encoding ue = new System.Text.UTF8Encoding();
        byte[] bytes = ue.GetBytes(strToEncrypt);

        // encrypt bytes
        System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] hashBytes = md5.ComputeHash(bytes);

        // Convert the encrypted bytes back to a string (base 16)
        string hashString = "";

        for (int i = 0; i < hashBytes.Length; i++)
        {
            hashString += System.Convert.ToString(hashBytes[i], 16).PadLeft(2, '0');
        }

        return hashString.PadLeft(32, '0');
    }

    public void PostScoreButton()
    {
        StartCoroutine(PostScores(sendName.text, sendScoreText.text));
    }


    IEnumerator PostScores(string curName, string curScore)
    {
        List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        formData.Add(new MultipartFormFileSection("name", curName));
        formData.Add(new MultipartFormFileSection("score", curScore));
        string hash = Md5Sum(curName + curScore + secretKey);
        string post_url = addScoreURL + "name=" + curName + "&score=" + curScore + "&hash=" + hash;

        UnityWebRequest www = UnityWebRequest.Post(post_url, formData);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
            Debug.Log(www);
        }
    }

}
