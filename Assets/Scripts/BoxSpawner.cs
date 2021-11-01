using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField]
    private float xLimitRight, xLimitLeft;
    [SerializeField]
    private float yLimitUp, yLimitDown;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private float[] yPositions;
    [SerializeField]
    private GameObject[] dropPrefab;
    [SerializeField]
    private Drop drop;
    private float currentTime;
    List<float> remainingPositions = new List<float>();
    private int waveIndex;
    float xPos = 0, yPos = 0;
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
    void SpawnDrop(float xPos, float yPos, int prefab)
    {
        GameObject dropObj = Instantiate(dropPrefab[prefab], new Vector3(xPos, yPos, 0), Quaternion.identity);
    }
    void selectWave()
    {
        int prefab;
        remainingPositions = new List<float>();
        remainingPositions.AddRange(xPositions);
        waveIndex = 1;
        currentTime = drop.delayTime;
        xPos = Random.Range(1, 5);
        xPos = xPositions[(int)xPos];
        yPos = Random.Range(0, 10);
        if (yPos == 9)
        { 
            yPos = yLimitDown;
            prefab = 1;
        }
        else 
        { 
            yPos = yLimitUp;
            prefab = 0;
        }
        SpawnDrop(xPos, yPos,prefab);
    }
}
[System.Serializable]
public class Drop
{
    public float delayTime;
    public float spawnAmount;
}
