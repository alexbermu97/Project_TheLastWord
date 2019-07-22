using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovT : MonoBehaviour
{
    //OBSOLETO
    //MOVIMIETNO PARA TECLADO

    public Rigidbody rb;
    public float movSp;
    Vector2 movDir;
    

    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        movDir = (h * transform.right + v * transform.up);
        rb.velocity = movDir * movSp * Time.deltaTime;
    }
}
