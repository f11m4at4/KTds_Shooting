using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// �޴������� Shooting ������ ��ȯ�ϰ� �ʹ�.
public class KTGameStart : MonoBehaviour
{
    public void GotoGame()
    {
        SceneManager.LoadScene(1);
    }    
}
