using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDialogos : MonoBehaviour
{
    private Queue<string> frases;


    void Start()
    {
        frases = new Queue<string>();
    }

    public void EmpezarDialogo(Dialogos dialogos)
    {
        Debug.Log("Empezando conversacion con " + dialogos.nombre);

        frases.Clear();

        foreach(string frase in dialogos.frases)
        {
            frases.Enqueue(frase);
        }

        SiguienteFrase();
    }

    public void SiguienteFrase()
    {
        if (frases.Count == 0)
        {
            FinalDialogo();
            return;
        }

        string frase = frases.Dequeue();
        Debug.Log(frase);
    }

    public void FinalDialogo()
    {
        Debug.Log("Final de la conversacion");
    }
}
