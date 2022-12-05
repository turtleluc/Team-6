using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauzemenu2 : MonoBehaviour
{
    [SerializeField] GameObject pauzemenu;
    
   public void pauze()
   {
     pauzemenu.SetActive(true);
     Time.timeScale =0f;
   }

   public void verder()
   {
     pauzemenu.SetActive(false);
     Time.timeScale =0f;
   }
   public void stoppen()
   {
        Application.Quit();
   }
}