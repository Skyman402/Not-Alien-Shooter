using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemy;
    [SerializeField] private Transform[] _enemySpawnPoint;
    [SerializeField] private float startTimeSpawn;

    private int rand;
    private int randPosition;
    private float timeBetwenSpawn;

    void Start()
    {
        
        timeBetwenSpawn = startTimeSpawn;
    }


    void Update()
    {
        if (timeBetwenSpawn <= 0)
        {
            rand = Random.Range(0, _enemy.Length);
            randPosition = Random.Range(0, _enemySpawnPoint.Length);
            Instantiate(_enemy[rand], _enemySpawnPoint[randPosition].transform.position, Quaternion.identity);
            timeBetwenSpawn = startTimeSpawn;
        }
        else
        {
            timeBetwenSpawn -= Time.deltaTime;
        }
    }
}
