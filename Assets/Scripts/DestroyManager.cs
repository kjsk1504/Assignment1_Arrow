using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Unity.VisualScripting;

public class DestroyManager : MonoBehaviour
{
    public GameObject target_scarecrow;
    public GameObject arrow;
    public Text time_text;
    public Text gameovertext;
    public GameObject gameover;
    public ScoreData score_data;
    public int target_hp = 10;
    private float playing_time;

    // Start is called before the first frame update
    void Start()
    {
        gameover.SetActive(false);
        playing_time = 0;
        TimeChecking();
        Debug.Log("게임 시작");
    }

    void TimeChecking()
    {
        int int_playing_time = Convert.ToInt32(Math.Round(playing_time));

        time_text.text = $"{(int_playing_time / 60):D2}:{(int_playing_time % 60):D2}";
    }

    void DestroyAction()
    {
        Destroy(GameObject.Find(arrow.name + "(Clone)"));
        Destroy(target_scarecrow);
        Time.timeScale = 0;
        gameover.SetActive(true);
        gameovertext.text += "\n" + playing_time + "s";
    }

    // Update is called once per frame
    void Update()
    {
        playing_time += Time.deltaTime;
        if (score_data.GetScore() >= score_data.hp) DestroyAction();
        TimeChecking();
    }
}
