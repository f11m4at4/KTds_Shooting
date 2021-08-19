using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �Ʒ��� ��� �������� �ʹ�
// Ÿ���� ��� ����ٴϰ� �ʹ�.
// �ʿ�Ӽ� : Ÿ��

// �¾�� �� �ѹ��� ������ ���ϰ�, ��� �� �������� �̵��ϰ� �ʹ�.
// 50 % Ȯ���� �Ʒ��� Ȥ�� Ÿ�� ������ �̵��ϰ� �ϰ� �ʹ�.

// ���� �� ���� ȿ���� ����ϰ� �ʹ�.
// �ʿ�Ӽ� : ����ȿ�� ����
public class KTEnemy : MonoBehaviour
{
    public float speed = 5;
    public GameObject target;
    Vector3 dir;
    // �ʿ�Ӽ� : ����ȿ�� ����
    public GameObject explosionFactory;

    // Start is called before the first frame update
    void Start()
    {
        // �¾�� Ÿ���� ã�Ƽ� �Ҵ��� ����
        target = GameObject.Find("Player");

        // direction = target - me
        // 50 % Ȯ���� �Ʒ��� Ȥ�� Ÿ�� ������ �̵��ϰ� �ϰ� �ʹ�.
        int rand = Random.Range(1, 101);
        if (target == null || rand < 50)
        {
            dir = Vector3.down;
        }
        else
        {
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Ÿ���� ��� ����ٴϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }

    // ���� �ε����� ���� �װ�, ���� �״°�~~~~ Enter, Stay, Exit
    // ���� �� ���� ȿ���� ����ϰ� �ʹ�.
    private void OnCollisionEnter(Collision other)
    {
        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
