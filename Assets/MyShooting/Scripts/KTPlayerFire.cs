using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
// �ʿ�Ӽ� : �Ѿ˰���, �ѱ�
public class KTPlayerFire : MonoBehaviour
{
    // �ʿ�Ӽ� : �Ѿ˰���, �ѱ�
    public GameObject bulletFactory;
    public Transform firePosition;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
        // 1. ����ڰ� �߻��ư�� �������ϱ�
        if (Input.GetButtonDown("Fire1"))
        {
            // 2. �Ѿ��� ������ �Ѵ�.
            GameObject bullet = Instantiate(bulletFactory);
            // 3. �Ѿ��� �߻��ϰ� �ʹ�. (��ġ�Ѵ�.)
            // �ѱ��� ��ġ�� ��ġ
            bullet.transform.position = firePosition.position;
        }
    }
}
