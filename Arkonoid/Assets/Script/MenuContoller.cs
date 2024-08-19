using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuContoller : MonoBehaviour
{
    public GameObject optionsPainel, creditsPainel, controllsPainel;
         
    public void Teleport(string tp)
    {
        SceneManager.LoadScene(tp);
    }
    public void OpenOptionsBTN()
    {
        optionsPainel.SetActive(true);
    }

    public void CloseOptionsBTN()
    {
        optionsPainel.SetActive(false);
    }

    public void OpenCreditsBTN()
    {
        creditsPainel.SetActive(true);
    }
    public void CloseCreditsBTN()
    {
        creditsPainel.SetActive(false);
    }

    public void OpenContollsBTN()
    {
        controllsPainel.SetActive(true);
    }

    public void CloseContollsBTN()
    {
        controllsPainel.SetActive(false);
    }

    public void QuitBTN()
    {
        Application.Quit();
        print("Quitou");
    }
        
     

}
    

