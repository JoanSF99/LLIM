using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuPausa : MonoBehaviour
{

    public GameObject imagen;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1.0f)
            {
                imagen.SetActive(true);
                Time.timeScale = 0.0f;

            }else if (Time.timeScale == 0.0f)
            {
                imagen.SetActive(false);
                Time.timeScale = 1.0f;
            }
        } 
    }
}
