using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarJuegos : MonoBehaviour
{
    public static int indiceEscena = 0;

    public int indiceNivel;

   public void EmpezarJuego()
    {
        SceneManager.LoadScene(indiceEscena);
    }
}
