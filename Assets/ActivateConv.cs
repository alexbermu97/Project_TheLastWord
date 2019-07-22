using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateConv : MonoBehaviour
{

    //SI HAY MENOS DIÁLOGOS QUE HUECOS, RELLENAR LOS QUE SOBRAN CON CUALQUIER COSA. NUNCA SE VA A MOSTRAR.

    public GameObject inkcanv1;
    public GameObject inkcanv2;
    public GameObject inkcanv3;
    public GameObject inkcanv4;
    public GameObject player;
    public string character;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerProto");
        inkcanv1.SetActive(false);
        inkcanv2.SetActive(false);
        inkcanv3.SetActive(false);
        inkcanv4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player.gameObject)
        {
            if (character == "LU")
            {
                if (Inventory.hasFotos != 1 && PJsManager.sargeconv2 == 0)
                {
                    inkcanv1.SetActive(true);
                }
                if (Inventory.hasFotos != 1 && PJsManager.sargeconv2 == 1)
                {
                    inkcanv2.SetActive(true);
                }
                if (Inventory.hasFotos == 1)
                {
                    inkcanv3.SetActive(true);
                }
            }
            if (character == "BM")
            {
                if (Inventory.hasPipa != 1)
                {
                    inkcanv1.SetActive(true);
                }
                if (Inventory.hasPipa == 1)
                {
                    inkcanv2.SetActive(true);
                }
            }
            if (character == "B")
            {
                if (Inventory.hasFotos != 1 && Inventory.hasLlave != 1 && PJsManager.sargeconv2 == 0)
                {
                    inkcanv1.SetActive(true);
                }
                if (Inventory.hasFotos != 1 && Inventory.hasLlave != 1 && PJsManager.sargeconv2 == 1)
                {
                    inkcanv2.SetActive(true);
                }
                if (Inventory.hasFotos == 1 && Inventory.hasLlave != 1)
                {
                    inkcanv3.SetActive(true);
                    inkcanv4.SetActive(false);
                }
                if (Inventory.hasFotos == 1 && Inventory.hasLlave == 1)
                {
                    inkcanv3.SetActive(false);
                    inkcanv4.SetActive(true);
                }
            }
            if (character == "SZ")
            {
                inkcanv1.SetActive(true);
                /*inkcanv2.SetActive(false);
                inkcanv3.SetActive(false);
                inkcanv4.SetActive(false);*/
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inkcanv1.SetActive(false);
        inkcanv2.SetActive(false);
        inkcanv3.SetActive(false);
        inkcanv4.SetActive(false);

        InkManager.cont = 0;
    }
}
