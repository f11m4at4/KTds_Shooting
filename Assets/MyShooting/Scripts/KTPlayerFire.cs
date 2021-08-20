using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
// �ʿ�Ӽ� : �Ѿ˰���, �ѱ�

// źâ�� �����ʹ�.
// �ʿ�Ӽ� : źâ, źâũ��
public class KTPlayerFire : MonoBehaviour
{
    // �ʿ�Ӽ� : �Ѿ˰���, �ѱ�
    public GameObject bulletFactory;
    public Transform firePositionLeft;
    public Transform firePositionRight;

    // �ʿ�Ӽ� : źâ, źâũ��
    //[HideInInspector]
    public static List<GameObject> bulletPool = new List<GameObject>();

    public int bulletPoolSize = 20;
    void Start()
    {
        // źâ ũ�⸸ŭ �Ѿ��� ���� źâ�� �־� ����
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
        // ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
        // 1. ����ڰ� �߻��ư�� �������ϱ�
        if (Input.GetButtonDown("Fire1"))
        {
            // ���� źâ�� �ι� �̻� ��������� �Ѿ��� ���� �߻�����
            if (bulletPool.Count >= 2)
            {
                // 2. �Ѿ��� ������ �Ѵ�.
                GameObject bullet1 = bulletPool[0];
                bullet1.SetActive(true);
                // 3. �Ѿ��� �߻��ϰ� �ʹ�. (��ġ�Ѵ�.)
                // �ѱ��� ��ġ�� ��ġ
                bullet1.transform.position = firePositionLeft.position;
                // �Ѿ��� ������ �����Ѵ�.
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
