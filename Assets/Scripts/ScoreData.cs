using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "ScriptableObject/Data/Score")]
public class ScoreData : ScriptableObject
{
    public static int score = 0;
    public int hp = 10;

    /// <summary>
    /// 값을 전달받아서 그 값만큼 점수를 더하는 함수
    /// </summary>
    /// <param name="value">전달해줄 값</param>
    public static void SetScore(int value)
    {
        score += value;
    }
    /// <summary>
    /// score의 값을 return 해주는 함수
    /// </summary>
    public int GetScore()
    {
        return score;
    }
}
