using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int score;
    public int scoreResult;
    public Text txtScore;


    public void Update()
    {

    }

    public void incrementScore()
    {
        scoreResult += score;
        showResult();
        if (scoreResult >= 20)
        {
            Time.timeScale = 1.5f;
        }
        if (scoreResult >= 40)
        {
            Time.timeScale = 2f;
        }
        if (scoreResult >= 60)
        {
            Time.timeScale = 2.5f;
        }
        if (scoreResult >= 80)
        {
            Time.timeScale = 3.5f;
        }
        if (scoreResult >= 100)
        {
            Time.timeScale = 4f;
        }
    }

    public void showResult()
    {
        txtScore.text = scoreResult.ToString();
    }
}
