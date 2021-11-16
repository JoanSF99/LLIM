using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptColector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Soles" || collision.tag == "Bomba")
            Destroy(collision.gameObject);
    }


}
