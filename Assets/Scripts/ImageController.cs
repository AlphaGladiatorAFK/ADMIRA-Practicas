using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        gameObject.transform.Translate(speed * Time.deltaTime, 0 , 0);
    }
}
