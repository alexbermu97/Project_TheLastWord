using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public string primerNivel;
    public string settings;
    public GameObject fade;
    public float fadeTime = 10f;
    bool fadeOn;

    void Start()
    {
        fade.GetComponent<Image>().color = new Color(0, 0, 0, 0);
        fadeOn = false;

        PJsManager.zonaActual = "Menu";
    }

    // Update is called once per frame
    void Update()
    {
        if (!fadeOn)
        {
            fade.SetActive(false);
        }
        if (fadeOn)
        {
            FadeToBlack();
        }
    }

    public void Play()
    {
        StartCoroutine(WaitForFX());
    }
    public void Options()
    {
        StartCoroutine(WaitForFX2());
    }
    public void Quit()
    {
        Application.Quit();
    }

    void FadeToBlack()
    {
        fade.SetActive(true);
        fade.GetComponent<Image>().color = Color.Lerp(fade.GetComponent<Image>().color, Color.black, fadeTime * Time.deltaTime);
    }

    IEnumerator WaitForFX()
    {
        fadeOn = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(primerNivel);
    }
    IEnumerator WaitForFX2()
    {
        fadeOn = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(settings);
    }
}
