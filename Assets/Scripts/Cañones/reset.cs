using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Espacio: Disparar, LeftAlt: Reset");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Debug Reset")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
