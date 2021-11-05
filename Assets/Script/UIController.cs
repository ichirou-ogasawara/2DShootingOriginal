using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameObject scoreText;
    private GameObject resultText;
    [SerializeField] GameObject button;

    public static float score;
    public static bool isGameEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText");
        resultText = GameObject.Find("ResultText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "Score: " + score.ToString("F1");
    }

    public void GameOver()
    {
        this.resultText.GetComponent<Text>().text = "Game Over";
        isGameEnd = true;
        button.SetActive(true);
    }

    public void GameClear()
    {
        this.resultText.GetComponent<Text>().text = "Game Clear";
        isGameEnd = true;
        button.SetActive(true);
    }
}
