using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovC : MonoBehaviour
{
    //OBSOLETO
    //MOVIMIENTO PARA MANDO

    public Rigidbody rb;
    public float movSp;
    Vector2 movDir;
    

    void Start()
    {

        rb = GetComponent<Rigidbody>();

    }

    
    void Update()
    {
        float h = Input.GetAxis("HorizontalC");
        float v = Input.GetAxis("VerticalC");

        movDir = (h * transform.right + v * transform.up);
        rb.velocity = movDir * movSp * Time.deltaTime;
    }
}
