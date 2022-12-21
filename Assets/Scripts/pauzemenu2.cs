using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauzemenu2 : MonoBehaviour
{
    public GameObject pauzemenu;
    
   public void pauze()
   {
     if (!pauzemenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauzemenu.SetActive(true);
                
            }

            else
            {
                Time.timeScale = 1f;
                pauzemenu.SetActive(false);
                

            }
   }

   public void verder()
    {
        Time.timeScale = 1f;
        pauzemenu.SetActive(false);
        
    }
   public void stoppen()
   {
        Application.Quit();
   }

     public void hoofdmenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
