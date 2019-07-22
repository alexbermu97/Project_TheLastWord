using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovCompleto : MonoBehaviour
{
    //METER EN EL JUGADOR
    //CONTROLA TODO EL MOVIMIENTO DEL JUGADOR

    public Rigidbody2D rb;
    public Animator anim;
    public bool lookright;
    public bool lookleft;
    public float movSp;
    Vector2 movDir;

    public Scene current;

    ModoDetective modoDetective;

    public GameObject invHud;

    public GameObject controllerChecker;


    void Start()
    {

        controllerChecker = GameObject.Find("ControllerChecker");
        invHud = GameObject.Find("Inventory");
        modoDetective = GetComponent<ModoDetective>();
        rb = GetComponent<Rigidbody2D>();

    }


    void Update()
    {

        anim.SetBool("LookingRight", lookright);
        anim.SetBool("LookingLeft", lookleft);

        PJsManager.zonaActual = current.name;
        current = SceneManager.GetActiveScene();
        print(current.name);

        if (!controllerChecker.GetComponent<CheckForController>().mandoConectado) //Si el mando no está conectado
        {
            if (!modoDetective.detective || !invHud.GetComponent<InventoryHud>().activated)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");

                if (h > 0.1f)
                {
                    anim.SetBool("GoRight", true);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", false);
                    lookright = true;
                    lookleft = false;
                }
                else if (h < -0.1f)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", true);
                    anim.SetBool("Stand", false);
                    lookright = false;
                    lookleft = true;
                }
                else if (h > -0.1f && h < 0.1f)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", true);
                }

                if (v > 0.1f && lookright)
                {
                    anim.SetBool("GoRight", true);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", false);
                }
                if (v > 0.1f && lookleft)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", true);
                    anim.SetBool("Stand", false);
                }
                if (v < -0.1f && lookright)
                {
                    anim.SetBool("GoRight", true);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", false);
                }
                if (v < -0.1f && lookleft)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", true);
                    anim.SetBool("Stand", false);
                }

                movDir = (h * transform.right + v * transform.up);
                rb.velocity = movDir * movSp * Time.deltaTime;
                //rb.velocity = new Vector2(rb.velocity.x * movSp * Time.deltaTime, rb.velocity.y * movSp * Time.deltaTime);
            }
            if (modoDetective.detective || invHud.GetComponent<InventoryHud>().activated)
            {
                rb.velocity = new Vector2(0, 0);
            }

            /*if (!invHud.GetComponent<InventoryHud>().activated)
            {
                float h = Input.GetAxis("Horizontal");
                float v = Input.GetAxis("Vertical");

                if (h > 0.1f)
                {
                    anim.SetBool("GoRight", true);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", false);
                    lookright = true;
                    lookleft = false;
                }
                else if (h < -0.1f)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", true);
                    anim.SetBool("Stand", false);
                    lookright = false;
                    lookleft = true;
                }
                else if (h > -0.1f && h < 0.1f)
                {
                    anim.SetBool("GoRight", false);
                    anim.SetBool("GoLeft", false);
                    anim.SetBool("Stand", true);
                }

                movDir = (h * transform.right + v * transform.up);
                rb.velocity = movDir * movSp * Time.deltaTime;
                //rb.velocity = new Vector2(rb.velocity.x * movSp * Time.deltaTime, rb.velocity.y * movSp * Time.deltaTime);
            }
            if (invHud.GetComponent<InventoryHud>().activated)
            {
                rb.velocity = new Vector2(0, 0);
            }*/
        }

        if (controllerChecker.GetComponent<CheckForController>().mandoConectado) //Si el mando está conectado
        {
            if (!modoDetective.detective)
            {
                float hc = Input.GetAxis("HorizontalC");
                float vc = Input.GetAxis("VerticalC");

                movDir = (hc * transform.right + vc * transform.up);
                rb.velocity = movDir * movSp * Time.deltaTime;
                //rb.velocity = new Vector2(rb.velocity.x * movSp * Time.deltaTime, rb.velocity.y * movSp * Time.deltaTime);
            }
            if (modoDetective.detective)
            {
                rb.velocity = new Vector2(0, 0);
            }

            if (!invHud.GetComponent<InventoryHud>().activated)
            {
                float h = Input.GetAxis("HorizontalC");
                float v = Input.GetAxis("VerticalC");

                movDir = (h * transform.right + v * transform.up);
                rb.velocity = movDir * movSp * Time.deltaTime;
                //rb.velocity = new Vector2(rb.velocity.x * movSp * Time.deltaTime, rb.velocity.y * movSp * Time.deltaTime);
            }
            if (invHud.GetComponent<InventoryHud>().activated)
            {
                rb.velocity = new Vector2(0, 0);
            }
        }
    }
}
