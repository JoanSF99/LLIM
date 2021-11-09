using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CañonesEstaticos : MonoBehaviour
{

    public GameObject projectile;
    public GameObject parent;
    public bool cargado = false;

    // Update is called once per frame
    void Update()
    {
        //si pulsa espacio y tiene bala
        if (Input.GetButtonDown("Jump") && cargado) dispara();
    }

    void dispara(){
        GameObject bala = Instantiate(projectile, transform.position ,transform.rotation);
        cargado = false;
    }
}
