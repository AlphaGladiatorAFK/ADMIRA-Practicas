using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScoreValue : MonoBehaviour
{
    public int scoreToSend;
    public GameObject _scoreController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _scoreController.GetComponent<ScoreController>().score = scoreToSend;
    }
}
