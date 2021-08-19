using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 아래로 계속 내려가고 싶다
// 타겟을 계속 따라다니고 싶다.
// 필요속성 : 타겟

// 태어날때 딱 한번만 방향을 구하고, 계속 그 방향으로 이동하고 싶다.
// 50 % 확률로 아래로 혹은 타겟 쪽으로 이동하게 하고 싶다.
public class KTEnemy : MonoBehaviour
{
    public float speed = 5;
    public GameObject target;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        // direction = target - me
        // 50 % 확률로 아래로 혹은 타겟 쪽으로 이동하게 하고 싶다.
        int rand = Random.Range(1, 101);
        if (target == null || rand < 50)
        {
            dir = Vector3.down;
        }
        else
        {
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 타겟을 계속 따라다니고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }

    // 나랑 부딪히면 갸도 죽고, 나도 죽는겨~~~~ Enter, Stay, Exit
    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
