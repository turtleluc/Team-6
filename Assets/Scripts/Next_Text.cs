using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Next_Text : MonoBehaviour
{

  
    int i = 0;
    public Button Knop;

    public void text()
    {
        i ++;

        if (i == 10)
        {
            Knop.interactable = false;


            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
