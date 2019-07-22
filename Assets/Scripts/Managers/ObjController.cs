using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjController : MonoBehaviour
{

    public GameObject fotos;
    public GameObject cartel;
    public GameObject coca;

    // Start is called before the first frame update
    void Start()
    {
        if (Inventory.hasCoca != 1)
        {
            fotos.SetActive(false);
            cartel.SetActive(false);
        }
        else if (Inventory.hasCoca == 1)
        {
            fotos.SetActive(true);
            cartel.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Inventory.hasLadrillo != 1)
        {
            coca.SetActive(false);
        }
        else if (Inventory.hasLadrillo == 1)
        {
            coca.SetActive(true);
        }
        if (Inventory.hasCoca == 1)
        {
            coca.SetActive(false);
        }
    }
}
