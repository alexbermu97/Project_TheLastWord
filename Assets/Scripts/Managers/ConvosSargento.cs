using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class ConvosSargento : MonoBehaviour
{
    [SerializeField]
    private TextAsset inkJSONAsset;
    private Story story;

    [SerializeField]
    private Canvas canvas;

    // UI Prefabs
    [SerializeField]
    private Text textPrefab;
    [SerializeField]
    private Button buttonPrefab;

    public GameObject player;

    public string convo;

    //Joystick


    void Awake()
    {
        // Eliminar el mensaje predeterminado
        RemoveChildren();
        StartStory();
    }

    void Start()
    {
        //story = new Story(inkJSONAsset.text);
        player = GameObject.Find("PlayerProto");
    }

    void Update()
    {
        print(story.canContinue);
    }

    public void Tags()
    {
        story.TagsForContentAtPath("Capitulo_1_SZ_EN");
        if (story.currentTags.Count == 0) //¿¿¿¿¿POR QUÉ NO FUNCIONAS, PEDAZO DE MIERDA?????
        {
            int mierder = story.currentTags.Count;
            print(mierder);
        }
        else if (story.currentTags[0] == "finconv" || story.currentTags[1] == "finconv")
        {
            print("hola");
        }
    }

    /*void OnTriggerStay2D(Collider2D coli)
    {
        if (coli.gameObject == player.gameObject)
        {
            Tags();
        }
    }*/


    // Crea un nuevo story object con la historia compilada que luego podemos jugar
    void StartStory()
    {
        story = new Story(inkJSONAsset.text);
        RefreshView();
    }


    void RefreshView()
    {
        // Eliminar la UI en la pantalla
        RemoveChildren();


        while (story.canContinue)
        {
            // da la siguiente linea de texto
            string text = story.Continue();

            text = text.Trim();
            // Activa el texto en pantalla
            CreateContentView(text);
        }

        // activa todas las opciones, si hay alguna
        if (story.currentChoices.Count > 0)
        {
            for (int i = 0; i < story.currentChoices.Count; i++)
            {
                Choice choice = story.currentChoices[i];
                Button button = CreateChoiceView(choice.text.Trim());
                // Dice al boton lo que tiene que hacer cuando es presionado
                button.onClick.AddListener(delegate {
                    OnClickChoiceButton(choice);
                });
            }
        }
        // si hemos leido todo y no hay más opciones se elimina el texto o se reinicia
        else
        {
            Button choice = CreateChoiceView("Volver");
            choice.onClick.AddListener(delegate {
                StartStory();
            });

            /*Button choice2 = CreateChoiceView("Cerrar conversación");
            choice2.onClick.AddListener(delegate {
                RemoveChildren();
            });*/
        }
    }

    // Cuando presionamos el boton de elección, selecciona la opcion selecionada de la historia
    public void OnClickChoiceButton(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index);
        RefreshView();
        /*print("clicked");
        story.ContinueMaximally();
        print("continue");*/
        if (convo == "convo1")
        {
            PJsManager.barCol = 1;
        }
        if (convo == "convo2")
        {
            PJsManager.callejCol = 1;
            PJsManager.sargeconv2 = 1;
        }
        if (convo == "convo3")
        {
        }
    }

    // Crea un boton con el texto 
    void CreateContentView(string text)
    {
        Text storyText = Instantiate(textPrefab) as Text;
        storyText.text = text;
        storyText.transform.SetParent(canvas.transform, false);
    }

    // Crea un boton con el texto 
    Button CreateChoiceView(string text)
    {
        // Crea el boton desde el prefap
        Button choice = Instantiate(buttonPrefab) as Button;
        choice.transform.SetParent(canvas.transform, false);

        // Genera el texto 
        Text choiceText = choice.GetComponentInChildren<Text>();
        choiceText.text = text;

        // El boton se adapta al texto
        HorizontalLayoutGroup layoutGroup = choice.GetComponent<HorizontalLayoutGroup>();
        layoutGroup.childForceExpandHeight = false;

        return choice;
    }

    // Destruye todos los hijos del prefap (Toda la UI)
    void RemoveChildren()
    {
        int childCount = canvas.transform.childCount;
        for (int i = childCount - 1; i >= 0; --i)
        {
            GameObject.Destroy(canvas.transform.GetChild(i).gameObject);
        }
    }
}
