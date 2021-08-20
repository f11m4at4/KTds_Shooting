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
        // ���� �� ���� �÷�����.
        KTScoreManager.Instance.Score++;

        GameObject explosion = Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        
        // �ε��� ����� �Ѿ��̶�� źâ�� �־�����
        // �̸�, tag, layer
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
        Destroy(gameObject);
    }
}
