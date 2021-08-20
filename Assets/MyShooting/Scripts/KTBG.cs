using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� ��ũ�� �ϰ� �ʹ�.
// -> ���ӿ�����Ʈ�� MeshRenderer ������Ʈ�� �ִ�
//    Material �� Offset ���� �����Ű�� �ʹ�.
// �ʿ�Ӽ� : ��ũ�� �ӵ�, Material
public class KTBG : MonoBehaviour
{
    // �ʿ�Ӽ� : ��ũ�� �ӵ�, Material
    public float scrollSpeed = 0.1f;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        //���ӿ�����Ʈ�� MeshRenderer ������Ʈ�� �ִ�
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        //    Material �� Offset ���� �����Ű�� �ʹ�.
        // P = P0 + vt
        Vector2 vt = Vector2.up * scrollSpeed * Time.deltaTime;
        mat.mainTextureOffset += vt;
    }
}
