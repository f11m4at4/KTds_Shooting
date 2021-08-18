using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // 이동속도
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // P = P0 + vt
        Vector3 P0 = transform.position;
        Vector3 vt = Vector3.up * speed * Time.deltaTime;
        Vector3 P = P0 + vt;
        transform.position = P;
    }
}
