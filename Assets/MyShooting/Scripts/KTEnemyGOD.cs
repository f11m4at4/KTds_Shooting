using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ð��� �ѹ��� ���� ����� �ʹ�.
// �ʿ�Ӽ� : ������, �����ð�, ����ð�
public class KTEnemyGOD : MonoBehaviour
{
    // �ʿ�Ӽ� : ������, �����ð�, ����ð�
    public GameObject enemyFactory;
    public float createTime = 2;
    float currentTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �����ð��� �ѹ��� ���� ����� �ʹ�.
        // 1. �ð��� �귶���ϱ�
        currentTime += Time.deltaTime;
        // 2. �����ð��� �����ϱ�
        if (currentTime > createTime)
        {
            // 3. ���� ����� �ʹ�.
            GameObject enemy = Instantiate(enemyFactory);
            // 4. ���� ��ġ�ϰ� �ʹ�.
            enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
