using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 일정시간에 한번씩 적을 만들고 싶다.
// 필요속성 : 적공장, 생성시간, 경과시간
public class KTEnemyGOD : MonoBehaviour
{
    // 필요속성 : 적공장, 생성시간, 경과시간
    public GameObject enemyFactory;
    public float createTime = 2;
    float currentTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 일정시간에 한번씩 적을 만들고 싶다.
        // 1. 시간이 흘렀으니까
        currentTime += Time.deltaTime;
        // 2. 생성시간이 됐으니까
        if (currentTime > createTime)
        {
            // 3. 적을 만들고 싶다.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. 적을 배치하고 싶다.
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
