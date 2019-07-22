using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InventoryHud : MonoBehaviour
{

    public static InventoryHud hud;

    public bool activated;
    public float velocity;
    public Transform inventoryPosition;
    public bool moveUp;
    public bool moveDown;
    public float posfin;

    public GameObject controllerChecker;

    //Objetos
    public GameObject probeta;
    public GameObject myProbeta;

    public GameObject probetaSangre;
    public GameObject myProbetaSangre;

    public GameObject palanca;
    public GameObject myPalanca;

    public GameObject bolsa;
    public GameObject myBolsa;

    public GameObject bolsaCoca;
    public GameObject myBolsaCoca;

    public GameObject ladrillo;
    public GameObject myLadrillo;

    public GameObject cartel;
    public GameObject myCartel;

    public GameObject fotos;
    public GameObject myFotos;

    public GameObject equis;
    public GameObject myEquis;

    public GameObject llave;
    public GameObject myLlave;

    public GameObject pistola;
    public GameObject myPistola;

    public Transform spawnProbetas;
    public Transform spawnPalanca;
    public Transform spawnBolsas;
    public Transform spawnLadrillo;
    public Transform spawnCartel;
    public Transform spawnFotos;
    public Transform spawnEquis;
    public Transform spawnLlave;
    public Transform spawnPistola;

    public static bool boolProbeta;
    public static bool probetaRecogida;
    public static bool boolProbetaSangre;
    public static bool boolPalanca;
    public static bool palancaRecogida;
    public static bool boolBolsa;
    public static bool bolsaRecogida;
    public static bool boolLadrillo;
    public static bool ladrilloRecogido;
    public static bool boolBolsaCoca;
    public static bool boolCartel;
    public static bool cartelRecogida;
    public static bool boolFotos;
    public static bool fotosRecogida;
    public static bool boolEquis;
    public static bool equisRecogida;
    public static bool boolLlave;
    public static bool llaveRecogida;
    public static bool boolPistola;
    //Objetos END

    void Awake()
    {
        if (hud == null)
        {
            DontDestroyOnLoad(gameObject);
            hud = this;
        }
        else if (hud != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        DontDestroyOnLoad(gameObject);

        activated = false;
        inventoryPosition = transform;
        velocity = 0.2f;
        controllerChecker = GameObject.Find("ControllerChecker");
    }

    void Update()
    {
        //movimiento inventario

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, Mathf.Clamp(gameObject.transform.position.z, - 1.5f, -1.5f));

        if (Input.GetButtonDown("CallInventory") && activated == false)
        {
            moveUp = true;
            activated = true;
            Debug.Log("inventory activated");
        }
        else if (Input.GetButtonDown("CallInventory") && activated == true)
        {
            moveDown = true;
            activated = false;
            Debug.Log("inventory desactivated");
        }

        if (moveUp == true && moveDown == false)
        {
            inventoryPosition.Translate(0, 2, 0);
            if (inventoryPosition.position.y >= posfin)
            {
                inventoryPosition.position = new Vector3(0, posfin, 0);
                moveUp = false;
            }
        }

        if(moveDown == true && moveUp == false)
        {
            inventoryPosition.Translate(0, -2, 0);
            if (inventoryPosition.position.y <= -12)
            {
                inventoryPosition.position = new Vector3(0, -12, 0);
                moveDown = false;
            }
        }

        //objetos
        //instancia los objetos dentro del inventario segun los parámetros establecidos

        if (boolProbeta)
        {
            myProbeta = Instantiate(probeta, spawnProbetas.position, spawnProbetas.rotation);
            myProbeta.transform.parent = gameObject.transform;
            probetaRecogida = true;
            StartCoroutine(WaitProbeta());
            //PlayerPrefs.SetInt("hasProbeta", 1);
            //Inventory.hasProbeta = PlayerPrefs.GetInt("hasProbeta");
            Inventory.hasProbeta = 1;
        }

        if(boolProbetaSangre && probetaRecogida)
        {
            myProbetaSangre = Instantiate(probetaSangre, spawnProbetas.position, spawnProbetas.rotation);
            myProbetaSangre.transform.parent = gameObject.transform;
            StartCoroutine(WaitSangre());
            Inventory.hasMuestra = 1;
        }

        if (boolPalanca)
        {
            myPalanca = Instantiate(palanca, spawnPalanca.position, spawnPalanca.rotation);
            myPalanca.transform.parent = gameObject.transform;
            palancaRecogida = true;
            StartCoroutine(WaitPalanca());
            Inventory.hasPalanca = 1;
        }

        if (boolBolsa)
        {
            myBolsa = Instantiate(bolsa, spawnBolsas.position, spawnBolsas.rotation);
            myBolsa.transform.parent = gameObject.transform;
            bolsaRecogida = true;
            StartCoroutine(WaitBolsa());
            Inventory.hasBolsa = 1;
        }

        if (palancaRecogida && boolLadrillo)
        {
            myLadrillo = Instantiate(ladrillo, spawnLadrillo.position, spawnLadrillo.rotation);
            myLadrillo.transform.parent = gameObject.transform;
            ladrilloRecogido = true;
            StartCoroutine(WaitLadrillo());
            Inventory.hasLadrillo = 1;
        }

        if (boolBolsaCoca && bolsaRecogida && ladrilloRecogido)
        {
            myBolsaCoca = Instantiate(bolsaCoca, spawnBolsas.position, spawnBolsas.rotation);
            myBolsaCoca.transform.parent = gameObject.transform;
            StartCoroutine(WaitCoca());
            Inventory.hasCoca = 1;
        }

        if (boolCartel)
        {
            myCartel = Instantiate(cartel, spawnCartel.position, spawnCartel.rotation);
            myCartel.transform.parent = gameObject.transform;
            cartelRecogida = true;
            StartCoroutine(WaitCartel());
            Inventory.hasCartel = 1;
        }

        if (boolFotos)
        {
            myFotos = Instantiate(fotos, spawnFotos.position, spawnFotos.rotation);
            myFotos.transform.parent = gameObject.transform;
            fotosRecogida = true;
            StartCoroutine(WaitFotos());
            Inventory.hasFotos = 1;
        }

        if (boolEquis)
        {
            myEquis = Instantiate(equis, spawnEquis.position, spawnEquis.rotation);
            myEquis.transform.parent = gameObject.transform;
            equisRecogida = true;
            StartCoroutine(WaitEquis());
            Inventory.hasX = 1;
        }

        if (boolLlave)
        {
            myLlave = Instantiate(llave, spawnLlave.position, spawnLlave.rotation);
            myLlave.transform.parent = gameObject.transform;
            llaveRecogida = true;
            StartCoroutine(WaitLlave());
            Inventory.hasLlave = 1;
        }

        if (boolPistola && llaveRecogida)
        {
            myPistola = Instantiate(pistola, spawnPistola.position, spawnPistola.rotation);
            myPistola.transform.parent = gameObject.transform;
            StartCoroutine(WaitPistola());
            //StartCoroutine(GoToCredits());
            Inventory.hasPipa = 1;
        }
    }

    IEnumerator WaitProbeta()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject probs = GameObject.Find("ProbetaPrefab(Clone)");
        //Destroy(probs);
        boolProbeta = false;
    }
    IEnumerator WaitPalanca()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject palanca = GameObject.Find("PalancaPrefab(Clone)");
        //Destroy(palanca);
        boolPalanca = false;
    }
    IEnumerator WaitLadrillo()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject ladrillo = GameObject.Find("LadrilloPrefab(Clone)");
        boolLadrillo = false;
    }
    IEnumerator WaitSangre()
    {
        yield return new WaitForSeconds(0.1f);
        myProbeta.SetActive(false);
        GameObject probs = GameObject.Find("ProbetaPrefab(Clone)");
        Destroy(probs);
        GameObject probsan = GameObject.Find("ProbetaPrefabSangre(Clone)");
        Destroy(probsan);
        boolProbetaSangre = false;
    }
    IEnumerator WaitBolsa()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject bolsa = GameObject.Find("BolsaPalanca(Clone)");
        //Destroy(bolsa);
        boolBolsa = false;
    }
    IEnumerator WaitCoca()
    {
        yield return new WaitForSeconds(0.1f);
        myBolsa.SetActive(false);
        GameObject bolsa = GameObject.Find("BolsaPrefab(Clone)");
        Destroy(bolsa);
        GameObject coca = GameObject.Find("CocaPrefab(Clone)");
        //Destroy(coca);
        boolBolsaCoca = false;
    }
    IEnumerator WaitCartel()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject cart = GameObject.Find("CartelPrefab(Clone)");
        //Destroy(cart);
        boolCartel = false;
    }
    IEnumerator WaitFotos()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject fot = GameObject.Find("FotosPrefab(Clone)");
        //Destroy(fot);
        boolFotos = false;
    }
    IEnumerator WaitEquis()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject eks = GameObject.Find("XPrefab(Clone)");
        //Destroy(eks);
        boolEquis = false;
    }
    IEnumerator WaitLlave()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject clave = GameObject.Find("LlavePrefab(Clone)");
        //Destroy(clave);
        boolLlave = false;
    }
    IEnumerator WaitPistola()
    {
        yield return new WaitForSeconds(0.05f);
        GameObject pipa = GameObject.Find("PistolaPrefab(Clone)");
        //Destroy(pipa);
        boolPistola = false;
    }

    IEnumerator GoToCredits()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Credits");
    }
}
