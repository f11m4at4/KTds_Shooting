using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // 이동속도
    public float speed = 5;
    Transform target;
    Vector3 dir;

    public GameObject explosionFactory;

    void Start()
    {
        dir = Vector3.down;

        GameObject targetObj = GameObject.Find("Player");
        if (targetObj)
        {
            target = targetObj.transform;

            int rand = Random.Range(1, 100);
            if(rand > 50)
            {
                dir = target.position - transform.position;
            }
            dir.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (explosionFactory)
        {
            GameObject explosion = Instantiate(explosionFactory);
            explosion.transform.position = transform.position;
        }

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
