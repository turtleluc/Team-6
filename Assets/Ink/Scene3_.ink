EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Player", "Left", "Fine")}
Steve: Als je nog open diensten hebt geef ze dan maar aan mij! Ik heb meer tijd deze maand. 
 {ChangeMood("Player", "Surprised")}
 {ShowCharacter("Alice", "Right", "Sad")}
Mike: Weet je dat zeker? Niet zo'n hele belangrijke afspraak zoals school? 
{ChangeMood("Alice", "Serious")}
Steve: Ik heb eerder vrij omdat ons groepje al klaar is met het project. 
{ChangeMood("Alice", "Upset")}
{ChangeMood("Player", "Sad")}
Mike: Als jij het zegt dan heb ik nog een shift open voor woensdag om… 
     {HideCharacter("Alice")}    
      {HideCharacter("Player")}
    -> DONE