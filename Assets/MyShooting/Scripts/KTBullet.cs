using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��� ���� �̵��ϰ� �ʹ�.
// �ʿ�Ӽ� : �̵��ӵ�
public class KTBullet : MonoBehaviour
{
    // �ʿ�Ӽ� : �̵��ӵ�
    public float speed = 5;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // ��� ���� �̵��ϰ� �ʹ�.
        // P = P0 + vt
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
