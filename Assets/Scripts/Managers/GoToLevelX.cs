using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoToLevelX : MonoBehaviour
{
    public GameObject player;
    public string levelName;
    public Image fade;
    public float fadeTime = 10f; //EL TIEMPO ÓPTIMO PARA EL FADE ES 10
    bool fadeOn;

    void Start()
    {
        player = GameObject.Find("PlayerProto");
    }

    void Update()
    {
        if (fadeOn)
        {
            FadeToBlack();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player.gameObject)
        {
            StartCoroutine(WaitForFade());
        }
    }

    void FadeToBlack()
    {
        fade.color = Color.Lerp(fade.color, Color.black, fadeTime * Time.deltaTime);
    }

    IEnumerator WaitForFade()
    {
        fadeOn = true;

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(levelName);
    }
}
