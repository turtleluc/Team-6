EXTERNAL ShowCharacter(characterName, position, mood) 
EXTERNAL HideCharacter(characterName)
EXTERNAL ChangeMood(characterName, mood)

VAR relationship_strength = 80
VAR mental_health = 50

VAR know_about_food_issue = false

{ShowCharacter("Alice", "Right", "Sad")}
Mike: Hier.  
{ShowCharacter("Player", "Left", "Uncomfortable")}
Mike: Vertel, wat is er aan de hand. Je werkt de laatste tijd ongelofelijk veel en lang, waarom is dat?

Mike: Je gaat in ieder geval niet meer de vloer op vandaag, dat kan ik je verzekeren.
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Upset")}
Steve: Ik uhm, uhm...
Steve: Mijn vrienden wouden op vakantie met de groep en ik zei dat ik meeging… maar ik heb niet genoeg geld enneh… om dus mee te kunnen moet ik ergens geld vandaan halen…
{ChangeMood("Player", "Uncomfortable")}
{ChangeMood("Alice", "Upset")}
Mike: Dus ga je spijbelen om toch maar wat meer te kunnen werken. Je had je ouders toch ook kunnen vragen om wat geld bij te leggen?
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Upset")}
Steve: Ik wil die vakantie helemaal zelf kunnen betalen. 
{ChangeMood("Player", "Uncomfortable")}
{ChangeMood("Alice", "Upset")}
Mike: Jongen dit ga je niet vol houden. Je school en werk gaan keihard achteruit.
Mike: Je slaapt minder door al die late diensten en je leeft bijna alleen maar op energy drinks. Dit is niet goed.
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Upset")}
Steve: maar ik wil zo graag mee...
{ChangeMood("Player", "Uncomfortable")}
{ChangeMood("Alice", "Crying")}
Mike: Ik heb wel een ander idee waardoor je wat sneller geld kan krijgen. Dan kun je in ieder geval wat minder werken.
{ChangeMood("Alice", "Serious")}
{ChangeMood("Player", "Sad")}
Steve: Echt?
{ChangeMood("Alice", "Crying")}
{ChangeMood("Player", "Upset")}
Mike: Wist je dat je belasting kan terugvragen over je loon?

{ChangeMood("Player", "Fine")}
Steve: nee. Dat is wel super chill tho!
{ChangeMood("Alice", "Crying")}
{ChangeMood("Player", "Sad")}
Mike: Ik kan je niet beloven dat het heel veel is, maar dat ligt eraan over hoeveel jaar je terugvraagt.
Mike: Maareh, ik ga jou nu naar huis sturen, kom morgenavond maar langs tegen 8 uur dan regelen we het even.
      
Mike: Ik stuur je wel een lijstje wat je mee moet nemen. Goed slapen vanavond ja?
{ChangeMood("Player", "Surprised")}
{ChangeMood("Alice", "Serious")}
steve: Zal ik doen! Werk ze! 
{ChangeMood("Alice", "Crying")}
mike: Yow!
  {HideCharacter("Alice")}    
  {HideCharacter("Player")}
 Druk op volgende.
