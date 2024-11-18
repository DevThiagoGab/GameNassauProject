using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private string nomeDoLevelDejogo;
    [SerializeField] private GameObject painelMenuinicial;
    [SerializeField] private GameObject painelOpcoes;

    public void Jogar() 
    {
        SceneManager.LoadScene(nomeDoLevelDejogo);
    }

    public void AbrirOpcoes() 
    {
        painelMenuinicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes() 
    {
        painelOpcoes.SetActive(false);
        painelMenuinicial.SetActive(true);
    }

    public void SairDoJogo() 
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

}
