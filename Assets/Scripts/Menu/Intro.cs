using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    public string primerNivel;
    public Image fade;
    public float fadeTime;
    bool fadeOn;
    public float read;
    int cont;

    void Start()
    {
        fade.color = new Color(0, 0, 0, 0);
        fadeOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        cont++;
        if (cont >= 1 && cont <= 20)
        {
            StartCoroutine(WaitForFX());
        }
        if (fadeOn)
        {
            FadeToBlack();
        }
    }

    void FadeToBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.black, fadeTime * Time.deltaTime);
    }

    IEnumerator WaitForFX()
    {
        yield return new WaitForSeconds(read);
        fadeOn = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(primerNivel);
    }

    /*IEnumerator WaitOnMe()
    {
        yield return new WaitForSeconds(read);

        StartCoroutine(WaitForFX());
    }*/

}
