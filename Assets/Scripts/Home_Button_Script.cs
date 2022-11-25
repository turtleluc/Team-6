using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home_Button_Script : MonoBehaviour
{
    public void HomeGame()
    {
        SceneManager.LoadScene("Menu");
    }


}
