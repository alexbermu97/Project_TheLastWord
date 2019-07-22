using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrillo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.hasLadrillo == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
