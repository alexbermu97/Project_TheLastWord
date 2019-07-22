using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerProgreso : MonoBehaviour

{
    //ESCRIBIR EN COMENTARIO LOS DETALLES DE CADA UNO DE ESTOS BOOLEANOS
    public bool capitulo1Completado; //se ha completado el capitulo 1
    public bool capitulo2Completado; //se ha completado el capitulo 2
    public bool capitulo3Completado; //se ha completado el capitulo 3
    public bool capitulo4Completado; //se ha completado el capitulo 4
    public bool final;               //se ha terminado el juego
    public bool caso;                //te asignan el caso
    public bool cogerProbeta;        //has cogido la probeta
    public bool cogerBolsa;          //has cogido la bolsa
    public bool cogerPalanca;        //has cogido la palanca
    public bool puedoCogerProbeta;   //puedes coger la probeta
    public bool puedoCogerBolsa;     //puedes coger la bolsa
    public bool puedoCogerPalanca;   //puedes coger la palanca
    public bool cogerSangre;         //has cogido la sangre
    public bool puedoCogerSangre;    //puedes coger la sangre
    public bool abrirLadrillo;       //abres el ladrillo
    public bool puedoAbrirLadrillo;  //puedes abrir el ladrillo
    public bool cogerCocaina;        //has cogido la cocaina
    public bool puedoCogerCocaina;   //puedes coger la cocaina
    public bool hablarSC;            //sc = señorita de compañía
    public bool abrirCaja;           //Caja de pruebas
    public bool puedoAbrirCaja;      //puedo abrir la caja de pruebas
    public bool cogerFotos;          //has cogido las fotos
    public bool puedoCogerFotos;     //puedo coger las fotos
    public bool cogerCartel;         //has cogido el cartel
    public bool puedoCogerCartel;    //puedo coger el cartel
    public bool cogerX;              //has cogido objeto del capitulo 3 por definir
    public bool puedoCogerX;         //puedes coger el objeto X
    public bool compararCartel;      //comparas el cartel del baño con el trozo
    public bool usarX;               //usas el objeto x
    public bool conversacionBaños;   //has escuchado la conversacion en los baños
    public bool cogerLlave;          //has cogido la llave
    public bool puedoCogerLlave;     //puesdes coger la llave
    public bool barmanDistraido;     //el bar man está distraido
    public bool abrirGramola;        //abres la gramola 
    public bool puedoAbrirGramola;   //puedes abrir la gramola
    public bool cogerRevolver;       //has cogido el revolver de la gramola 
    public bool puedoCogerRevolver;  //puedes coger el revolver
    public bool hablarBarman;        //hablas con el barman y tomas la decision final
    public bool puedoHablarBarman;   //puedes hablar con el barman 
           


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        capitulo1Completado  = false;
        capitulo2Completado  = false;
        capitulo3Completado  = false;
        capitulo4Completado  = false;
        final                = false;
        caso                 = false;
        puedoCogerProbeta    = false;
        puedoCogerBolsa      = false;
        puedoCogerPalanca    = false;
        cogerProbeta         = false;
        cogerBolsa           = false;
        cogerPalanca         = false;
        cogerSangre          = false;
        puedoCogerSangre     = false;
        abrirLadrillo        = false;
        puedoAbrirLadrillo   = false;
        cogerCocaina         = false;
        puedoCogerCocaina    = false;
        hablarSC             = false;
        abrirCaja            = false;
        puedoAbrirCaja       = false;
        cogerFotos           = false;
        puedoCogerFotos      = false;
        cogerCartel          = false;
        puedoCogerCartel     = false;
        cogerX               = false;
        puedoCogerX          = false;
        compararCartel       = false;
        usarX                = false;
        conversacionBaños    = false;
        cogerLlave           = false;
        puedoCogerLlave      = false;
        barmanDistraido      = false;
        abrirGramola         = false;
        puedoAbrirGramola    = false;
        cogerRevolver        = false;
        puedoCogerRevolver   = false;
        hablarBarman         = false;
        puedoHablarBarman    = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (caso)
        {
            capitulo1Completado = true;
        }

        if (capitulo1Completado)
        {
            puedoCogerProbeta = true;
            puedoCogerBolsa   = true;
            puedoCogerPalanca = true;
        }

        if (cogerPalanca)
        {
            puedoAbrirLadrillo = true;
        }

        if (cogerBolsa && abrirLadrillo)
        {
            puedoCogerCocaina = true;
        }

        if (cogerProbeta)
        {
            puedoCogerSangre = true;
        }
                
        if (cogerCocaina && cogerSangre && hablarSC)
        {
            capitulo2Completado = true;
        }

        if (capitulo2Completado)
        {
            puedoAbrirCaja = true;
        }

        if (abrirCaja)
        {
            puedoCogerCartel = true;
            puedoCogerX = true;
            puedoCogerFotos = true;
        }

        if (compararCartel && usarX)
        {
            capitulo3Completado = true;
        }

        if (capitulo3Completado)
        {
            conversacionBaños = true;
        }
        
        if (conversacionBaños && barmanDistraido)
        {
            puedoCogerLlave = true;
        }

        if (cogerLlave && barmanDistraido)
        {
            puedoAbrirGramola = true;
        }

        if (abrirGramola)
        {
            puedoCogerRevolver = true;
        }

        if (cogerRevolver)
        {
            puedoHablarBarman = true;
        }

        if (hablarBarman)
        {
            capitulo4Completado = true;
        }

        if (final)
        {
            //Creditos y vuelta al menu principal
        }
       
    }
}
