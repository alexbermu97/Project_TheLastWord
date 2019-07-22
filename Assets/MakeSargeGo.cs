using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSargeGo : MonoBehaviour
{

    public GameObject sarge;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        sarge = GameObject.Find("Sargento");
        player = GameObject.Find("PlayerProto");
        if (PJsManager.sargeconv1 == 0)
        {
            sarge.SetActive(true);
        }
        else if (PJsManager.sargeconv1 == 1)
        {
            sarge.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D coli)
    {
        if (coli.gameObject == player.gameObject)
        {
            sarge.SetActive(false);
            PJsManager.sargeconv1 = 1;
        }
    }
}
