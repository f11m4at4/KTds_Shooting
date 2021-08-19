using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
// 필요속성 : 총알공장, 총구
public class KTPlayerFire : MonoBehaviour
{
    // 필요속성 : 총알공장, 총구
    public GameObject bulletFactory;
    public Transform firePositionLeft;
    public Transform firePositionRight;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
        // 1. 사용자가 발사버튼을 눌렀으니까
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. 총알이 만들어야 한다.
            GameObject bullet1 = Instantiate(bulletFactory);
            // 3. 총알을 발사하고 싶다. (배치한다.)
            // 총구의 위치에 배치
            bullet1.transform.position = firePositionLeft.position;

            GameObject bullet2 = Instantiate(bulletFactory);
            bullet2.transform.position = firePositionRight.position;
        }
    }
}
