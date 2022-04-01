using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSpawn : MonoBehaviour
{
    public GameObject[] imagePrefabs;
    public float respawnTime;

    private void Start()
    {
        StartCoroutine(imageSpawner());
    }

    private void spawnImage(int prefb)
    {
        GameObject a = Instantiate(imagePrefabs[prefb] as GameObject);
        a.transform.position = gameObject.transform.position;
    }

    IEnumerator imageSpawner()
    {
        int prefb = Random.Range(0, imagePrefabs.Length);
        spawnImage(prefb);
        yield return new WaitForSeconds(respawnTime);
        StartCoroutine(imageSpawner());
    }
}
