using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSarge : MonoBehaviour
{

    public GameObject sarge2;
    public GameObject sarge3;

    // Start is called before the first frame update
    void Start()
    {
        if (PJsManager.sargeconv2 == 0)
        {
            sarge2.SetActive(true);
            sarge3.SetActive(false);
        }
        if (PJsManager.sargeconv2 == 1)
        {
            sarge2.SetActive(false);
            sarge3.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
