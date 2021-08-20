using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// 메뉴씬에서 Shooting 씬으로 전환하고 싶다.
public class KTGameStart : MonoBehaviour
{
    public void GotoGame()
    {
        SceneManager.LoadScene(1);
    }    
}
