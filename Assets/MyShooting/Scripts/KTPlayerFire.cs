using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
// 필요속성 : 총알공장, 총구

// 탄창을 만들고싶다.
// 필요속성 : 탄창, 탄창크기
public class KTPlayerFire : MonoBehaviour
{
    // 필요속성 : 총알공장, 총구
    public GameObject bulletFactory;
    public Transform firePositionLeft;
    public Transform firePositionRight;

    // 필요속성 : 탄창, 탄창크기
    //[HideInInspector]
    public static List<GameObject> bulletPool = new List<GameObject>();

    public int bulletPoolSize = 20;
    void Start()
    {
        // 탄창 크기만큼 총알을 만들어서 탄창에 넣어 놓자
        for (int i = 0; i < bulletPoolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자가 발사버튼을 누르면 총알을 발사하고 싶다.
        // 1. 사용자가 발사버튼을 눌렀으니까
        if (Input.GetButtonDown("Fire1"))
        {
            // 만약 탄창에 두발 이상 들어있으면 총알을 만들어서 발사하자
            if (bulletPool.Count >= 2)
            {
                // 2. 총알이 만들어야 한다.
                GameObject bullet1 = bulletPool[0];
                bullet1.SetActive(true);
                // 3. 총알을 발사하고 싶다. (배치한다.)
                // 총구의 위치에 배치
                bullet1.transform.position = firePositionLeft.position;
                // 총알의 방향을 설정한다.
                bullet1.transform.up = firePositionLeft.up;

                GameObject bullet2 = bulletPool[1];
                bullet2.SetActive(true);

                bullet2.transform.position = firePositionRight.position;
                bullet2.transform.up = firePositionRight.up;

                bulletPool.Remove(bullet1);
                bulletPool.Remove(bullet2);
            }
        }
    }
}
