using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class probeta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.hasProbeta == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
