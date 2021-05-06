using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{
    public Text FinalScore;

    /// <summary>
    /// metóda, ktorá zobrazí výsledné skóre hráča
    /// </summary>
    private void Start()
    {
        FinalScore.text = "" + Game.Instance.FinalScore;
    }
}
