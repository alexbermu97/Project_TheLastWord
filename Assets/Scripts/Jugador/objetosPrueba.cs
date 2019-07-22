using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetosPrueba : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<probeta>() != null)
        {
            Debug.Log("colision con probeta");
            if (Input.GetButtonDown("Submit"))
            {
                Debug.Log("probeta recogida");
                InventoryHud.boolProbeta = true;
            }
        }
        if (collision.gameObject.GetComponent<sangre>() != null)
        {
            Debug.Log("colision con sangre");
            if (Input.GetButtonDown("Submit") && InventoryHud.probetaRecogida)
            {
                Debug.Log("sangre recogida");
                InventoryHud.boolProbetaSangre = true;
            }
        }
        if (collision.gameObject.GetComponent<palanca>() != null)
        {
            Debug.Log("colision con palanca");
            if (Input.GetButtonDown("Submit"))
            {
                Debug.Log("palanca recogida");
                InventoryHud.boolPalanca = true;
            }
        }
        if (collision.gameObject.GetComponent<ladrillo>() != null)
        {
            if (Input.GetButtonDown("Submit"))
            {
                InventoryHud.boolLadrillo = true;
            }
        }
        if (collision.gameObject.GetComponent<bolsa>() != null)
        {
            if (Input.GetButtonDown("Submit"))
            {
                InventoryHud.boolBolsa = true;
            }
        }
        if (collision.gameObject.GetComponent<coca>() != null)
        {
            if (Input.GetButtonDown("Submit") && InventoryHud.bolsaRecogida && InventoryHud.palancaRecogida)
            {
                InventoryHud.boolBolsaCoca = true;
            }
        }
        if (collision.gameObject.GetComponent<cartel>() != null)
        {
            if (Input.GetButtonDown("Submit"))
            {
                InventoryHud.boolCartel = true;
            }
        }
        if (collision.gameObject.GetComponent<fotos>() != null)
        {
            if (Input.GetButtonDown("Submit"))
            {
                InventoryHud.boolFotos = true;
            }
        }
        if (collision.gameObject.GetComponent<equis>() != null)
        {
            if (Input.GetButtonDown("Submit"))
            {
                InventoryHud.boolEquis = true;
            }
        }
        if (collision.gameObject.GetComponent<llave>() != null)
        {
            if (Input.GetButtonDown("Submit") && InventoryHud.cartelRecogida && InventoryHud.fotosRecogida && InventoryHud.equisRecogida)
            {
                InventoryHud.boolLlave = true;
            }
        }
        if (collision.gameObject.GetComponent<pistola>() != null)
        {
            if (Input.GetButtonDown("Submit") && InventoryHud.llaveRecogida)
            {
                InventoryHud.boolPistola = true;
            }
        }
    }
}
