using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageDestroy : MonoBehaviour
{
    public string letterDestroy;
    public GameObject _scoreController;

    public void Start()
    {
        _scoreController = GameObject.Find("UI");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (Input.GetKey(letterDestroy.ToString())){
            _scoreController.GetComponent<ScoreController>().incrementScore();
            Destroy(gameObject);
        }
    }
}
