using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // 총알공장
    public GameObject bulletFactory;
    // 총구
    public Transform firePosition;

    void Update()
    {
        // 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
        // 1. 발사버튼을 누르면
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 총알 공장에서 총알을 생성한다.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. 총알을 총구에 배치한다.
            bullet.transform.position = firePosition.position;
        }
    }
}
