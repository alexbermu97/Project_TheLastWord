using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forget : MonoBehaviour
{

    public GameObject inv;
    public GameObject sceneController;

    // Start is called before the first frame update
    void Start()
    {
        inv = GameObject.Find("Inventory");
        sceneController = GameObject.Find("SceneController");

        Destroy(inv);
        Destroy(sceneController);

        Inventory.hasProbeta = 0;
        Inventory.hasBolsa = 0;
        Inventory.hasPalanca = 0;
        Inventory.hasMuestra = 0;
        Inventory.hasLadrillo = 0;
        Inventory.hasCoca = 0;
        Inventory.hasCartel = 0;
        Inventory.hasFotos = 0;
        Inventory.hasX = 0;
        Inventory.hasLlave = 0;
        Inventory.hasPipa = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
