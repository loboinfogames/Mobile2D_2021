using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOTOES : MonoBehaviour
{
    public void CarregarMENU()
    {
        SceneManager.LoadScene("MENU");
    }
    public void CarregarOption() {
        SceneManager.LoadScene("OPTION");
    }
    public void CarregarGameIntro() {
        SceneManager.LoadScene("GAMEINTRO");
    }
    public void CarregarGAME()
    {//Chama no Onclick do botao de menu
        SceneManager.LoadScene("GAMEF1");
    }

    public void CarregarGAMEOVER()
    {//Chama no Onclick do botao de jogar

        SceneManager.LoadScene("GAMEOVER");
    }
}
