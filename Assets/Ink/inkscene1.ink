EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

{ShowCharacter("Paula", "Right", "Boos")}
Paula: STEVE!!! 
lig je nog steeds in bed? Je komt zo te laat. Alwéér''",
{ShowCharacter("Steve", "Left", "Normaal")}
Steve: Huh?! Wat?! Oh nee, niet weer...
       
     Paula: Steve Goedhuis, je bent nu verdomd 18 jaar en ik moet je nog steeds uit je bed trommelen zodat je op tijd op school komt. Ga nou eens naar je leeftijd gedragen!
       
      Steve: ja, ja, ik ga al!
      {ChangeMood("Paula", "Praat1")}
      Paula: Hmpf  
      oh ja, je trein vertrekt over 10 minuten.
      {ChangeMood("Steve", "Praat1")}
      Steve: WAT? 
      EN DAT ZEG JE NU PAS!
       {ChangeMood("Paula", "Blij")}
      Paula: Jup, love you.
    -> DONE
