class Villkor
{


  public static void Main(String[] args)
  {
    Console.Clear();   // rensar consolen

    // villkor , conditions

    Console.WriteLine(1 + 1 == 2);  // == jämnför
    String namn = "Kung";
    Console.WriteLine("kung" == namn);  // == jämnför med string
    int age2 = 18;
    Console.WriteLine((false == false) + " bool jämförelse");  // == jämnför med bool


    Console.WriteLine(age2 > 17); // större än
    Console.WriteLine(17 < 100); // mindre än

    Console.WriteLine(18 >= 18); //större än eller likamed

    bool svar2 = 18 >= 18;
    Console.WriteLine(svar2 + " boolvariabel");
    Console.WriteLine((18 <= 18) + "  <= "); //mindre än eller likamed


    Console.WriteLine(1 != -35); // inte likamed



    // if satser , if statements
    int age3 = 12;

    /* System.Console.WriteLine("Vad är 5 x 5 ?");
    int tal =  int.Parse( Console.ReadLine() )  ;

        if (tal == 5*5)
        { // sant koder
          System.Console.WriteLine("RÄTT!!!");
        }
        else
        { //false koder
          System.Console.WriteLine("FEL!!!");
        } */



    Console.WriteLine("vilken titel har du? (drottning/prinsessa eller adel)");
    string rawInput = Console.ReadLine();
    string titel = rawInput.ToLower();
    Console.WriteLine("raw: " + rawInput);
    Console.WriteLine("lowered case: " + titel);

/*     if (titel == "drottning")
    { // sant koder
      Console.WriteLine("  Du är rikets härskarina!! ");
    }
    else
    { //false koder
      Console.WriteLine("Du är ingen Drottning");
          if (titel == "prinsessa")  // nästing
          { // sant koder
            Console.WriteLine("  Du är en prinsessa!! "); 
          }
          else
          { //false koder
            Console.WriteLine("Du är ingen prinsessa");
              if (titel == "adel")  // nästing
                { // sant koder
                  Console.WriteLine("     Du är en adel!! "); 
                }
                else
                { //false koder
                  Console.WriteLine("     Du är pleb  ");
                }
          }
    }
 */

/*     if (titel == "drottning")
      Console.WriteLine("Du är rikets härskarina!! ");
    else if (titel == "prinsessa")  // nästing
      Console.WriteLine(" Du är en prinsessa!! ");
    else if (titel == "adel")  // nästing
      Console.WriteLine("  Du är en adel!! ");
    else
      Console.WriteLine("   Du är pleb  ");
 */

switch (titel)
{
  case "drottning":
        Console.WriteLine(" härskarina!! ");
  break;
  case "prinsessa":
        Console.WriteLine(" prinsessa");
  break;
  case "adel":
        Console.WriteLine(" adel!!");
  break;
  default:
        Console.WriteLine("Du är pleb");
  break;
}




    /*
        // ReadLine
        System.Console.WriteLine("Skriv din ålder:");
        // avbryta programmet med ctrl + C  cancel

        String svar; //variabel svar
        svar = Console.ReadLine(); //pausar o väntar på input , tryck på enter för confim
        //svar = Console.ReadLine() ?? "--default ifall den är tom--";
        Console.WriteLine("Du skrev:" + svar);

        int age;
        age = int.Parse(svar);
        Console.WriteLine("den parsade testen till nummer:" + age);

        if (age >= 18)
        { // sant koder
          System.Console.WriteLine("du är vuxen");
        }
        else
        { //false koder
          System.Console.WriteLine("du är ett barn");
        }
        */
  }


}