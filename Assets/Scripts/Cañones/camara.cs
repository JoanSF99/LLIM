using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Cañones inicial;
    Cañones ultimo;
    Transform target;
    public Vector3 offset;
    [Range(1,10)] public float smoothFactor = 3;

    void Start(){
        target = inicial.transform;
        transform.position = target.position;
    }

    void Update(){
        if (ultimo == null){
            ultimo = inicial;
        }
        else{
            ultimo = GameObject.FindWithTag("ultimo").GetComponent<Cañones>();
        }
        target = ultimo.transform;
        Follow();
    }

    public void Follow(){
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position,targetPosition,smoothFactor*Time.fixedDeltaTime);
        transform.position = smoothPosition;
    }
}
