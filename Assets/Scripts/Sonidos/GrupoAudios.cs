using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrupoAudios : MonoBehaviour
{
    public AudioSource _as;

    public AudioClip[] audioClipArray;

    public float wait;
    public float max;
    public float min;

    private void Awake()
    {
        _as = GetComponent<AudioSource>();
    }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sonar());
    }

    IEnumerator Sonar()
    {
        wait = Random.Range(min, max);
        yield return new WaitForSeconds(wait);
        _as.clip = audioClipArray[Random.Range(0, audioClipArray.Length)];
        _as.PlayOneShot(_as.clip);
        StartCoroutine(Sonar());

    }


}
