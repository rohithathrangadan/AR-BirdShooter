using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBirds : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] birds;
    private bool shouldSpawn = true; //Flag to control spawning
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //stop spawning when space key is pressed
            shouldSpawn = false;
        }

    }
    IEnumerator SpawnCoroutine()
    {
        //continuous spawning as long as shouldSpawn is true
        while (shouldSpawn)
        {
            Instantiate(birds[Random.Range(0, birds.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
            yield return new WaitForSeconds(Random.Range(0.8f, 3.0f));
        }
    }
}
