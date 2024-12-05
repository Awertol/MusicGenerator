Random generator = new Random(); //vytvoří generátor náhodných čísel
while(1+1 == 2) //podmínka co stále platí, nikdy neskončí
{
    int nahodnaFrekvence = generator.Next(37,2200); //frekvence zvuku mezi 37 a 2200 - nad to je to fuj:(
    int nahodnaDelka = generator.Next(100, 700); //délka mezi 100 a 700 (jsou to milisekundy)
    Console.Beep(nahodnaFrekvence, nahodnaDelka); //zapípá vygenerovanou frekvencí na vygenerovaný počet milisekund
    Console.WriteLine(nahodnaFrekvence + "Hz " + nahodnaDelka + "ms"); //vypíše proměnné (+ text s jednotkami)
}

