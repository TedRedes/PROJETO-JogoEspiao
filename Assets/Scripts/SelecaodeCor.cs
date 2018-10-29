using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecaodeCor : MonoBehaviour {

    public Text txtcor; // texto para mostrar a cor de exemplo
    public static Dropdown corpersonagem; // seleção de cor do player


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SelecionarCor()
    {
        switch (corpersonagem.value)
        {
            case 0:
                txtcor.text = "A cor do Personagem será Vermelho ";
                break;
            case 1:
                txtcor.text = "A cor do Personagem será Azul ";
                break;
            case 2:
                txtcor.text = "A cor do Personagem será Verde ";
                break;
            case 3:
                txtcor.text = "A cor do Personagem será Cinza ";
                break;
            case 4:
                txtcor.text = "A cor do Personagem será Preto ";
                break;


        }

    }
}
