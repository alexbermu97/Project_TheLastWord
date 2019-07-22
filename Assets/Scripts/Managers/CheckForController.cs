using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForController : MonoBehaviour
{
    //ESTE CÓDIGO BUSCA SI HAY UN MANDO CONECTADO

    public static CheckForController check;
    public bool mandoConectado;
    public float cont;
    
    void Awake()
    {
        if (check == null)
        {
            DontDestroyOnLoad(gameObject);
            check = this;
        }
        else if (check != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        mandoConectado = false;
        cont = 0;
    }
    
    void Update()
    {
        cont += Time.deltaTime;
        if (cont >= 1)
        {
            //StartCoroutine("TwoSeconds");
            TwoSeconds();
            cont = 0;
        }
    }

    void TwoSeconds()
    {

        string[] joy = Input.GetJoystickNames();

        if (joy.Length > 0)
        {
            for (int i = 0; i < joy.Length; i++)
            {
                if (!string.IsNullOrEmpty(joy[i]))
                {
                    print("Mando " + i + " conectado usando: " + joy[i]);
                    mandoConectado = true;
                }
                else
                {
                    print("Mando " + i + " desconectado");
                    mandoConectado = false;
                }
            }
        }
    }

    /*IEnumerator TwoSeconds()
    {
        yield return new WaitForSeconds(0.05f);

        string[] joy = Input.GetJoystickNames();

        if (joy.Length > 0)
        {
            for (int i = 0; i < joy.Length; i++)
            {
                if (!string.IsNullOrEmpty(joy[i]))
                {
                    print("Mando " + i + " conectado usando: " + joy[i]);
                    mandoConectado = true;
                }
                else
                {
                    print("Mando " + i + " desconectado");
                    mandoConectado = false;
                }
            }
        }

    }*/
}
