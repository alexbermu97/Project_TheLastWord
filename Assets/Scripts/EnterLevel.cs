using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterLevel : MonoBehaviour
{
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
