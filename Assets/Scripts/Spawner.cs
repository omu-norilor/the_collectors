using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float xLimitRight, xLimitLeft;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private GameObject[] dropPrefab;
    [SerializeField]
    private Wave wave;
    private float currentTime;
    List<float> remainingPositions = new List<float>();
    private int waveIndex;
    float xPos = 0;
    int rand;
    void Start()
    {
        currentTime = 0;
        remainingPositions.AddRange(xPositions);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
            selectWave();

    }
    void SpawnDrop(float xPos)
    {
        int r = Random.Range(0, 1);
        GameObject dropObj = Instantiate(dropPrefab[r], new Vector3(xPos, transform.position.y, 0), Quaternion.identity);
    }
    void selectWave()
    {
        remainingPositions = new List<float>();
        remainingPositions.AddRange(xPositions);
        waveIndex = 1;
        currentTime = wave.delayTime;
        xPos = Random.Range(xLimitLeft, xLimitRight);
        SpawnDrop(xPos);
    }
}

[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}
