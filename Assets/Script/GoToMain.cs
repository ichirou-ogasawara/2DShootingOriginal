using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMain : MonoBehaviour
{

    public void PushGoToMainButton()
    {
        SceneManager.LoadScene("MainScene");
        BackgroundController.isComingBoss = false;
        UIController.isGameEnd = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
