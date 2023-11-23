using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyscraperSpawner : MonoBehaviour
{
    public int numberOfSkyscrapers = 3;
    public float distanceBetweenSkyscrapers = 10.0f;
    public float skyscraperHeightMin = 5.0f;
    public float skyscraperHeightMax = 15.0f;
    public float skyscraperWidth = 5.0f;

    void Start()
    {
        SpawnSkyscrapers();
    }

    void SpawnSkyscrapers()
    {
        for (int i = 0; i < numberOfSkyscrapers; i++)
        {
            // Calculate the position using vector math
            Vector3 spawnPosition = transform.position + i * distanceBetweenSkyscrapers * transform.right;

            // Instantiate a skyscraper cube
            GameObject skyscraper = CreateSkyscraperCube(spawnPosition);

            // Set a random height and width for the skyscraper
            float randomHeight = Random.Range(skyscraperHeightMin, skyscraperHeightMax);
            skyscraper.transform.localScale = new Vector3(skyscraperWidth, randomHeight, skyscraperWidth);

            // Set a random color for the skyscraper
            skyscraper.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }

    GameObject CreateSkyscraperCube(Vector3 position)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = position;
        return cube;
    }
}