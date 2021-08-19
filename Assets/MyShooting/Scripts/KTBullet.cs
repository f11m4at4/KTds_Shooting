using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 계속 위로 이동하고 싶다.
// 필요속성 : 이동속도
public class KTBullet : MonoBehaviour
{
    // 필요속성 : 이동속도
    public float speed = 5;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // 계속 위로 이동하고 싶다.
        // P = P0 + vt
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
