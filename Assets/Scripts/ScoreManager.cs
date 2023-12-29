using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager scoremanager;
    public GameObject target;
    public ScoreData score_data;
    public Text score_text;

    // Start is called before the first frame update
    void Start()
    {
        scoremanager = this;
        SetText();
    }

    public void SetText()
    {
        score_text.text = $"{score_data.GetScore()} / {score_data.hp}";
    }
}
