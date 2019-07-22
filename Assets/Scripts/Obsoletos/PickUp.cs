using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    //CREAR LISTA DE TODOS LOS GAMEOBJECTS ¿EN ESCENA?¿EN EL JUEGO?
    //LOS OBJETOS RECOGIDOS NO SON ELIMINADOS, SON DESACTIVADOS
    //LOS OBJETOS DESACTIVADOS NO VUELVEN A ACTIVARSE EN VERSIÓN FINAL
    public GameObject[] objs;
    public bool[] inTrigger;
    
    void Start()
    {

        //ELIMINAR ESTO EN VERSIÓN FINAL
        /*PlayerPrefs.SetInt("Obj1Picked", 0);
        Blackboard.obj1_picked = PlayerPrefs.GetInt("Obj1Picked");
        PlayerPrefs.SetInt("Obj2Picked", 0);
        Blackboard.obj2_picked = PlayerPrefs.GetInt("Obj2Picked");*/
        ////////////////////////////////

        if (PlayerPrefs.GetInt("Obj1Picked") == 0)
        {
            objs[0].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Obj1Picked") == 1)
        {
            objs[0].SetActive(false);
        }
        if (PlayerPrefs.GetInt("Obj2Picked") == 0)
        {
            objs[1].SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Obj2Picked") == 1)
        {
            objs[1].SetActive(false);
        }
    }
    
    void Update()
    {
        if (!inTrigger[0] && !inTrigger[1])
        {
            if (Input.GetButtonDown("SubmitC") || Input.GetButtonDown("Interact"))
            {
                print("nothinghappens");
            }
        }

        if (inTrigger[0])
        {
            if (Input.GetButtonDown("SubmitC") || Input.GetButtonDown("Interact"))
            {
                PlayerPrefs.SetInt("Obj1Picked", 1);
                Blackboard.obj1_picked = PlayerPrefs.GetInt("Obj1Picked");

                objs[0].SetActive(false);

                print("pickedup1");
            }
        }
        if (inTrigger[1])
        {
            if (Input.GetButtonDown("SubmitC") || Input.GetButtonDown("Interact"))
            {
                PlayerPrefs.SetInt("Obj2Picked", 1);
                Blackboard.obj2_picked = PlayerPrefs.GetInt("Obj2Picked");

                objs[1].SetActive(false);

                print("pickedup2");
            }
        }
    }

    void OnTriggerEnter(Collider whup)
    {
        if (whup.gameObject == objs[0])
        {
            print ("intrigger1");
            inTrigger[0] = true;
        }
        if (whup.gameObject == objs[1])
        {
            print("intrigger2");
            inTrigger[1] = true;
        }
    }
    void OnTriggerExit(Collider whup)
    {
        inTrigger[0] = false;
        inTrigger[1] = false;
    }
}
