
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText2 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Mak: ''Yo Steve! kom ff! Jeroen heeft een goed idee.''",
      "Jeroen:'' Ik dacht, laten we met z'n allen na dit semester een week op vakantie gaan... Naar Spanje!''",
      "Steve: ''Spanje? Ik ga mee!''",
      "Jeroen: ''Maarrr, iedereen betaalt wel een deel mee natuurlijk. Sowieso de vliegticket, je eigen kamer en eten voor 3 dagen. De rest regel ik wel.''",
      "Jeroen: ''Dat is zo ongeveer 650 euro per persoon.''",
      "Davy: ''Klinkt redelijk… ''",
      "Mak: ''prima, stuur dan even een betaalverzoek in de groepsapp.''",
      "Steve moest even slikken",
      "Jeroen: ''Steve?''",
      "Steve: ''Hm? Oh ja klinkt goed, wanneer moet je het hebben?''", 
      "Jeroen: ''Voor Juli is goed, duurt nog even voor de zomervakantie.''",
      "Steve: ''Komt goed''",
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
      delay = 10;

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
