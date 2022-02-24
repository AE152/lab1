using System;

namespace lab1
{
    class Program
    {
        static void Main()
        {
;
            HW1.QueueTime(new int[] { 5, 3, 4 }, 1);

            HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
          
            HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
        }
    }
    public class HW1
    {
        public static long QueueTime( int[] customers, int n)
        {
            int time = 0;
            int pustie_kassi = 0;
            int people = customers.Length;

            int[] kassa = new int[n];      
            //заполняем кассы первыми людьми из очереди
            for (int k = 0; k < n; k++)
            {
                kassa[k] = customers[k];
            }
            int num_klienta = n; //номер первого человека который не у кассы
            bool flag = true; //если flag = false то люди в очереди закончились 
            
            if (n == people) //если покупателей столько же сколько касс, значит людей в очереди не осталось
                flag = false;
            
            while (pustie_kassi != n)
            {
                for (int m = 0; m < n; m++)
                {
                    kassa[m]--;
                   
                    if (kassa[m] == 0)   
                    {
                        if (!flag) //если клиенты закончились, то касса остается пустой
                            pustie_kassi++;
                        else       //если клиенты ещё есть, то ставим за кассу следующего 
                        {                                  
                            kassa[m] = customers[num_klienta];
                            num_klienta++;                                                        
                        }
                    }

                    if (num_klienta == people) //очередь закончилась
                    {
                        flag = false;
                    }
                }            
                time++;
            }            
            Console.WriteLine(time);
            return time;
        }
    }
}