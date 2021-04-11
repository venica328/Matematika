using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{
    public Text finalScore;
    private void Start()
    {
        finalScore.text = "" + Game.instance.finalScore;
    }
}
