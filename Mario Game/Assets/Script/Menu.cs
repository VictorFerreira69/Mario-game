

using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Nome Fase")]
    public string nomeDaFase;

    [Header("Paineis")]
    public GameObject painelOp�ao;
    public GameObject painelMenuInicial;

    
    public  void Jogar()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void AbrirOp�ao()
    {
      painelMenuInicial.SetActive(false);
      painelOp�ao.SetActive(true);
    }
    public void FecharOp�ao()
    {
        painelMenuInicial.SetActive(true);
        painelOp�ao.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
