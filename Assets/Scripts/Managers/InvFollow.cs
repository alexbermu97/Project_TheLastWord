using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvFollow : MonoBehaviour
{

    public GameObject invHUD;

    void Start()
    {
        invHUD = GameObject.Find("Inventory");
    }

    // Update is called once per frame
    void Update()
    {
        invHUD.transform.position = new Vector3(gameObject.transform.position.x, invHUD.transform.position.y, -1.5f);
    }
}
