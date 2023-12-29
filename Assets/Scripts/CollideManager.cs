using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CollideManager : MonoBehaviour
{
    [Range(0,10)]public int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "10") ; //score += 10;
        //else if (collision.tag == "8") ;// score += 8;
        //else if (collision.tag == "6") ; //score += 6;
        //else if (collision.tag == "4") ; //score += 4;
        //else if (collision.tag == "2") ; //score += 2;
        //else Debug.Log("���� : �ƹ��͵� �ȸ���");
        //GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        //GetComponent<Rigidbody2D>().gravityScale = 0;
        if (collision.tag == "Target")
        {
            score++;
            ScoreData.SetScore(score);
            ScoreManager.scoremanager.SetText();
            GetComponent<Rigidbody2D>().gravityScale = 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;   
        }
        if (collision.tag == "Bottom")
        {
            Debug.Log("ȭ���� ���� ����");
            Destroy(gameObject, 1.0f);
        }

        //if (score > 10) 
        //{
        //    Debug.Log("���� �ı�");
        //    Destroy(collision.gameObject);
        //    Destroy(gameObject);
        //    Time.timeScale = 0;
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
