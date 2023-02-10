EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Player", "Left", "Fine")}
Dag 1 Steve: Net zes uur gewerkt, 48 euro in de pocket! 
Dag 3 Steve: Vroeg opstaan om tot 18:00 te werken, geen zin maar ik kom er wel door! 
{ChangeMood("Player", "Sad")}
Dag 8 Steve: Zo moe, maar nog twee uurtjes dan ben ik vrij. 
Dag 14 Steve: Nog drie uur... 
      
    {ChangeMood("Player", "Upset")}   
{ShowCharacter("Alice", "Right", "Serious")}      
Mike: 2 patat middel, een bak kipnuggets en een hamburger double jerky Steve. 

Mike: Steve? 
Mike: Hey Steve. 
Mike knipte zijn vingers voor Steves ogen. 
{ChangeMood("Player", "Serious")} 
Steve: Huh wat? Oh. 
{ChangeMood("Player", "Upset")}   
{ChangeMood("Alice", "Surprised")}   
Mike: Gaat het wel jongen? Je bent spierwit Kom. 
{HideCharacter("Alice")}
{HideCharacter("Player")}
    -> DONE
