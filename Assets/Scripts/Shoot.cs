using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public GameObject arrow;
    public Transform Arrow_transform;
    [Range(0, 100)]public float shoot_speed;

    //public int maxPrefabCount = 1; // 최대 생성 개수
    //private int currentPrefabCount = 0;

    Vector2 LookAt()
    {
        Vector2 mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = new Vector2(mouse_position.x - Arrow_transform.position.x, mouse_position.y - Arrow_transform.position.y);
        if (Time.timeScale == 0)
        {
            dir = Vector2.zero;
        }
        Arrow_transform.right = dir;
        return dir;
    }

    private void Fire()
    {
        arrow = Instantiate(ArrowPrefab, Arrow_transform.position, Arrow_transform.rotation);
        arrow.GetComponent<Rigidbody2D>().velocity = Arrow_transform.transform.right * shoot_speed;
        //currentPrefabCount++;
        //go.transform.right = LookAt();
        //go.GetComponent<Rigidbody2D>().gravityScale = 0;
        //if (Input.GetMouseButtonUp(0))
        //{
            
        //    go.GetComponent<Rigidbody2D>().gravityScale = 1;
        //    shoot_speed = 10;
        //}
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
        //if (Input.GetMouseButton(0) && (currentPrefabCount < maxPrefabCount))
        //{
        //    Fire();
        //}
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void OnDestroy()
    {
        Debug.Log("화살이 파괴됨");
    }
}
