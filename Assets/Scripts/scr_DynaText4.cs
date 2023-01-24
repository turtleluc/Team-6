
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText4 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Dag 1 Steve: Net zes uur gewerkt, 48 euro in de pocket!",
      "Dag 3 Steve: Vroeg opstaan om tot 18:00 te werken, geen zin maar ik kom er wel door!",
      "Dag 8 Steve: Zo moe, maar nog twee uurtjes dan ben ik vrij.", 
      "Dag 14 Steve: Nog drie uur...",
      
     
      "Mike: ''2 patat middel, een bak kipnuggets en een hamburger double jerky Steve.''",

      "Mike: ''Steve?''",
      "Mike: ''Hey Steve.''",
      "Mike knipte zijn vingers voor Steves ogen.",
      "Steve: ''Huh wat? Oh.''",
      "Mike: ''Gaat het wel jongen? Je bent spierwit Kom.''",

    };

    public Text textElement;
    // Start is called before the first frame update
    void Start()
    {
      line = "";
      textElement.text = line;
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetMouseButtonDown(0))      
      {
          start = !start;
      }

      if (Input.GetMouseButtonUp(0))
      {
        if(l < txt[i].Length)
      	{
      		l = txt[i].Length;
      	}
      	else
      	{
      		l = 0;
      		if(i < txt.Length-1)
      		{
      			i++;
      		}
      		else
      		{
      			i = 0;
      		}
      	}
      }

      if(start == true)
      {
        t++;
      }

      j = 0;
      delay = 5;

      if(t >= delay)
      {
        /*
      	if l < string_length(text[i])
      	{
      		if string_char_at(text[i],l) != " "
      		{
      			audio_sound_pitch(snd_Tick,irandom_range(4,8));
      			audio_play_sound(snd_Tick,0,0);
      		}
      	}*/
      	l++;
      	t = 0;
      }

      while(j<=txt[i].Length && j<=l)
      {
      	line = txt[i].Substring(0,j);
      	j++;
      }

      textElement.text = line;
    }
}
