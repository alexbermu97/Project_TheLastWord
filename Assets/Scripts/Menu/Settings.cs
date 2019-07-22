using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public AudioMixer master;
    public AudioMixer music;
    public AudioMixer effects;

    public string menu;
    public Image fade;
    public float fadeTime = 10f;

    void Start()
    {
        fade.color = new Color(0, 0, 0, 0);
        
    }

    void Update()
    {
        //menu = PJsManager.zonaActual;
    }


    public void SetVolumeMaster (float volume)
    {
        master.SetFloat("Master", volume);
    }
    public void SetVolumeMusic (float volume)
    {
        music.SetFloat("Music", volume);
    }
    public void SetVolumeEffects (float volume)
    {
        effects.SetFloat("Effects", volume);
    }

    public void Back()
    {
        StartCoroutine(Volver());
    }

    IEnumerator Volver()
    {
        FadeToBlack();
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(menu);
    }

    void FadeToBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.black, fadeTime * Time.deltaTime);
    }
}
