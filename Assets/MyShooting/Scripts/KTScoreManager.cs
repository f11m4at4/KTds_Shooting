using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 1. 점수 UI 를 업데이트 하고 싶다.
// 필요속성 : 현재점수 UI, 최고점수UI
public class KTScoreManager : MonoBehaviour
{
    public static KTScoreManager Instance;

    // 필요속성 : 현재점수 UI, 최고점수UI
    public Text currentScoreUI;
    public Text topScoreUI;

    int curScore;
    int topScore;

    public int Score
    {
        get
        {
            return curScore;
        }
        set
        {
            curScore = value;
            currentScoreUI.text = "Current Score : " + curScore;

            // 현재점수가 최고점수를 넘어서면 최고점수를 현재점수로 갱신
            if (curScore > topScore)
            {
                topScore = curScore;
                topScoreUI.text = "Top Score : " + topScore;
            }
        }
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SetScore(int value)
    {
        curScore = value;
        currentScoreUI.text = "Current Score : " + curScore;

        // 현재점수가 최고점수를 넘어서면 최고점수를 현재점수로 갱신
        if(curScore > topScore)
        {
            topScore = curScore;
            topScoreUI.text = "Top Score : " + topScore;
        }
    }

    public int GetScore()
    {
        return curScore;
    }
}
