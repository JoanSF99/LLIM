using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balas : MonoBehaviour
{

    public float launchVelocity = 700f;
    Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D> ();
        rb.AddRelativeForce(new Vector3 (launchVelocity,0 ,0));
    }

    void OnTriggerEnter2D(Collider2D otro){
        if (otro.gameObject.tag == "cañon" ){
            Debug.Log(otro);
            Destroy(gameObject);
        }
    }
}
