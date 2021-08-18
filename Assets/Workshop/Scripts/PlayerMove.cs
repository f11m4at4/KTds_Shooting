using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
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
        // P = P0 + vt
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(x, y, 0) * speed;
        Vector3 P0 = transform.position;
        Vector3 P = P0 + v * Time.deltaTime;
        transform.position = P;
    }
}
