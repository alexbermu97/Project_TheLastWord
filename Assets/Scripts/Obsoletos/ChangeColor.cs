using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    //ESTE COÓDIGO SE TIENE QUE METER A LOS OBJETOS QUE VAYAN A CAMBIAR DE COLOR CON EL MODO DETECTIVE

    ModoDetective modoDetective;
    public GameObject on;
    public GameObject off;

    // Start is called before the first frame update
    void Start()
    {
        modoDetective = GameObject.Find("PlayerProto").GetComponent<ModoDetective>(); //CAMBIAR "PLAYERPROTO" A "PLAYER" CUANDO SE TENGAN ASSETS
    }

    // Update is called once per frame
    void Update()
    {
        
        if (modoDetective.detective)
        {
            on.SetActive(true);
            off.SetActive(false);
        }
        if (!modoDetective.detective)
        {
            on.SetActive(false);
            off.SetActive(true);
        }

    }
}
