using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Homework task 2: use loops to spawn grenades in a border pattern (see blackboard task 2 image, 1%)
    public GameObject grenade;
    public Vector3 spawnPosition;
    void Start()
    {
        //TestWhileLoop();
        //TestForLoop();
        SpawnGrenades(420);
    }

    void TestWhileLoop()
    {
        int counter = 1;
        while (counter <= 5)
        {
            Debug.Log("Looping x" + counter);
            counter++;
        }
        Debug.Log("No longer looping");
    }

    void TestForLoop()
    {
        for (int counter = 1; counter <= 5; counter++)
        {
            Debug.Log("Looping x" + counter);
        }
        Debug.Log("No longer looping");
    }

    void SpawnGrenades(int grenadeCount)
    {
        for (int i = 0; i < grenadeCount; i++)
        {
            float xMin, xMax, zMin, zMax;
            xMin = zMin = -100.0f;
            xMax = zMax = 100.0f;
            Vector3 grenadePosition = spawnPosition + new Vector3(Random.Range(xMin, xMax), 0.0f, Random.Range(zMin, zMax));
            Destroy(Instantiate(grenade, grenadePosition, Quaternion.identity), 5.0f);
        }
    }
}