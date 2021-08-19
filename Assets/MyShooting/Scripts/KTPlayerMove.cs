using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTPlayerMove : MonoBehaviour
{
    // 이동속도
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.right * speed * Time.deltaTime);
        // P = P0 + vt
        // 사용자 입력에 따라 상하 좌우로 이동하고 싶다.
        // 1. 사용자 입력에따라 a, d, left, right
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // 2. 방향이 필요하다.
        Vector3 v = Vector3.right * x + Vector3.up * y;
        v.Normalize();
        v *= speed;

        // 3. 이동하고 싶다.
        Vector3 P0 = transform.position;
        Vector3 vt = v * Time.deltaTime;
        Vector3 P = P0 + vt;

        transform.position = P;
    }
}
