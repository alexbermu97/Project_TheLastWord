using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f;

    [SerializeField]
    private string SceneNameLoad;

    private float timeElapsed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {


            SceneManager.LoadScene(SceneNameLoad);
        }
        
    }

   
}

   