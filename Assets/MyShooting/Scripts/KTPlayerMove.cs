using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KTPlayerMove : MonoBehaviour
{
    // �̵��ӵ�
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
        // ����� �Է¿� ���� ���� �¿�� �̵��ϰ� �ʹ�.
        // 1. ����� �Է¿����� a, d, left, right
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        // 2. ������ �ʿ��ϴ�.
        Vector3 v = Vector3.right * x + Vector3.up * y;
        v.Normalize();
        v *= speed;

        // 3. �̵��ϰ� �ʹ�.
        Vector3 P0 = transform.position;
        Vector3 vt = v * Time.deltaTime;
        Vector3 P = P0 + vt;

        transform.position = P;
    }
}
