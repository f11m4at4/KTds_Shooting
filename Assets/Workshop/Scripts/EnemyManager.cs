using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float minTime = 2;
    public float maxTime = 5;

    float createTime = 0;
    float currentTime = 0;

    public GameObject enemyFactory;

    void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > createTime)
        {
            currentTime = 0;
            createTime = Random.Range(minTime, maxTime);
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;
        }
    }
}
