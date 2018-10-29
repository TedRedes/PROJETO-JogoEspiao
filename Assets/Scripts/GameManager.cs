using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static string CharNomeLocal; //Nome do Player
    public static Color Char_color; // Cor do  Player
    public InputField txtNome; //input do nome do player
    public Button btnpassafase; // botao para trocar de cena

    public BoxCollider CharCorExemplo;
    Color exemplodecor;


    void Start()
    {
        btnpassafase.onClick.AddListener(TaskOnClick);

    }


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);

    }

    void TaskOnClick()
    {
        // Ação ao Clicar no botão
        CharNomeLocal = txtNome.text; // definir nome do Player para variável estática

    }



    void Update()
    {
        switch (SelecaodeCor.corpersonagem.value)
        {
            case 0:
                Char_color = Color.red;
                break;
            case 1:
                Char_color = Color.blue;
                break;
            case 2:
                Char_color = Color.green;
                break;
            case 3:
                Char_color = Color.gray;
                break;
            case 4:
                Char_color = Color.black;
                break;

        }

        

            

    }
}