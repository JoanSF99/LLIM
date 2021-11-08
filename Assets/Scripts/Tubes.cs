using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{
    public bool agua;
    public GameObject tube;

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
        if (agua)
        {
             sprite.color = new Color(0, 0, 1);
        }
        else sprite.color = new Color(1, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Tubes t = other.collider.GetComponent<Tubes>();
        if (t.agua)
        {
            agua = true;
            Debug.Log("fluye");
        }

    }

    void OnMouseDown()
    {
        
        Debug.Log("rotated");
       this.transform.Rotate(new Vector3(0,0,90));
        if (agua) agua = false;
    }
}
