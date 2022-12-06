using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauzemenu2 : MonoBehaviour
{
    public GameObject pauzemenu;
    
   public void pauze()
   {
     if (!pauzemenu.activeSelf)
            {
                Time.timeScale = 0f;
                pauzemenu.SetActive(true);
                Cursor.visible = true;
            }
            else
            {
                Time.timeScale = 1f;
                pauzemenu.SetActive(false);
                Cursor.visible = false;

            }
   }

   public void verder()
   {
       Time.timeScale = 1f;
        pauzemenu.SetActive(false);
    Cursor.visible = false;
   }
   public void stoppen()
   {
        Application.Quit();
   }
}