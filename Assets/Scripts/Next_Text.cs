using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Next_Text : MonoBehaviour
{
    public int texthoeveelheid = 7;
    int i = 0;

    public void text()
    {
        
        i++;
        Debug.Log(i);

        if (i >= texthoeveelheid)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else 
        {

        }
       
    }
}
