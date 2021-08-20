using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ε����� ���ֹ����ڴ�.
public class KTDestroyZone : MonoBehaviour
{
    // Enter, Stay, Exit
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            //źâ�� �־�����
            // 1. Player �� �ʿ��ϴ�.
            // 2. Playerfire ������Ʈ�� �ʿ��ϴ�.
            // 3. źâ�� �־��ֱ�
            other.gameObject.SetActive(false);
            KTPlayerFire.bulletPool.Add(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
