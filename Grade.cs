using System;
public class Grade
{
    public int score;
    public string GradeInput ;
    public string Grade_Alphabet;
    
    public Grade(int score)
    {

        score = ConvertStringtoINt( PlsInput_Score());
        this.score = score;
        this.Grade_Alphabet = Grade_String(score);
    
    }
    public static string PlsInput_Score()
    {
       Console.Write("Pls input your score");
       return Console.ReadLine();
    }

    public static int ConvertStringtoINt(string Input_value)
    {
        if(int.TryParse(Input_value,out int number))
        {
            return number;
        }
        else throw new Exception("Pls input score again");
    }
    public static string Grade_String(int score)
    {
        if(score>100)throw new Exception("Pls input again");
        
        if(IsGradeA(score))
        {
            return "A";
        }
        else if(IsGradeBPlus(score))
        {
            return   "B";
        }
        else if(IsGradeBPlus(score))
        {
            return "B+";
        }
         else if(IsGradeB(score))
        {
            return "B";
        }
         else if(IsGradeCPlus(score))
        {
            return "C+";
        }
        else if(IsGradeC(score))
        {
            return "C";
        }
         else if(IsGradeDPlus(score))
        {
            return "D+";
        }
         else if(IsGradeD(score))
        {
            return "D";
        }
        else return "F";


    }
    
    public static bool IsGradeA(int score)
    {
        return score<=100&&score>=80;
    }
    public static bool IsGradeBPlus(int score)
    {
        return score<80&&score>=75;
    }
    public static bool IsGradeB(int score)
    {
        return score<75&&score>=70;
    }
    public static bool IsGradeCPlus(int score)
    {
        return score<70&&score>=65;
    }
     public static bool IsGradeC(int score)
    {
        return score<65&&score>=60;
    }
    public static bool IsGradeDPlus(int score)
    {
        return score<60&&score>=55;
    }
    public static bool IsGradeD(int score)
    {
        return score<55&&score>=50;
    }
   


    
    


}
