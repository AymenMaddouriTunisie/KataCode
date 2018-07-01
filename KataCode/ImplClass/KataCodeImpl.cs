using KataCode.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KataCode.ImplClass
{
    class KataCodeImpl : IkataCode
    {
        public String compute(String number)
        {
            int countNumberTrois = 0;
            int countNumberCinq = 0;
            int countNumberSept = 0;
            int countNumberZero = 0;

            for (int i = 0; i < number.Length; i++)
            {

                if (Convert.ToInt32(number[i].ToString()) == 3)
                {
                    countNumberTrois = countNumberTrois + 1;
                }
                if (Convert.ToInt32(number[i].ToString()) == 5)
                    countNumberCinq = countNumberCinq + 1;
                if (Convert.ToInt32(number[i].ToString()) == 7)
                    countNumberSept = countNumberSept + 1;
                if (Convert.ToInt32(number[i].ToString()) == 0)
                {
                    countNumberZero = countNumberZero + 1;

                }
            }
           
            int x=0;
            x = int.Parse(number);
             //here 
             if (x % 3 == 0 && x % 5 == 0 && x % 7 == 0)
            {

                {
                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrence = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;
                    String remplirChaine = string.Empty;

                    for (int i = 0; i < number.Length; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {
                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                        }

                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }



                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "FooBarQix" + remplirChaine;
                    return affich;
                }
                //here2
                


            }
             else if(x%3==0&&x%5==0)
             {
                 {
                     //int compteurreception;
                     String affich = string.Empty;
                     String affichOccurrence = string.Empty;
                     String affichOccurrenceZero = string.Empty;
                     String affichOccurrenceTrois = string.Empty;
                     String affichOccurrenceCinq = string.Empty;
                     String affichOccurrenceSept = string.Empty;
                     String remplirChaine = string.Empty;

                     for (int i = 0; i < number.Length; i++)
                     {
                         //compteurreception = compteur(number);

                         if (position(number) != -1)
                         {
                             affichOccurrenceZero = number.Replace("0", "*");
                             affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                         }

                         else
                         {
                             affichOccurrenceTrois = number.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                         }



                     }
                     for (int i = 0; i < affichOccurrence.Length; i++)
                     {

                         if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r')
                             remplirChaine = remplirChaine + affichOccurrence[i];
                     }
                     affich = "\n" + "le resultat est : " + number + "  ==> " + "FooBar" + remplirChaine;
                     return affich;
                 }



             }
             else if (x % 3 == 0 && x % 7 == 0)
             {
                 {
                     //int compteurreception;
                     String affich = string.Empty;
                     String affichOccurrence = string.Empty;
                     String affichOccurrenceZero = string.Empty;
                     String affichOccurrenceTrois = string.Empty;
                     String affichOccurrenceCinq = string.Empty;
                     String affichOccurrenceSept = string.Empty;
                     String remplirChaine = string.Empty;

                     for (int i = 0; i < number.Length; i++)
                     {
                         //compteurreception = compteur(number);

                         if (position(number) != -1)
                         {
                             affichOccurrenceZero = number.Replace("0", "*");
                             affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                         }

                         else
                         {
                             affichOccurrenceTrois = number.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                         }



                     }
                     for (int i = 0; i < affichOccurrence.Length; i++)
                     {

                         if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r')
                             remplirChaine = remplirChaine + affichOccurrence[i];
                     }
                     affich = "\n" + "le resultat est : " + number + "  ==> " + "FooQix" + remplirChaine;
                     return affich;
                 }



             }
             else if (x % 5 == 0 && x % 7 == 0)
             {
                 {
                     //int compteurreception;
                     String affich = string.Empty;
                     String affichOccurrence = string.Empty;
                     String affichOccurrenceZero = string.Empty;
                     String affichOccurrenceTrois = string.Empty;
                     String affichOccurrenceCinq = string.Empty;
                     String affichOccurrenceSept = string.Empty;
                     String remplirChaine = string.Empty;

                     for (int i = 0; i < number.Length; i++)
                     {
                         //compteurreception = compteur(number);

                         if (position(number) != -1)
                         {
                             affichOccurrenceZero = number.Replace("0", "*");
                             affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                         }

                         else
                         {
                             affichOccurrenceTrois = number.Replace("3", "Foo");
                             affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                             affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                         }



                     }
                     for (int i = 0; i < affichOccurrence.Length; i++)
                     {

                         if (affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                             remplirChaine = remplirChaine + affichOccurrence[i];
                     }
                     affich = "\n" + "le resultat est : " + number + "  ==> " + "BarQix" + remplirChaine;
                     return affich;
                 }



             }
            
            
            else if ((x % 3 == 0))
            {
                if (countNumberTrois != 0)
                {
                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrence = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;
                    String remplirChaine = string.Empty;

                    for (int i = 0; i < countNumberTrois; i++)
                    {
                        //compteurreception = compteur(number);
                       
                            if (position(number) != -1)
                            {
                                affichOccurrenceZero = number.Replace("0", "*");
                                affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                                affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                                affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                            }
                            
                            else
                            {
                                affichOccurrenceTrois = number.Replace("3", "Foo");
                                affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                                affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                            }
                                
                        
                          
                    }
                    for (int i = 0; i < affichOccurrence.Length;i++ )
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r'|| affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i]; 
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Foo" + remplirChaine;
                    return affich;
                }
                else
                {

                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String remplirChaine = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;
                    String affichOccurrence = string.Empty;

                    for (int i = 0; i < number.Length; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {
                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                            

                        }
                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                            

                        }
                        


                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Foo" + remplirChaine;
                    return affich;

                }
            }
            else if ((x % 5 == 0))
            {
                if (countNumberCinq != 0)
                {
                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrence = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String remplirChaine = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;

                    for (int i = 0; i < countNumberCinq; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {

                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }
                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }
                      


                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Bar" + remplirChaine;
                    return affich;
                }
                else
                {

                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String remplirChaine = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;
                    String affichOccurrence = string.Empty;

                    for (int i = 0; i < number.Length; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {
                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                            


                        }
                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }



                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Bar" + remplirChaine;
                    return affich;

                }

            }
            else if ((x % 7 == 0))
            {
                if (countNumberSept != 0)
                {
                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrence = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String remplirChaine = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;


                    for (int i = 0; i < countNumberSept; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {
                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");


                        }
                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }


                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Qix" + remplirChaine;
                    return affich;
                }
                else
                {

                    //int compteurreception;
                    String affich = string.Empty;
                    String affichOccurrenceZero = string.Empty;
                    String remplirChaine = string.Empty;
                    String affichOccurrenceTrois = string.Empty;
                    String affichOccurrenceCinq = string.Empty;
                    String affichOccurrenceSept = string.Empty;
                    String affichOccurrence = string.Empty;

                    for (int i = 0; i < number.Length; i++)
                    {
                        //compteurreception = compteur(number);

                        if (position(number) != -1)
                        {
                            affichOccurrenceZero = number.Replace("0", "*");
                            affichOccurrenceTrois = affichOccurrenceZero.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");
                            


                        }
                        else
                        {
                            affichOccurrenceTrois = number.Replace("3", "Foo");
                            affichOccurrenceCinq = affichOccurrenceTrois.Replace("5", "Bar");
                            affichOccurrence = affichOccurrenceCinq.Replace("7", "Qix");

                        }


                    }
                    for (int i = 0; i < affichOccurrence.Length; i++)
                    {

                        if (affichOccurrence[i] == 'F' || affichOccurrence[i] == 'o' || affichOccurrence[i] == '*' || affichOccurrence[i] == 'B' || affichOccurrence[i] == 'a' || affichOccurrence[i] == 'r' || affichOccurrence[i] == 'Q' || affichOccurrence[i] == 'i' || affichOccurrence[i] == 'x')
                            remplirChaine = remplirChaine + affichOccurrence[i];
                    }
                    affich = "\n" + "le resultat est : " + number + "  ==> " + "Qix" + remplirChaine;
                    return affich;

                }

            }
               
            else
            {
                
                
                
                if (number.Contains("7") && number.Contains("5") && number.Contains("3"))
                    return x + " ==> " + "QixBarFoo";
                else if (number.Contains("7") && number.Contains("3") && number.Contains("5"))
                    return x + " ==> " + "QixFooBar";
                else if (number.Contains("5") && number.Contains("7") && number.Contains("3"))
                    return x + " ==> " + "BarQixFoo";
                else if (number.Contains("5") && number.Contains("3") && number.Contains("7"))
                    return x + " ==> " + "BarFooQix";
                else if (number.Contains("3") && number.Contains("7") && number.Contains("5"))
                    return x + " ==> " + "FooQixBar";
                else if (number.Contains("3") && number.Contains("5") && number.Contains("7"))
                    return x + " ==> " + "FooBarQix";
                else if (number.Contains("7") && number.Contains("5"))
                    return x + " ==> " + "QixBar";
                else if (number.Contains("5") && number.Contains("7"))
                    return x + " ==> " + "BarQix";
                else if (number.Contains("3") && number.Contains("7"))
                    return x + " ==> " + "FooQix";
                else if (number.Contains("5") && number.Contains("3"))
                    return x + " ==> " + "BarFoo";
                else if (number.Contains("3") && number.Contains("5"))
                    return x + " ==> " + "FooBar";
                else if (number.Contains("7"))
                    return x + " ==> " + "Qix";
                else if (number.Contains("5"))
                    return x + " ==> " + "Bar";
                else if (number.Contains("3"))
                    return x + " ==> " + "Foo";
                else if(number.Contains("0"))
                {
                    
                 return number + " ==> " + number.Replace("0", "*");

                }
                    
                
                    return x + " ==> " + x;

            }

        }

        public int position(String number)
        {
            int pos=-1;
           
            bool variableDeSortie = false;
           
            for (int i = 0; i < number.Length; i++)
            {
              

                if (Convert.ToInt32(number[i].ToString()) == 0 && variableDeSortie == false )
                {
                    pos = i;
                    variableDeSortie = true;
                    
                    
                }

            }
            return pos;
        }
        //public int compteur(String number)
        //{
        //    int compteur = 0;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (Convert.ToInt32(number[i].ToString()) == 0)
        //        {
        //            compteur++;

        //        }
        //    }
        //    return compteur;
        //}

    }
}
