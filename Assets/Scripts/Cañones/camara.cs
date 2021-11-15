using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Cañones inicial;
    Cañones ultimo;
    public Transform target;
    public Vector3 offset;

    [Range(1,10)] public float smoothFactor = 3;

    void Start(){
        inicial = GameObject.Find("cañonInicial").GetComponent<Cañones>();
        Debug.Log(inicial);
    }

    void Update(){
        if (ultimo == null){
            ultimo = inicial; 
            //Debug.Log(ultimo);
        }
        else{
            ultimo = GameObject.FindWithTag("ultimo").GetComponent<Cañones>();
        }  

        //target = ultimo.transform;
        Follow();
    }

    public void Follow(){

/*         Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,targetPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = targetPosition; */
    
    }
}
