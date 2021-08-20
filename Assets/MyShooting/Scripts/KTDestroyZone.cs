using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 부딪히면 없애버리겠다.
public class KTDestroyZone : MonoBehaviour
{
    // Enter, Stay, Exit
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            //탄창에 넣어주자
            // 1. Player 가 필요하다.
            // 2. Playerfire 컴포넌트가 필요하다.
            // 3. 탄창에 넣어주기
            other.gameObject.SetActive(false);
            KTPlayerFire.bulletPool.Add(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
