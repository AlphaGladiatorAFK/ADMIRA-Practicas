using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject gameOver;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "image")
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }
}
