using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLupa : MonoBehaviour
{

    public float sp;
    Vector2 movDir;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.mousePosition.x;
        float v = Input.mousePosition.y;

        movDir = (h * transform.right + v * transform.up);
        //rb.velocity = movDir * sp * Time.deltaTime;
        transform.position = new Vector3(h * transform.position.x * sp * Time.deltaTime, v * transform.position.y * sp * Time.deltaTime, transform.position.z);
    }
}
