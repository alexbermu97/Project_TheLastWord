using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{

    public string menu;
    public string settings;

    public GameObject pausa;

    public bool pausado;

    void Start()
    {
        pausa.SetActive(false);
        pausado = false;
    }

    void Update()
    {
        Time.fixedDeltaTime = 0.02f * Time.timeScale;

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape) && !pausado)
        {
            Pausa();
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0;
        pausa.SetActive(true);
        pausado = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausa.SetActive(false);
        pausado = false;
    }

    public void Menu()
    {
        SceneManager.LoadScene(menu);
    }

    public void Settings()
    {
        SceneManager.LoadScene(settings);
    }

}
