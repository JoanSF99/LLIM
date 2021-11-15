using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañones : MonoBehaviour
{
    public GameObject cañon;
    public GameObject projectile;
    public bool cargado = false;
    public float vel = 0.2f;
    public bool giratorio = false;
    public bool lineal = false;
    public float distancia = 10f;
    float distanciaR = 0f;   
    bool ida = true;
    public bool invertido;
    

    // Update is called once per frame
    void Update()
    {
        float velSlow = vel / 300f;
        
        //si pulsa espacio y tiene bala-----------------------------------------------
        if (Input.GetButtonDown("Jump") && cargado) dispara();

        //transformaciones------------------------------------------------------------
        
        //movimiento rotatorio ----------------------------
        if (giratorio && cargado){ 
            cañon.transform.Rotate(0f,0f,velSlow);
        }
        
        // movimiento lineal ------------------------------
        else if (lineal && cargado){
            if (!invertido){
                if (distanciaR >= distancia) {
                    ida=false;
                }
                else if (distanciaR <= 0) ida = true;

                if (ida){
                    cañon.transform.Translate(0f,velSlow ,0f);
                    distanciaR += velSlow;
                }
                else if (!ida){
                    cañon.transform.Translate(0f,-velSlow,0f);
                    distanciaR -= velSlow;
                }
            }
            else {
                if (distanciaR >= distancia) {
                    ida=false;
                }
                else if (distanciaR <= 0) ida = true;

                if (ida){
                    cañon.transform.Translate(0f,-velSlow ,0f);
                    distanciaR += velSlow;
                }
                else if (!ida){
                    cañon.transform.Translate(0f,velSlow,0f);
                    distanciaR -= velSlow;
                }
            }
        }
    }

    void dispara(){
        GameObject bala = Instantiate(projectile, transform.position ,transform.rotation);
        cargado = false;
    }

    public void destaggea (){
        tag = "Untagged";
    }
}
