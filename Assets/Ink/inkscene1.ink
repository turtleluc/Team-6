EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false


{ShowCharacter("Alice", "Right", "Sad")}
Paula: STEVE!!! 
lig je nog steeds in bed? Je komt zo te laat. Alwéér!!
{ShowCharacter("Player", "Left", "Fine")}
Steve: Huh?! Wat?! Oh nee, niet weer...
       
     Paula: Steve Goedhuis, je bent nu verdomd 18 jaar en ik moet je nog steeds uit je bed trommelen zodat je op tijd op school komt. Ga nou eens naar je leeftijd gedragen!
       
      Steve: ja, ja, ik ga al!
      {ChangeMood("Alice", "Upset")}
      Paula: Hmpf  
      oh ja, je trein vertrekt over 10 minuten.
      {ChangeMood("Player", "Surprised")}
      Steve: WAT? 
      EN DAT ZEG JE NU PAS!
       {ChangeMood("Alice", "Fine")}
      Paula: Jup, love you.
      {HideCharacter("Alice")}    
      {HideCharacter("Player")}
    -> DONE
