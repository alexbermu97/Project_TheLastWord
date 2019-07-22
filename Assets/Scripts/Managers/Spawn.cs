using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public GameObject player;
    public GameObject sceneController;
    public Transform spawnComisaria;
    public Transform spawnBar;
    public Transform spawnCallejon;

    public Image fade;
    public float fadeTime = 10f; //EL TIEMPO ÓPTIMO PARA EL FADE ES 10
    bool fadeOn;

    void Awake()
    {
        fadeOn = true;
        fade.color = new Color(0, 0, 0, 1);
    }

    void Start()
    {
        sceneController = GameObject.Find("SceneController");
        player = GameObject.Find("PlayerProto");

        if(sceneController.GetComponent<SceneController>().lastScene == 1) //VIENE DE LA COMISARÍA
        {
            player.transform.position = spawnComisaria.position;
        }
        if (sceneController.GetComponent<SceneController>().lastScene == 2) //VIENE DEL BAR
        {
            player.transform.position = spawnBar.position;
        }
        if (sceneController.GetComponent<SceneController>().lastScene == 3) //VIENE DEL CALLEJÓN
        {
            player.transform.position = spawnCallejon.position;
        }
    }
    
    void Update()
    {
        if (fadeOn)
        {
            StartCoroutine(PlsRename());
        }
    }

    IEnumerator PlsRename() //NO SE ME OCURRE UN NOMBRE PARA ESTE MÉTODO
    {
        FadeFromBlack();
        yield return new WaitForSeconds(2f);
        fadeOn = false;
    }

    void FadeFromBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.clear, fadeTime * Time.deltaTime);
    }
}
