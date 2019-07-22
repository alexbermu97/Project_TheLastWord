using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sangre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.hasMuestra == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
