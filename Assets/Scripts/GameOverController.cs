using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public GameObject UI_Controller;
    public int scoreRecord;
    public Text scoreValue, lastRecord;


    public void Start()
    {
        scoreValue.text = "Puntuación Total: " + UI_Controller.GetComponent<ScoreController>().scoreResult.ToString();
        lastRecord.text = "Mejor Puntuación: " + PlayerPrefs.GetInt("newRecord", 0).ToString();
        scoreRecord = PlayerPrefs.GetInt("newRecord");
    }
    public void Update()
    {
        if (UI_Controller.GetComponent<ScoreController>().scoreResult > scoreRecord)
        {
            PlayerPrefs.SetInt("newRecord", UI_Controller.GetComponent<ScoreController>().scoreResult);
            lastRecord.text = "Mejor Puntuación: " + PlayerPrefs.GetInt("newRecord").ToString();
        }
    }
}
