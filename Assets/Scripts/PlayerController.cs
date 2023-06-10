using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private BoxCollider2D bc;
    public float moveSpeed = 5f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += (moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= (moveSpeed * Time.deltaTime);
        }

        transform.position = pos;
    }
}
