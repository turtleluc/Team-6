using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Site : MonoBehaviour
{
    public void VsiteGame()
    {
        SceneManager.LoadScene("Scene_Site");
    }

    public void LsiteGame()
    {
        SceneManager.LoadScene("Scene_5");
    }

}