using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stevep : MonoBehaviour
{
  public Sprite Steve1;
  public Sprite Steve2;
  public Sprite Steve3;
   
    void Update()
    {
         if (Input.GetMouseButton(0))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =Steve1;
      }

      if (Input.GetMouseButton(2))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =Steve2;
      }

      if (Input.GetMouseButton(1))
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =Steve3;
      }
    }
}
