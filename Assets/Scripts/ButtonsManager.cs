using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public GameObject _gameOverController;
    public void closeApp()
    {
        Application.Quit();
    }

    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void backMenu()
    {
        SceneManager.LoadScene("Welcome");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Welcome");
        Time.timeScale = 1;
    }

    public void deleteSaves()
    {
        PlayerPrefs.DeleteKey("newRecord");
        _gameOverController.GetComponent<GameOverController>().lastRecord.text = "0";
    }
}
