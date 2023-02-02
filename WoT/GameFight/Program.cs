using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

interface BattleMachine
{
    int Shoot();
    void TakeDMG(int DMG_);
    void PrintStats();
    void PrintHP();
    void PrintMachine();
}
class Machine_Team_1 : BattleMachine
{
    public int HP;
    public int HP_NOW;
    public int DMG;
    public double CRT_DMG;
    public int CRT_RATE;
    public int DEF;
    public int EV;
    public Machine_Team_1()
    {
        int Rand_HP = new Random().Next(500, 1200);
        HP = Rand_HP;
        HP_NOW = HP;
        int Rand_DMG = new Random().Next(50, 150);
        DMG = Rand_DMG;
        double Rand_CRT_DMG = new Random().NextDouble() * (3.0 - 1.0) + 1.0;
        CRT_DMG = Rand_CRT_DMG;
        int Rand_CRT_RATE = new Random().Next(0, 33);
        CRT_RATE = Rand_CRT_RATE;
        int Rand_DEF = new Random().Next(0, 25);
        DEF = Rand_DEF;
        int Rand_EV = new Random().Next(0, 10);
        EV = Rand_EV;
    }
    public void PrintHP()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("                   "+"HP: " + HP_NOW + " / " + HP);
        Console.ResetColor();
    }
   public void PrintHP_Line()
    {
        Console.Write("  ");        
        int line = HP_NOW/(HP / 100);
        for (int i = 0; i < 50; i++)
        {
            if (i < line / 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("|");
            }
            if (i > line / 2 || HP_NOW == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
            }
        }
        
        Console.ResetColor();
    }

    public void PrintMachine()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("                       ▄▄▄▄▄");
        
        Console.ResetColor();
    }
    public void PrintMachine2()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
       
        Console.Write("                  l  ▄████████▄▄▄▄▄▄▄▄▄▄");
       
        Console.ResetColor();
    }
    public void PrintMachine3()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        
        Console.Write("                  ███████████████");
       
        Console.ResetColor();
    }
    public void PrintMachine4()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        
        Console.Write("                  \\o▲o▲o▲o▲o▲o▲o/");
        Console.ResetColor();
    }

    public void PrintStats()
    {
        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("   Крит урон: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("x");
        
        Console.Write(Math.Round(CRT_DMG, 2));
        Console.ResetColor();

    }
    public void PrintStats2()
    {

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("   Шанс крит урона: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(CRT_RATE+"%");
        Console.ResetColor();
        if (CRT_RATE < 10)
        {
            Console.Write(" ");
        }
    }
    public void PrintStats3()
    {

        Console.ForegroundColor = ConsoleColor.Blue;

        Console.Write("   Шанс уворота: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(EV + "%");
        Console.ResetColor();
    }
    public void PrintStats4()
    {

        Console.ForegroundColor = ConsoleColor.Blue;
        
        Console.Write("   Защита: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(DEF + "%");
        Console.ResetColor();
        if (DEF < 10)
        {
            Console.Write(" ");
        }
    }

    public int Shoot()
    {
        int Rand_DMG = new Random().Next(50, 150);
        DMG = Rand_DMG;
         int Rand_CRT_or_NOCRT = new Random().Next(0, 100);


        if (Rand_CRT_or_NOCRT <= CRT_RATE)
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("BLUE TEAM: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("КРИТ! ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Нанесено: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(DMG);
            Console.ResetColor();
            return (int)(DMG * CRT_DMG);
            Console.Write("");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("BLUE TEAM: ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Нанесено: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(DMG);
            Console.ResetColor();
            Console.Write("");
            return DMG;
        }



    }
    public void TakeDMG(int DMG_)
    {
        int EV_ = new Random().Next(0, 100);
        if (EV_ <= EV)
        {
            Console.ForegroundColor = ConsoleColor.Blue; Console.Write("BLUE TEAM: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("УВОРОТ!");
            Console.Write("");
            Console.ResetColor();
            return;
        }
        double DEF_DMG = ((double)DMG_ / 100) * DEF;
        
        DMG_ -= (int)DEF_DMG;
        HP_NOW -= DMG_;
        Console.ForegroundColor = ConsoleColor.Blue; Console.Write("BLUE TEAM: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Получено урона: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(DMG_);
        Console.Write("");

        Console.ResetColor();
        if (HP_NOW < 0)
        {
            HP_NOW = 0;
        }
    }
}
class Machine_Team_2 : BattleMachine
{
    public int HP;
    public int HP_NOW;
    public int DMG;
    public double CRT_DMG;
    public int CRT_RATE;
    public int DEF;
    public int EV;
    public Machine_Team_2()
    {
        int Rand_HP = new Random().Next(500, 1200);
        HP = Rand_HP;
        HP_NOW = HP;
        int Rand_DMG = new Random().Next(50, 150);
        DMG = Rand_DMG;
        double Rand_CRT_DMG = new Random().NextDouble() * (3.0 - 1.0) + 1.0;
        CRT_DMG = Rand_CRT_DMG;
        int Rand_CRT_RATE = new Random().Next(0, 33);
        CRT_RATE = Rand_CRT_RATE;
        int Rand_DEF = new Random().Next(0, 25);
        DEF = Rand_DEF;
        int Rand_EV = new Random().Next(0, 10);
        EV = Rand_EV;
    }
    public void PrintHP()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                                       "+"HP: " + HP_NOW + " / " + HP);
        Console.ResetColor();
    }
    public void PrintHP_Line()
    {

        int line = HP_NOW / (HP / 100);
        Console.Write("               ");
        for (int i = 0; i < 50; i++)
        {
            if (i < line / 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("|");
            }
            if (i > line / 2 || HP_NOW == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("|");
            }
        }
        Console.WriteLine();
        Console.ResetColor();
    }

    public void PrintMachine()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("                                                                ▄▄▄▄▄");
       
        Console.ResetColor();
    }
    public void PrintMachine2()
    {
        Console.ForegroundColor = ConsoleColor.Red;
       
        Console.WriteLine("                                        ▄▄▄▄▄▄▄▄▄▄████████▄  l");
       
        Console.ResetColor();
    }
    public void PrintMachine3()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        
        Console.WriteLine("                                                      ███████████████");
       
        Console.ResetColor();
    }
    public void PrintMachine4()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
         
        Console.WriteLine("                                                      \\o▲o▲o▲o▲o▲o▲o/");
        Console.ResetColor();
    }

    public void PrintStats()
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("                                                 Крит урон: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("x");
        Console.WriteLine(Math.Round(CRT_DMG, 2));
        Console.ResetColor();

    }
    public void PrintStats2()
    {

        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("                                             Шанс крит урона: ");
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(CRT_RATE + "%");
        Console.ResetColor();
    }
    public void PrintStats3()
    {

        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("                                                 Шанс уворота: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(EV + "%");
        Console.ResetColor();
    }
    public void PrintStats4()
    {

        Console.ForegroundColor = ConsoleColor.Red;

        Console.Write("                                                      Защита: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(DEF + "%");
        Console.ResetColor();
    }

    public int Shoot()
    {
        int Rand_DMG = new Random().Next(50, 150);
        DMG = Rand_DMG;
        int Rand_CRT_or_NOCRT = new Random().Next(0, 100);

        if (Rand_CRT_or_NOCRT <= CRT_RATE)
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("RED TEAM: ");



            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write("КРИТ! ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Нанесено: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(DMG);
            Console.ResetColor();
            Console.Write("");
            return (int)(DMG * CRT_DMG);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; Console.Write("RED TEAM: ");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write("Нанесено: ");
            Console.ForegroundColor = ConsoleColor.DarkRed; Console.Write(DMG);
            Console.ResetColor();
            Console.Write("");
            return DMG;
        }
    }

   
    public void TakeDMG(int DMG_)
    {
        int EV_ = new Random().Next(0, 100);
        if (EV_ <= EV)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("RED TEAM: ");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("УВОРОТ!");
            Console.Write("");
            Console.ResetColor();
            return;
        }
        double DEF_DMG = ((double)DMG_ / 100) * DEF;
        DMG_ -= (int)DEF_DMG;
        HP_NOW -= DMG_;
        Console.ForegroundColor = ConsoleColor.Red;
        

        Console.Write("RED TEAM: ");
        Console.Write("Получено урона: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(DMG_);
        Console.Write("");
        Console.ResetColor();
        if (HP_NOW < 0)
        {
            HP_NOW = 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        START:
        Machine_Team_1 Tem_1_First = new Machine_Team_1();
        Machine_Team_2 Tem_2_First = new Machine_Team_2();
        int WhoShoot =  new Random().Next(0, 10);
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("          __          ______  _____  _      _____       ____  ______   _______       _   _ _  __ _____ ");
        Console.WriteLine("          \\ \\        / / __ \\|  __ \\| |    |  __ \\     / __ \\|  ____| |__   __|/\\   | \\ | | |/ // ____|");
        Console.WriteLine("           \\ \\  /\\  / | |  | | |__) | |    | |  | |   | |  | | |__       | |  /  \\  |  \\| | ' /| (___  ");
        Console.WriteLine("            \\ \\/  \\/ /| |  | |  _  /| |    | |  | |   | |  | |  __|      | | / /\\ \\ | . ` |  <  \\___ \\ ");
        Console.WriteLine("             \\  /\\  / | |__| | | \\ \\| |____| |__| |   | |__| | |         | |/ ____ \\| |\\  | . \\ ____) |");
        Console.WriteLine("              \\/  \\/   \\____/|_|  \\_|______|_____/     \\____/|_|         |_/_/    \\_|_| \\_|_|\\_|_____/ ");
        
        Console.WriteLine("");
        Console.WriteLine("                                                press any button");
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
        if (WhoShoot %2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                              BLUE TEM START FIRST");
            Console.WriteLine("");
            Console.WriteLine("                                            press any button for start");
            Console.ReadKey(); 
            Console.Clear();
            Console.ResetColor();
        }
        if (WhoShoot % 2 != 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                              RED TEAM START FIRST");
            Console.WriteLine("");
            Console.WriteLine("                                            press any button for start");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        int Blue = 0;
        int Red = 0;
        while (true)
        {

            Console.Clear(); 
            if (WhoShoot % 2 == 0)
            {
                Console.WriteLine("");
              
                Console.Write("   "); int DMG_P1 = Tem_1_First.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_2_First.TakeDMG(DMG_P1);
                if (Tem_2_First.HP_NOW == 0)
                {
                    Blue++;
                    break;
                }

            }
            if (WhoShoot % 2 != 0)
            {
                
                Console.WriteLine("");
                Console.Write("   "); int DMG_P2 = Tem_2_First.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_1_First.TakeDMG(DMG_P2);
                if (Tem_1_First.HP_NOW == 0)
                {
                    Red++;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            
            Console.WriteLine("                                                      СЧЕТ: " + Blue + ":" + Red);
            Console.WriteLine("                                                      BATTLE # 1");
            Console.WriteLine("");
            Tem_1_First.PrintHP_Line(); Tem_2_First.PrintHP_Line();
            Tem_1_First.PrintHP(); Tem_2_First.PrintHP();
            Console.WriteLine();
            Tem_1_First.PrintMachine(); Tem_2_First.PrintMachine();
            Tem_1_First.PrintMachine2(); Tem_2_First.PrintMachine2();
            Tem_1_First.PrintMachine3(); Tem_2_First.PrintMachine3();
            Tem_1_First.PrintMachine4(); Tem_2_First.PrintMachine4();
            Console.WriteLine();
            Tem_1_First.PrintStats(); Tem_2_First.PrintStats();
            Tem_1_First.PrintStats2(); Tem_2_First.PrintStats2();
            Tem_1_First.PrintStats3(); Tem_2_First.PrintStats3();
            Tem_1_First.PrintStats4(); Tem_2_First.PrintStats4();
           
            
            Console.ReadKey();
            
            WhoShoot++;
        }

        Machine_Team_1 Tem_1_Scnd = new Machine_Team_1();
        Machine_Team_2 Tem_2_Scnd = new Machine_Team_2();
         WhoShoot = new Random().Next(0, 10);
        
        while (true)
        {

            Console.Clear();
            if (WhoShoot % 2 == 0)
            {
               
                Console.WriteLine("");
                Console.Write("   "); int DMG_P1 = Tem_1_Scnd.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_2_Scnd.TakeDMG(DMG_P1);
                if (Tem_2_Scnd.HP_NOW == 0)
                {
                    Blue++;
                    
                    break;
                }

            }
            if (WhoShoot % 2 != 0)
            {
                
                Console.WriteLine("");
                Console.Write("   "); int DMG_P2 = Tem_2_Scnd.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_1_Scnd.TakeDMG(DMG_P2);
                if (Tem_1_Scnd.HP_NOW == 0)
                {
                    Red++;
                    
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("                                                      СЧЕТ: " + Blue + ":" + Red);
            Console.WriteLine("                                                      BATTLE # 2");
            Console.WriteLine("");
            Tem_1_Scnd.PrintHP_Line(); Tem_2_Scnd.PrintHP_Line();
            Tem_1_Scnd.PrintHP(); Tem_2_Scnd.PrintHP();
            Console.WriteLine();
            Tem_1_Scnd.PrintMachine(); Tem_2_Scnd.PrintMachine();
            Tem_1_Scnd.PrintMachine2(); Tem_2_Scnd.PrintMachine2();
            Tem_1_Scnd.PrintMachine3(); Tem_2_Scnd.PrintMachine3();
            Tem_1_Scnd.PrintMachine4(); Tem_2_Scnd.PrintMachine4();
            Console.WriteLine();
            Tem_1_Scnd.PrintStats(); Tem_2_Scnd.PrintStats();
            Tem_1_Scnd.PrintStats2(); Tem_2_Scnd.PrintStats2();
            Tem_1_Scnd.PrintStats3(); Tem_2_Scnd.PrintStats3();
            Tem_1_Scnd.PrintStats4(); Tem_2_Scnd.PrintStats4();

        
            Console.ReadKey();
            WhoShoot++;
        }
        if (Blue == 2)
        {
            goto WINBLUE;
        }
        if (Red == 2)
        {
            goto WINRED;
        }
        Machine_Team_1 Tem_1_3rd = new Machine_Team_1();
        Machine_Team_2 Tem_2_3rd = new Machine_Team_2();
        WhoShoot = new Random().Next(0, 10);

        while (true)
        {

            Console.Clear();
            if (WhoShoot % 2 == 0)
            {
              
                Console.WriteLine("");
                Console.Write("   "); int DMG_P1 = Tem_1_3rd.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_2_3rd.TakeDMG(DMG_P1);
                if (Tem_2_3rd.HP_NOW == 0)
                {
                    Blue++;
                    break;
                }

            }
            if (WhoShoot % 2 != 0)
            {
         
                Console.WriteLine("");
                Console.Write("   "); int DMG_P2 = Tem_2_3rd.Shoot();
                Console.WriteLine("");
                Console.Write("   "); Tem_1_3rd.TakeDMG(DMG_P2);
                if (Tem_1_3rd.HP_NOW == 0)
                {
                    Red++;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.WriteLine("                                                      СЧЕТ: " + Blue + ":" + Red);
            Console.WriteLine("                                                      BATTLE # 3");
            Console.WriteLine("");
            Tem_1_3rd.PrintHP_Line(); Tem_2_3rd.PrintHP_Line();
            Tem_1_3rd.PrintHP(); Tem_2_3rd.PrintHP();
            Console.WriteLine();
            Tem_1_3rd.PrintMachine(); Tem_2_3rd.PrintMachine();
            Tem_1_3rd.PrintMachine2(); Tem_2_3rd.PrintMachine2();
            Tem_1_3rd.PrintMachine3(); Tem_2_3rd.PrintMachine3();
            Tem_1_3rd.PrintMachine4(); Tem_2_3rd.PrintMachine4();
            Console.WriteLine();
            Tem_1_3rd.PrintStats(); Tem_2_3rd.PrintStats();
            Tem_1_3rd.PrintStats2(); Tem_2_3rd.PrintStats2();
            Tem_1_3rd.PrintStats3(); Tem_2_3rd.PrintStats3();
            Tem_1_3rd.PrintStats4(); Tem_2_3rd.PrintStats4();

           
            Console.ReadKey();
            WhoShoot++;
        }

    WINBLUE:
    WINRED:
        if ( Blue > Red)
        {
        
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                 ____  _     _    _ ______   _______ ______          __  __  __          _______ _   _ ");
            Console.WriteLine("                |  _ \\| |   | |  | |  ____| |__   __|  ____|   /\\   |  \\/  | \\ \\        / |_   _| \\ | |");
            Console.WriteLine("                | |_) | |   | |  | | |__       | |  | |__     /  \\  | \\  / |  \\ \\  /\\  / /  | | |  \\| |");
            Console.WriteLine("                |  _ <| |   | |  | |  __|      | |  |  __|   / /\\ \\ | |\\/| |   \\ \\/  \\/ /   | | | . ` |");
            Console.WriteLine("                | |_) | |___| |__| | |____     | |  | |____ / ____ \\| |  | |    \\  /\\  /   _| |_| |\\  |");
            Console.WriteLine("                |____/|______\\____/|______|    |_|  |______/_/    \\_|_|  |_|     \\/  \\/   |_____|_| \\_|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            goto START;
        }
        if (Red > Blue)
        {
        
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                 _____  ______ _____    _______ ______          __  __  __          _______ _   _ ");
            Console.WriteLine("                |  __ \\|  ____|  __ \\  |__   __|  ____|   /\\   |  \\/  | \\ \\        / |_   _| \\ | |");
            Console.WriteLine("                | |__) | |__  | |  | |    | |  | |__     /  \\  | \\  / |  \\ \\  /\\  / /  | | |  \\| |");
            Console.WriteLine("                |  _  /|  __| | |  | |    | |  |  __|   / /\\ \\ | |\\/| |   \\ \\/  \\/ /   | | | . ` |");
            Console.WriteLine("                | | \\ \\| |____| |__| |    | |  | |____ / ____ \\| |  | |    \\  /\\  /   _| |_| |\\  |");
            Console.WriteLine("                |_|  \\_|______|_____/     |_|  |______/_/    \\_|_|  |_|     \\/  \\/   |_____|_| \\_|");



            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadKey();
            Console.Clear();
            goto START;
        }



    }
}

