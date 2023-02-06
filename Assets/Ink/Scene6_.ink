EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Player", "Left", "Fine")}
Steve: Check. 
{ChangeMood("Player", "Surprised")}
Steve: godsamme, moet dit weer? 
{HideCharacter("Player")}
    -> DONE