using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModoDetective : MonoBehaviour
{
    //SE METE EN EL JUGADOR

    public GameObject cameraD;
    public GameObject cameraD2;
    public GameObject lupa;
    public bool detective;

    public GameObject controllerChecker;

    
    void Start()
    {
        detective = false;
        cameraD = GameObject.Find("DetectiveCam");
        cameraD.SetActive(false);
        cameraD2 = GameObject.Find("DetectiveCam2");
        cameraD2.SetActive(false);
        lupa = GameObject.Find("Lupa");
        lupa.SetActive(false);

        controllerChecker = GameObject.Find("ControllerChecker");
    }
    
    void Update()
    {
        if (!controllerChecker.GetComponent<CheckForController>().mandoConectado) //Si el mando no está conectado
        { 
            if (Input.GetKeyDown(KeyCode.Space) && !detective)
            {
                cameraD.SetActive(true);
                cameraD2.SetActive(true);
                lupa.SetActive(true);
                detective = true;
                UnityEngine.Cursor.visible = false;
            }
            else if (Input.GetKeyDown(KeyCode.Space) && detective)
            {
                cameraD.SetActive(false);
                cameraD2.SetActive(false);
                lupa.SetActive(false);
                detective = false;
                UnityEngine.Cursor.visible = true;
            }
        }

        if (controllerChecker.GetComponent<CheckForController>().mandoConectado) //Si el mando está conectado
        {
            if (Input.GetButtonDown("JumpC") && !detective)
            {
                cameraD.SetActive(true);
                cameraD2.SetActive(true);
                lupa.SetActive(true);
                detective = true;
                UnityEngine.Cursor.visible = false;
            }
            else if (Input.GetButtonDown("JumpC") && detective)
            {
                cameraD.SetActive(false);
                cameraD2.SetActive(false);
                lupa.SetActive(false);
                detective = false;
                UnityEngine.Cursor.visible = true;
            }
        }
    }
}
