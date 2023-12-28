using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ArrowPrefab;
    public Transform Arrow_transform;
    [Range(0, 100)] public float shoot_speed;

    Vector2 LookAt()
    {
        Vector2 mouse_position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = new Vector2(mouse_position.x - Arrow_transform.position.x, mouse_position.y - Arrow_transform.position.y);
        Arrow_transform.right = dir;
        return dir;
    }

    void Fire()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(ArrowPrefab, Arrow_transform.position, Arrow_transform.rotation);
            go.GetComponent<Rigidbody2D>().gravityScale = 0;
            go.transform.right = LookAt();
        }
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
    }
}
