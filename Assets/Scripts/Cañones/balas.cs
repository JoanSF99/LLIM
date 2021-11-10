using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balas : MonoBehaviour
{

    public float launchVelocity = 700f;
    public float flytime = 3f;
    Rigidbody2D rb;
    CañonesEstaticos ultimo_cañon;
    public GameObject cañonInicial;

    void Start(){
        rb = GetComponent<Rigidbody2D> ();
        rb.AddRelativeForce(new Vector3 (launchVelocity,0 ,0));
        cañonInicial = GameObject.Find("cañonEstaticoInicial/launch_origin");
        ultimo_cañon = cañonInicial.GetComponent<CañonesEstaticos>();
        Invoke("DestroyBullet",flytime);
    }

    void OnTriggerEnter2D(Collider2D otro){
        if (otro.gameObject.tag == "cañon" ){
            ultimo_cañon = otro.GetComponent<CañonesEstaticos>();
            DestroyBullet();
        }
    }

    void DestroyBullet(){
        ultimo_cañon.cargado = true;
        Destroy(gameObject);
    }
}
