using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Mora
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Weapon.r = r;
            Character.r = r;

            while (true)
            {
                Console.WriteLine("請輸入勇者的武器");
                Console.WriteLine("(武器種類共" + Weapon.weapon_count.ToString() + "種，0~" + (Weapon.weapon_count - 1).ToString()
                    + "為種類，輸入" + Weapon.weapon_count.ToString() + "為隨機)");
                Console.WriteLine("(直接輸入enter為離開)");

                string input = Console.ReadLine();

                if (input.Length == 0)
                {
                    Console.WriteLine("goodbye");
                    break;
                }
                
                // create a hero
                Character c0 = new Character("All Might", 0, new Weapon(input)); ;

                List<Bitmap> img_list = new List<Bitmap>();
                img_list.Add(c0.Img);
                img_list.Add(c0.Wp.Img);

                Console.WriteLine("請輸入萌絲塔的武器");
                input = Console.ReadLine();

                Character c1 = new Character("monster", 1, new Weapon(input));
                img_list.Add(c1.Wp.Img);
                img_list.Add(c1.Img);

                int result = 0, win_count = 0;

                while (true)
                {
                    // print c0 and c1
                    print_img_list(img_list);

                    // battle
                    do
                    {
                        int c0_a = c0.attack(), c1_a = c1.attack();
                        result = mora(c0_a, c1_a);
                        Console.WriteLine(c0.Name + "出" + mora_symbol[c0_a] + " " + c1.Name + "出" + mora_symbol[c1_a]);
                        Console.WriteLine(c0.Name + result_symbol[result]);
                    } while (result == 2);

                    if (result == 0)
                    {
                        ++win_count;

                        // regenerate a monster
                        img_list.RemoveRange(2, 2);
                        
                        c1 = new Character("monster", 1, new Weapon(r.Next(0, Weapon.weapon_count)));
                        img_list.Add(c1.Wp.Img);
                        img_list.Add(c1.Img);
                    }
                    else if (result == 1)
                        break;
                }

                Console.WriteLine("\n" + c0.Name + "勝場數為 : " + win_count.ToString() + "\n");
            }
        }

        static void print_img_list(List<Bitmap> l)
        {
            for (int y = 0; y < Bitmap.h; ++y)
            {
                string output = "";
                for (int i = 0; i < l.Count; ++i)
                    output += l[i].get_img_row(y);
                
                Console.WriteLine(output);
            }
        }

        static int mora(int c0, int c1)
        {
            return mora_rule[c0, c1];
        }

        static int[,] mora_rule = new int[3, 3]
        {
            // 0 => c0 win, 1 => c1 win, 2 => deuce
            // c1 paper, stone, scissors
            {2, 0, 1},
            {1, 2, 0},
            {0, 1, 2}
        };

        //string[] mora_symbol = new string[3] { "paper", "stone", "scissors" };
        static string[] mora_symbol = new string[3] { "布", "石頭", "剪刀" };
        static string[] result_symbol = new string[3] { "獲勝", "失敗", "平手" };
    }
}
