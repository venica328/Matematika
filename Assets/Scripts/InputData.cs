using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputData : MonoBehaviour
{

    public Text finalScore;
    // Start is called before the first frame update
    void Start()
    {
        finalScore.text = "" + Game.instance.finalScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
