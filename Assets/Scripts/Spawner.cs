using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private int xLimitRight, xLimitLeft;
    [SerializeField]
    private float[] xPositions;
    [SerializeField]
    private GameObject[] dropPrefab;
    [SerializeField]
    private Wave wave;
    private float currentTime;
    //List<float> remainingPositions = new List<float>();
    private int waveIndex;
    int xPos = 0, prev_xPos = 0, range;
    int rand;
    void Start()
    {
        range = (xLimitRight - xLimitLeft) / 2 + (xLimitRight - xLimitLeft) % 2;
        currentTime = 0;
        //remainingPositions.AddRange(xPositions);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0)
            selectWave();

    }
    void SpawnDrop(int xPos)
    {
        int r = Random.Range(0, 1);
        GameObject dropObj = Instantiate(dropPrefab[r], new Vector3(xPositions[xPos], transform.position.y, 0), Quaternion.identity);
    }
    void selectWave()
    {
        //remainingPositions = new List<float>();
        //remainingPositions.AddRange(xPositions);
        waveIndex = 1;
        currentTime = wave.delayTime;
        generate_random_positon();
        SpawnDrop(xPos);
    }
    void generate_random_positon()
    {
        int L = max(xLimitLeft, (prev_xPos - range));
        int R = min(xLimitRight, (prev_xPos + range));
        Debug.Log("Left" + L);
        Debug.Log("Right" + R);
        while (xPos == prev_xPos)
            xPos = (int)Random.Range(L, R);
        prev_xPos = xPos;
    }
    public int max(int a, int b)
    {
        if (a > b) return a;
        return b;
    }
    public int min(int a, int b)
    {
        if (a < b) return a;
        return b;
    }
}

[System.Serializable]
public class Wave
{
    public float delayTime;
    public float spawnAmount;
}


