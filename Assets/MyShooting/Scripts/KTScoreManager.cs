using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 1. ���� UI �� ������Ʈ �ϰ� �ʹ�.
// �ʿ�Ӽ� : �������� UI, �ְ�����UI
public class KTScoreManager : MonoBehaviour
{
    public static KTScoreManager Instance;

    // �ʿ�Ӽ� : �������� UI, �ְ�����UI
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

            // ���������� �ְ������� �Ѿ�� �ְ������� ���������� ����
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

        // ���������� �ְ������� �Ѿ�� �ְ������� ���������� ����
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
