using System;

public class Test{
    public static void Main(){
        
        // 元金均等返済
        
        double 借入総額 = 5000000;
        int 返済月数 = 60;
        double 年利 = 0.05;

        double 単純月割 = 借入総額 / 返済月数;

        double 利息総額 = 0;
        for (int i = 返済月数; i > 0; i--){
            
            double 借入残高 = 単純月割 * i;
            double 利息 = 借入残高 * 年利 / 12 * i;
            double 月割利息 = 利息 / i;
            利息総額 += 月割利息;
        }

        Console.WriteLine(Math.Ceiling(利息総額));
    }
}


public class Test2{
    public static void Main(){
        
        // 元利均等返済

        double 借入総額 = 5000000;
        int 返済月数 = 60;
        double 年利 = 0.05;
        double 月利 = 年利 / 12;

        double 返済月額 = ( 借入総額 * 月利 * Math.Pow(1 + 月利, 返済月数) ) / ( Math.Pow(1 + 月利, 返済月数) - 1 );

        double 返済総額 = 返済月額 * 返済月数;
        double 利息総額 = 返済総額 - 借入総額;

        Console.WriteLine(Math.Ceiling(利息総額));
    }
}
