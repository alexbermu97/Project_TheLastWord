using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static SceneController sceneController;
    public int lastScene;
    public Scene scene;

    // Start is called before the first frame update
    void Awake()
    {
        if (sceneController == null)
        {
            DontDestroyOnLoad(gameObject);
            sceneController = this;
        }
        else if (sceneController != this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        lastScene = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scene = SceneManager.GetActiveScene();
        if (scene.name == "Comisaría-1")
        {
            lastScene = 1;
        }
        if (scene.name == "Bar-1")
        {
            lastScene = 2;
        }
        if (scene.name == "Callejón-1")
        {
            lastScene = 3;
        }
    }
}
