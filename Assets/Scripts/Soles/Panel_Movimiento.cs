using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Movimiento : MonoBehaviour
{

    private Rigidbody2D myBody;

    public float velocidad,xBound;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
        {
            myBody.velocity = Vector2.right * velocidad;
        }
        else if (h < 0)
        {
            myBody.velocity = Vector2.left * velocidad;
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound),transform.position.y);
    }
}
