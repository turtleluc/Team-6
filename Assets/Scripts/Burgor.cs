using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Burgor : MonoBehaviour
{

    public Sprite newButtonImage;
    public Button newButton;

    public void Disable()
    {
      newButton.image.sprite = newButtonImage;
    }

    
}
