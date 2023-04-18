using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    private float nextActionTime = 1f;
    private float period = 2f;
    private int spawnCounter = 1;

    void Update()
    {
        if (Time.timeSinceLevelLoad > nextActionTime)
        {
            SpawnItem();
            nextActionTime += period;
            spawnCounter += 1;
        }

        if (spawnCounter % 5 == 0 && spawnCounter < 30)
        {
            period -= period * 0.15f;
            spawnCounter += 1;
        }
    }

    void SpawnItem()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        GameObject instance = Instantiate(myObjects[randomIndex]);
    }
}
