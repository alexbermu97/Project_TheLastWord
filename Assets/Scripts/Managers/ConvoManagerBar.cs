using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvoManagerBar : MonoBehaviour
{

    public GameObject convoBM1;
    public GameObject convoBM2; //Cuando tienes la pistola
    public GameObject convoSC1;
    public GameObject convoSC2; //Cuando tienes las fotos
    /*public GameObject convoB1;
    public GameObject convoB2; //Cuando tienes las fotos*/

    void Start()
    {
    }
    
    void Update()
    {
       /* if (Inventory.hasFotos != 1)
        {
            convoSC2.SetActive(false);
            //convoB2.SetActive(false);
            convoSC1.SetActive(true);
            //convoB1.SetActive(true);
        }
        else if (Inventory.hasFotos == 1)
        {
            convoSC2.SetActive(true);
            //convoB2.SetActive(true);
            convoSC1.SetActive(false);
            //convoB1.SetActive(false);
        }

        if (Inventory.hasPipa != 1)
        {
            convoBM2.SetActive(false);
            convoBM1.SetActive(true);
        }
        else if (Inventory.hasPipa == 1)
        {
            convoBM2.SetActive(true);
            convoBM1.SetActive(false);
        }*/
    }
}
