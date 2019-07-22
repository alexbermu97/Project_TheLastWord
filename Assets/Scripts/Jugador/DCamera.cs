using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class DCamera : MonoBehaviour
{


    // Update is called once per frame
    /*void Update()
    {
        transform.position = new Vector3((Input.mousePosition.x)*0.1f, (Input.mousePosition.y)*0.1f, transform.position.z);
    }*/
    public Camera[] cams;
    private Vector2 mousePosition;
    public float moveSpeed = 0.1f;
    Scene scene;
    public GameObject controllerChecker;

    // Use this for initialization
    void Start()
    {
        controllerChecker = GameObject.Find("ControllerChecker");
    }

    // Update is called once per frame
    void Update()
    {
        if (!controllerChecker.GetComponent<CheckForController>().mandoConectado)
        {
            scene = SceneManager.GetActiveScene();
            if (scene.name == "Callejón-1")
            {
                if (cams[0].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[0].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
            }
            else if (scene.name == "Bar-1" || scene.name == "Comisaría-1")
            {
                if (cams[0].isActiveAndEnabled && !cams[2].isActiveAndEnabled && !cams[3].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[0].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
                if (cams[2].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[2].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
                if (cams[3].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[3].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
            }
        }
        if (controllerChecker.GetComponent<CheckForController>().mandoConectado)
        {
            scene = SceneManager.GetActiveScene();
            if (scene.name == "Callejón-1")
            {
                if (cams[0].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[0].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
            }
            else if (scene.name == "Bar-1" || scene.name == "Comisaría-1")
            {
                if (cams[0].isActiveAndEnabled && !cams[2].isActiveAndEnabled && !cams[3].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[0].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
                if (cams[2].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[2].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
                if (cams[3].isActiveAndEnabled)
                {
                    mousePosition = Input.mousePosition;
                    mousePosition = cams[3].ScreenToWorldPoint(mousePosition);
                    transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
                    transform.position = new Vector3(transform.position.x, transform.position.y, -4);
                    UnityEngine.Cursor.lockState = CursorLockMode.Confined;
                }
            }
        }
    }
}
