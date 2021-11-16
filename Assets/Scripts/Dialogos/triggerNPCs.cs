using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerNPCs : MonoBehaviour
{
    public Dialogos dialogo;

    public GameObject gato1;
    public GameObject slimeAlcaldeFinal;

    public int indiceEscena;

    Vector2 distancia;

    private void Update()
    {
        distancia = gato1.GetComponent<Rigidbody2D>().position - slimeAlcaldeFinal.GetComponent<Rigidbody2D>().position;

        if (distancia.magnitude < 1 && Input.GetKeyDown(KeyCode.E)){
            TriggerDialogue();
            EmpezarJuegos.indiceEscena = indiceEscena;
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<AdministradorDialogos>().EmpezarDialogo(dialogo);
    }
}
