using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Input your grade percentage(number only): ");
        string gradeString = Console.ReadLine();
        int newGrade = int.Parse(gradeString);
        if (newGrade !< 90){
            if (newGrade !< 80){
                if (newGrade !<70){
                    if (newGrade !< 65){
                        Console.WriteLine("Try harder next time, You got E/F");
                    }else{
                        if (newGrade >= 67){
                            Console.WriteLine("Try harder next time, You got D+");
                        }else if(newGrade >= 65){
                            Console.WriteLine("Try harder next time, You got D");
                        }
                    }
                }
        //--- 70 PLUS GRADE ---        
                else{
                    if (newGrade >= 77){
                        Console.WriteLine("Congratulations you got C+!");
                    }else if(newGrade >= 73){
                        Console.WriteLine("Congratulations you got C!");
                    }else{
                        Console.WriteLine("Congratulations you got C-");
                    }
                }
        //--- 80 PLUS GRADE ---
            }else{
                if (newGrade >= 87){
                    Console.WriteLine("Congratulations you got B+!");
                }else if(newGrade >= 83){
                    Console.WriteLine("Congratulations you got B!");
                }else{
                    Console.WriteLine("Congratulations you got B-");
                }
            }
        //--- 90 PLUS GRADE ---
        }
        else{
            if (newGrade >= 97){
                Console.WriteLine("Congratulations you got A+!");
            }else if(newGrade >= 93){
                Console.WriteLine("Congratulations you got A!");
            }else{
                Console.WriteLine("Congratulations you got A-");
            }
        }
    
    }
}