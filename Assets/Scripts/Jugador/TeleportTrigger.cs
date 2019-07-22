using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportTrigger : MonoBehaviour
{
    //SIRVE PARA TELETRANSPORTAR AL JUGADOR A UNA POSICIÓN DENTRO DE UNA ESCENA

    public Transform posCorresp;
    public GameObject player;
    public GameObject camAnterior;
    public GameObject camActual;

    public GameObject detcam;
    public GameObject invHud;

    //ES NECESARIO TENER UNA IMAGEN FADE Y ARRASTRARLA AQUÍ
    public Image fade;
    public float fadeTime = 10f; //EL TIEMPO ÓPTIMO PARA EL FADE ES 10
    bool fadeOn;

    void Start()
    {
        player = GameObject.Find("PlayerProto");
        invHud = GameObject.Find("Inventory");
        camActual.SetActive(false);
        fade.color = new Color(0, 0, 0, 0); //HACE QUE EL COLOR SEA NEGRO Y EL ALFA 0, NO SÉ SI ES ÚTIL
        invHud.transform.position = new Vector3(camActual.transform.position.x, camActual.transform.position.y - 12, -1.5f);
    }
    
    void Update()
    {
        if (fadeOn)
        {
            FadeToBlack();
            StartCoroutine(PlsRename());
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player.gameObject)
        {
            StartCoroutine(WaitForFade());
        }
    }

    IEnumerator WaitForFade()
    {
        fadeOn = true;

        yield return new WaitForSeconds(2f);
        
        camActual.SetActive(true);
        camAnterior.SetActive(false);
        player.transform.position = new Vector3(posCorresp.position.x, posCorresp.position.y, -0.15f);
        detcam.transform.position = camActual.transform.position;
        invHud.transform.position = new Vector3(camActual.transform.position.x, camActual.transform.position.y - 12, -1.5f);
    }

    IEnumerator PlsRename() //NO SE ME OCURRE UN NOMBRE PARA ESTE MÉTODO
    {
        yield return new WaitForSeconds(2f);
        fadeOn = false;
        FadeFromBlack();
    }

    void FadeToBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.black, fadeTime * Time.deltaTime);
    }
    void FadeFromBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.clear, fadeTime * Time.deltaTime);
    }
}
