using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    public Text score;

    private int puntos;

    void Update()
    {
        score.text = puntos.ToString();
    }

   void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomba")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Soles")
        {
            Destroy(target.gameObject);
            puntos++;
        }
    }

    IEnumerator WaitTilRestart()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
