using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;

    public void Jogar(string nomeDolevelDeJogo) 
    {
        SceneManager.LoadScene(nomeDolevelDeJogo);
    }

    /*
    public void AbrirOpcoes() 
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes() 
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    */

    public void SairDoJogo() 
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

    public void VoltarParaMenu(string nomeDoMenuPrincipal)
    {
        SceneManager.LoadScene(nomeDoMenuPrincipal);
    }

}
