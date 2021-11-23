using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class balas : MonoBehaviour
{

    public float launchVelocity = 700f;
    public float flytime = 3f;
    Rigidbody2D rb;
    Cañones ultimo_cañon;


    void Start(){
        rb = GetComponent<Rigidbody2D> ();
        rb.AddRelativeForce(new Vector3 (launchVelocity,0 ,0));
        ultimo_cañon = GameObject.FindWithTag("ultimo").GetComponent<Cañones>();
        Invoke("DestroyBullet",flytime);
    }

    void OnTriggerEnter2D(Collider2D otro){
        if (otro.gameObject.tag == "meta"){
            DestroyBullet();
            SceneManager.LoadScene(0);
        }
        else{
            ultimo_cañon.destaggea();
            ultimo_cañon = otro.GetComponent<Cañones>();
            ultimo_cañon.tag = "ultimo";
            DestroyBullet();
        }
        
    }

    void DestroyBullet(){
        ultimo_cañon.cargado = true;
        Destroy(gameObject);
    }
}
