using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatrformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnInterval = 1.5f;
    public float xSpawnLimit;
    public float baslangýcYdegeri = 0f;
    public float arttýlaacakYdegeri = 2f;

    private float nextSpawnTime = 0f;

    private void Start()
    {
       
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPlatform();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnPlatform()
    {
        float randomX = Random.Range(-xSpawnLimit, xSpawnLimit);
        Vector3 spawnPosition = new Vector3(randomX, baslangýcYdegeri, 0f);

        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

        baslangýcYdegeri += arttýlaacakYdegeri;
    }
}
