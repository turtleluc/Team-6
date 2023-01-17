
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText1 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Twee strepen licht vielen op steve's gezicht. Hij kneep zijn ogen verder dicht en draaide zich om, niet klaar om de dag te beginnen.",
      "Hij had gister een nieuwe game gekocht en was tot midden in de nacht blijven spelen. Hij was daarna direct in bed gekropen zonder op te ruimen. nu lag zijn bureau nog vol met troep en ergens in een hoekje lagen zijn schoolboeken verstopt.",
      "Paula: STEVE!!!",
      "Paula stormde de kamer in.",
      "Paula: lig je nog steeds in bed? Je komt zo te laat. Alwéér",
      "Steve schrok wakker en keek naar zijn wekker",
      "Steve: Huh?! Wat?! Oh nee, niet weer... ",
      "Paula: Steve Goedhuis, je bent nu verdomd 18 jaar en ik moet je nog steeds uit je bed trommelen zodat je op tijd op school komt. Ga nou eens naar je leeftijd gedragen! ",
      "Steve: ja, ja, ik ga al!",
      "Steve viel uit bed, de vloer nog beladen met kleding van afgelopen week. Paula stampte boos zijn kamer uit.",
      "Paula: Hmpf", 
      "het zand nog uit zijn ogen wrijvend, pakte hij een schone broek en T-shirt en zijn spullen bij elkaar .",
      "Paula: oh ja, je trein vertrekt over 10 minuten.",
      "Steve: WAT?",
      "Steve: EN DAT ZEG JE NU PAS!",
      "Paula: Jup, love you.",
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
