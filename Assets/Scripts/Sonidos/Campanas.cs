using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campanas : MonoBehaviour
{
    AudioSource audioData;
    public float wait;
    public float max;
    public float min;
    
    
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        StartCoroutine(Sonar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Sonar()
    {
        wait = Random.Range(min, max);
        yield return new WaitForSeconds(wait);
        audioData.Play();
        StartCoroutine(Sonar());
    }
}
