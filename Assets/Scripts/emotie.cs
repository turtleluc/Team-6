using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emotie : MonoBehaviour
{
  public Sprite emotie1;
  public Sprite emotie2;
  public Sprite emotie3;
   
      public void emotieknop1()
      {
      this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie1;
      }


      public void emotieknop2()
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie2;
      }

      public void emotieknop3()
      {
        this.gameObject.GetComponent<SpriteRenderer>().sprite =emotie3;
      }
    
}
