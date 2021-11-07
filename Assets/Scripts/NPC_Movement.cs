using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Movement : MonoBehaviour
{
    public float speed = 2.0f;
    public bool vertical;
    public float changeTime = 2.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    float gradualspeed;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;
        gradualspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer < changeTime/3)
        {
            gradualspeed -= gradualspeed /100;
        }

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
            gradualspeed = speed;
        }


        Vector2 position = rigidbody2D.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * gradualspeed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * gradualspeed * direction;
        }

        rigidbody2D.MovePosition(position);
    }
}
