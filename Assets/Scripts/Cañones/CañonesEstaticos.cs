using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonesEstaticos : MonoBehaviour
{

    public GameObject projectile;

    public bool cargado = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //detectar colision 
        //if ()
        //disparo
        
        //si pulsa espacio y tiene bala
        if (Input.GetButtonDown("Jump") && cargado) dispara();
    }

    void dispara(){
        GameObject bala = Instantiate(projectile, transform.position ,transform.rotation);
        cargado = false;
    }
}
