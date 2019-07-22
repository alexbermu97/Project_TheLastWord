using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public float speed = 0.2f;
    private Vector3 movement_vector;

    public string x_input;
    public string y_input;

    private Vector2 viewPos;
    private Vector2 clampedWorldPos;

    void FixedUpdate()
    {
        movement_vector = new Vector2(Input.GetAxis(x_input), Input.GetAxis(y_input));

        if (Input.GetAxis(x_input) != 0 || Input.GetAxis(y_input) != 0)
        {
            transform.Translate(movement_vector * speed, Space.Self);
        }

        viewPos = Camera.main.WorldToViewportPoint(transform.position);
        clampedWorldPos = Camera.main.ViewportToWorldPoint(new Vector3(Mathf.Clamp01(viewPos.x), Mathf.Clamp01(viewPos.y), 0));
        transform.position = clampedWorldPos;
    }
}
