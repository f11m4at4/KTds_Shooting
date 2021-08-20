using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 배경을 스크롤 하고 싶다.
// -> 게임오브젝트의 MeshRenderer 컴포넌트에 있는
//    Material 의 Offset 값을 변경시키고 싶다.
// 필요속성 : 스크롤 속도, Material
public class KTBG : MonoBehaviour
{
    // 필요속성 : 스크롤 속도, Material
    public float scrollSpeed = 0.1f;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        //게임오브젝트의 MeshRenderer 컴포넌트에 있는
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        //    Material 의 Offset 값을 변경시키고 싶다.
        // P = P0 + vt
        Vector2 vt = Vector2.up * scrollSpeed * Time.deltaTime;
        mat.mainTextureOffset += vt;
    }
}
