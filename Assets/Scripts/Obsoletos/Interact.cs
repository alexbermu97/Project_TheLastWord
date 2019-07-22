using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    //ESTE CÓDIGO SIRVE PARA TODO AQUELLO CON LO QUE EL JUGADOR PUEDE INTERACTUAR
    //ESTE CÓDIGO SE INTRODUCE EN OBJECTOS CON LOS QUE SE PUEDE INTERACTUAR
    public string objName;
    public GameObject player;
    public bool inTrigger;
    public string conver;
    //public Text text;
    public float textOnScreenTime;

    GameObject invHUD;
    
    void Start()
    {

        player = GameObject.Find("PlayerProto");
        inTrigger = false;
        //text.enabled = false;

        invHUD = GameObject.Find("Inventory");

    }
    
    void Update()
    {
        //SE REQUIERE QUE EL OBJETO QUE POSEE ESTE CÓDIGO TENGA UN TRIGGER
        if (!inTrigger)
        {
            if (Input.GetButtonDown("Submit"))
            {
                print("Nothing");
            }
        }
        if (inTrigger)
        {
            if (Input.GetButtonDown("Submit"))
            {
                if (objName == "PJPruebas")
                {
                    //text.text = conver;
                    //text.enabled = true;
                    print(conver);
                    StartCoroutine(TurnOffText());
                }
                if (objName == "PJPruebas1")
                {
                    //text.text = conver;
                    //text.enabled = true;
                    print(conver);
                    StartCoroutine(TurnOffText());
                }
            }
        }
    }

    void OnTriggerEnter(Collider coli)
    {
        if (coli.gameObject == player.gameObject)
        {
            print("Is In");
            inTrigger = true;
        }
    }

    void OnTriggerExit(Collider coli)
    {
        print("Is Out");
        inTrigger = false;
        //text.enabled = false;
    }

    IEnumerator TurnOffText()
    {
        yield return new WaitForSeconds(textOnScreenTime);
        //text.enabled = false;
    }
}
