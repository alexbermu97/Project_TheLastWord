using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPjsManager : MonoBehaviour
{
    public GameObject sarge;
    public GameObject barCol;
    public GameObject callejCol;
    public GameObject comisCol;
    // Start is called before the first frame update
    void Start()
    {
        sarge = GameObject.Find("Sargento");
    }

    // Update is called once per frame
    void Update()
    {
        if (PJsManager.sargeconv1 == 0)
        {
            sarge.SetActive(true);
        }
        else if (PJsManager.sargeconv1 == 1)
        {
            sarge.SetActive(false);
        }
    }
}
