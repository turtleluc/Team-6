
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scr_DynaText5 : MonoBehaviour
{
    public bool start;

    public int t;
    public int l;
    public int i;

    public string line;

    private int j;
    private int delay;

    private string[] txt = new string[]{
      "Mike: Hier.",
       "Mike: Vertel, wat is er aan de hand. Je werkt de laatste tijd ongelofelijk veel en lang, waarom is dat?",
      "Mike: Je gaat in ieder geval niet meer de vloer op vandaag, dat kan ik je verzekeren.",
      "Steve: Ik uhm, uhm...",
      "Steve: Mijn vrienden wouden op vakantie met de groep en ik zei dat ik meeging… maar ik heb niet genoeg geld enneh… om dus mee te kunnen moet ik ergens geld vandaan halen…",
      "Mike: Dus ga je spijbelen om toch maar wat meer te kunnen werken. Je had je ouders toch ook kunnen vragen om wat geld bij te leggen?",
      "Steve: Ik wil die vakantie helemaal zelf kunnen betalen", 
      "Mike: Jongen dit ga je niet vol houden. Je school en werk gaan keihard achteruit.",
      "Je slaapt minder door al die late diensten en je leeft bijna alleen maar op energy drinks. Dit is niet goed.",
      "Steve: maar ik wil zo graag mee...",
       "Mike: Ik heb wel een ander idee waardoor je wat sneller geld kan krijgen. Dan kun je in ieder geval wat minder werken.",
      "Steve: Echt?",
      "Mike: Wist je dat je belasting kan terugvragen over je loon?",
      "Steve: nee. Dat is wel super chill tho!",
      "mike: Ik kan je niet beloven dat het heel veel is, maar dat ligt eraan over hoeveel jaar je terugvraagt.",
      "Mike keek kort naar zijn horloge.",
      "Mike: Maareh, ik ga jou nu naar huis sturen, kom morgenavond maar langs tegen 8 uur dan regelen we het even.",
      "Steve knikte enthousiast en stond op.",
      "Mike: Ik stuur je wel een lijstje wat je mee moet nemen. Goed slapen vanavond ja?",
      "Steve: Zal ik doen! Werk ze!",
      "Mike: Yow!",
      
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
