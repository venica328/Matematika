using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{
    public Text finalScore;

    //metóda, ktorá zobrazí výsledné skóre hráča
    private void Start()
    {
        finalScore.text = "" + Game.instance.finalScore;
    }
}
