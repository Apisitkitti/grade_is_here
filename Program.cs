using System;
public class Grade
{
    int score;
    string GradeOutput ;
    public Grade(int score)
    {
        this.score = score;


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
            return "C";
        }

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
