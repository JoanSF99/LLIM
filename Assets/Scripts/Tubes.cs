using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{
    public bool agua;
    public bool start;
    public bool block;
    public int id;

    public GameObject tube;

    public Tubes fuente;
    public Tubes siguiente;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        tube.GetComponent<GameObject>();
        animator = tube.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (start)
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

            if (agua && siguiente != null)
            {
                siguiente.agua = true;
                siguiente.fuente = this;
            }
        }
        

        if (agua)
        {
             animator.SetBool("Agua",true); 
        }
        else animator.SetBool("Agua", false);
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        Tubes t = other.collider.GetComponent<Tubes>();
        if (!agua)
        {
            
            if (t.agua)
            {
                fuente = t;
                agua = true;
                Debug.Log("fluye");
            }
        }
        else
        {
            
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
        if (!block)
        {
            Debug.Log("rotated");
            this.transform.Rotate(new Vector3(0, 0, 90));
            fuente = null;
            siguiente = null;
        }

    }
}
