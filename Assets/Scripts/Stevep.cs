using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stevep : MonoBehaviour
{
  public Sprite emotie1;
  public Sprite emotie2;
  public Sprite emotie3;
   
    void Update()
    {
         if (Input.GetMouseButton(0))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie1;
      }

      if (Input.GetMouseButton(2))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie2;
      }

      if (Input.GetMouseButton(1))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie3;
      }
    }
}
