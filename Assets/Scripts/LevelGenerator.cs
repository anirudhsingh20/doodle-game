using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;

    public int numberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPos = new Vector3();
        for( int i = 0; i< numberOfPlatforms; i++)
        {
            spawnPos.y += Random.Range(minY, maxY);
            spawnPos.x = Random.Range(-levelWidth, +levelWidth);

            Instantiate(platformPrefab, spawnPos, Quaternion.identity);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
