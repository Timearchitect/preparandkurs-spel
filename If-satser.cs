using System.Reflection.Metadata.Ecma335;

class Ifsatser
{



  public static void Main(String[] args)
  {



    Console.Clear();

    Console.WriteLine("hej");


    //negativ
    /*     int antal = 0;
        if ( antal < 0 && antal>5)
              {
                Console.WriteLine("utanför range");
              }
              else
              {
                Console.WriteLine("innanför range");
              } 
     */
    //positiv
    int antal = -1;
    if (-1 < antal && antal < 5)
      Console.WriteLine("INNAför range");
    else
      Console.WriteLine("utanför RANGE");


    //eller
    /*           if (false || false)
              {
                Console.WriteLine("YES");
              }
              else
              {
                Console.WriteLine("NO");
              } 
     */






    int age = 34;
    bool driversLicense = true;

    if (age >= 18 && driversLicense)
      Console.WriteLine("YES");
    else
      Console.WriteLine("NO");

    if (age >= 18 || driversLicense)
      Console.WriteLine("YES");
    else
      Console.WriteLine("NO");



    /*     if (age >= 18)
        {
          if (driversLicense)
            Console.WriteLine("YES");
          else
            Console.WriteLine("NO");
        }
        else
          Console.WriteLine("NO"); */



    // Arrayer  
    int i = 5;
    // index nr               0   1   2    3      
    int[] listaMedSiffror = { 1, 2, -3, 555 };
    Console.WriteLine(i);
    Console.WriteLine(listaMedSiffror[0]);


    string s = "hej";
    string[] arrayOfStrings = { "yo", "tjenare", "hello" };

    //                                    index        0    1    2   
    string[] emptyArrayOfStrings = new string[3]; // { "" ,"" , "" }
    emptyArrayOfStrings[0] = "hejsan";
    Console.WriteLine(emptyArrayOfStrings[0]);


// Console.WriteLine(s);
// Console.WriteLine(arrayOfStrings[0] +" "+ arrayOfStrings[1] +" "+ arrayOfStrings[2] );

Console.WriteLine(  age >= 18 ? "yes!!" : "no!!!" );

//Ternary operator
string svar = age >= 18 ? "yes!!T" : "no!!!T";
Console.WriteLine(svar);



if (age >= 18){
  Console.WriteLine("yes!!");
  Console.WriteLine("yes!!");
  Console.WriteLine("yes!!");
}
else 
  Console.WriteLine("no!!");




/*   
// C# funktioner
 public string alrik()
  {
    return "hejsan";
  }


// functioner js
   function alrik()
  {
    return "hejsan"
  } */

}
}