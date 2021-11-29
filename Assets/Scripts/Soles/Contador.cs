using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    public int health, numOfHearts;

    public Image[] hearts;
    public Sprite fullHeart, emptyHeart;

    public Text score;

    private int puntos;

    void Update()
    {
        score.text = puntos.ToString();

        for (int i = 0; i < hearts.Length; i++)
        {
            if (health > numOfHearts)
            {
                health = numOfHearts;
            }
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }

        if (health == 0)
        {
            SceneManager.LoadScene("MJ soles");
        }
        if (puntos >= 10)
        {
            SceneManager.LoadScene("Llim");
        }
    }

   void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomba")
        {
            Destroy(target.gameObject);
            health--;
        }
        if (target.tag == "Soles")
        {
            Destroy(target.gameObject);
            puntos++;
        }
        if (target.tag == "Soles2")
        {
            Destroy(target.gameObject);
            puntos=puntos+2;
        }
    }


    IEnumerator WaitTilRestart()
    {
        yield return new WaitForSeconds(1.5f);
    }

}
