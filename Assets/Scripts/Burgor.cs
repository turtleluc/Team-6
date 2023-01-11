using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burgor : MonoBehaviour
{

    

    public void Disable()
    {
        boton2 = GetComponent<Button>();
        boton2.interactable = false;
    }

    
}
