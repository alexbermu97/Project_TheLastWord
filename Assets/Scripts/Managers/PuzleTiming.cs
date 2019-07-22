using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzleTiming : MonoBehaviour
{

    public GameObject barManAtento;
    public GameObject barManDistraido;

    public bool distraido;

    public float margen;

    public bool lamparaRota;


    // Start is called before the first frame update
    void Start()
    {
        distraido = false;
        barManAtento.SetActive(true);
        barManDistraido.SetActive(false);
        lamparaRota = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lamparaRota)
        {
            StartCoroutine(Puzle());
        }
    }

    IEnumerator Puzle()
    {
        distraido = true;
        barManAtento.SetActive(false);
        barManDistraido.SetActive(true);

        yield return new WaitForSeconds(margen);

        distraido = false;
        barManAtento.SetActive(true);
        barManDistraido.SetActive(false);
        lamparaRota = false;
    }
}
