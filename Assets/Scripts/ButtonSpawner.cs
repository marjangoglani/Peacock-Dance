using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    private float nextActionTime = 0.0f;
    private float period = 3f;

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            SpawnItem();
            nextActionTime += period;
        }
    }

    void SpawnItem()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        GameObject instance = Instantiate(myObjects[randomIndex]);

    }
}
