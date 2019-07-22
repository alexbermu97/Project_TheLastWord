using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonesController : MonoBehaviour
{

    public GameObject barCol;
    public GameObject callejCol;
    public GameObject comisCol;

    void Start()
    {
        barCol.SetActive(false);
        callejCol.SetActive(false);
        comisCol.SetActive(false);
    }
    
    void Update()
    {
        if (PJsManager.barCol == 1)
        {
            barCol.SetActive(true);
        }
        else if (PJsManager.barCol == 0)
        {
            barCol.SetActive(false);
        }

        if (PJsManager.comisCol == 1)
        {
            comisCol.SetActive(true);
        }
        else if (PJsManager.comisCol == 0)
        {
            comisCol.SetActive(false);
        }

        if (PJsManager.callejCol == 1)
        {
            callejCol.SetActive(true);
        }
        else if (PJsManager.callejCol == 0)
        {
            callejCol.SetActive(false);
        }
    }
}
