using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolsa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.hasBolsa == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
