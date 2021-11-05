using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdministradorDialogos : MonoBehaviour
{

    public Text nombreTexto;
    public Text textoDialogo;

    private Queue<string> frases;


    public Animator animator;


    void Start()
    {
        frases = new Queue<string>();
    }

    public void EmpezarDialogo(Dialogos dialogos)
    {

        animator.SetBool("IsOpen", true);
        
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
        StopAllCoroutines();
        StartCoroutine(escribeFrase(frase));
    }

    IEnumerator escribeFrase(string frase)
    {
        textoDialogo.text = "";
        foreach(char letra in frase.ToCharArray())
        {
            textoDialogo.text += letra;
            yield return null;
        }
    }

    public void FinalDialogo()
    {
        animator.SetBool("IsOpen", false);
    }
}
