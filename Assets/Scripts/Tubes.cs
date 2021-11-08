using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{
    public bool agua;
    public bool Block;
    public GameObject tube;

    public Tubes fuente;
    public Tubes siguiente;

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        tube.GetComponent<GameObject>();
        sprite = tube.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Block)
        {
            agua = true;
        }
        else
        {
            if (fuente != null)
            {
                if (!fuente.agua)
                {
                    fuente = null;
                    agua = false;
                }

            }
            else
            {
                agua = false;
            }
        }
        

        if (agua)
        {
             sprite.color = new Color(0, 0, 1);
        }
        else sprite.color = new Color(1, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (!agua)
        {
            Tubes t = other.collider.GetComponent<Tubes>();
            if (t.agua)
            {
                fuente = t;
                agua = true;
                Debug.Log("fluye");
            }
        }
        else
        {
            Tubes t = other.collider.GetComponent<Tubes>();
            if (!t.agua)
            {
                siguiente = t;
                t.fuente = this;
                t.agua = true;
                if (t.siguiente != null)
                {
                    t.siguiente.agua = true;
                }
                Debug.Log("fluye");
            }
        }
        
    }

    void OnMouseDown()
    {
        if (!Block)
        {
            Debug.Log("rotated");
            this.transform.Rotate(new Vector3(0, 0, 90));
            fuente = null;
            siguiente = null;
        }

    }
}
