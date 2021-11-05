using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score : " + PlayerPrefs.GetFloat("highscore", 0).ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
