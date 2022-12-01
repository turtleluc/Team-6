using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Next_Text : MonoBehaviour
{
    public int texthoeveelheid = 7;
    int i = 0;

    

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;


    public void text()
    {
        
        i++;

        
        if (i >= texthoeveelheid)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (i == 1)
        {
            
            Text1.SetActive(false);
            Text2.SetActive(true);
        }

        else if (i == 2)
        {
            Text2.SetActive(false);
            Text3.SetActive(true);
        }

        else if (i == 3)
        {
            Text3.SetActive(false);
            Text4.SetActive(true);
        }

        else if (i == 4)
        {
            Text4.SetActive(false);
            Text5.SetActive(true);
        }

        else
        {

        }

    }
}
