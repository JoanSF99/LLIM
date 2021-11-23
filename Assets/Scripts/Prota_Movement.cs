using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prota_Movement : MonoBehaviour
{
    public float speed = 2.5f;
    public Animator animator;

    Rigidbody2D rb;

    Vector2 movement;

    Vector2 lookDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        //Vector2 move = new Vector2(horizontal, vertical);

        //if (!Mathf.Approximately(movement.x, 0.0f) || !Mathf.Approximately(movement.y, 0.0f))
        //{
        //    lookDirection.Set(movement.x, movement.y);
        //    lookDirection.Normalize();
        //}

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.SqrMagnitude());

    }

    private void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}