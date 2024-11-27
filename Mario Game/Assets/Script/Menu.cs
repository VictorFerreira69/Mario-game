

using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Nome Fase")]
    public string nomeDaFase;

    [Header("Paineis")]
    public GameObject painelOpçao;
    public GameObject painelMenuInicial;

    
    public  void Jogar()
    {
        SceneManager.LoadScene("Fase1");
    }
    public void AbrirOpçao()
    {
      painelMenuInicial.SetActive(false);
      painelOpçao.SetActive(true);
    }
    public void FecharOpçao()
    {
        painelMenuInicial.SetActive(true);
        painelOpçao.SetActive(false);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
