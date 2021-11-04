using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdministradorDialogos : MonoBehaviour
{

    public Text nombreTexto;
    public Text textoDialogo;

    private Queue<string> frases;


    void Start()
    {
        frases = new Queue<string>();
    }

    public void EmpezarDialogo(Dialogos dialogos)
    {

        nombreTexto.text = dialogos.nombre;

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
        textoDialogo.text = frase;
    }

    public void FinalDialogo()
    {
        Debug.Log("Final de la conversacion");
    }
}
