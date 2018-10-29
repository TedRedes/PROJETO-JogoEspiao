using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class DefinirLocalProfissao : MonoBehaviour {

    public Text NomeCharLocal;
    string nomeCharDefinitivo;
    public Text ProfissaoLocal;
    public Text LocalizacaoLocal;

    // Use this for initialization
    void Start () {

        nomeCharDefinitivo = GameManager.CharNomeLocal;
            NomeCharLocal.text = nomeCharDefinitivo;
            ProfissaoLocal.text = "Tec de Suporte";
            LocalizacaoLocal.text = "Super Mercado";

        
        
    
        
    }

    // Update is called once per frame
    void Update () {
        
        //UnityEngine.SceneManagement.SceneManager.LoadScene("Partida");

    }
    
}
