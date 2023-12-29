using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "ScriptableObject/Data/Score")]
public class ScoreData : ScriptableObject
{
    public static int score = 0;
    public int hp = 10;

    /// <summary>
    /// ���� ���޹޾Ƽ� �� ����ŭ ������ ���ϴ� �Լ�
    /// </summary>
    /// <param name="value">�������� ��</param>
    public static void SetScore(int value)
    {
        score += value;
    }
    /// <summary>
    /// score�� ���� return ���ִ� �Լ�
    /// </summary>
    public int GetScore()
    {
        return score;
    }
}
