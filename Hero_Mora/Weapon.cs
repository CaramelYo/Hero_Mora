using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Mora
{
    class Weapon
    {
        public Weapon(int weapon_num)
        {
            init(weapon_num);
        }

        public Weapon(string s)
        {
            int t = -1;
            try
            {
                t = int.Parse(s);
            }
            catch
            {
                Console.WriteLine("輸入武器不是整數，故武器隨機");
                t = weapon_count;
            }

            if (t == weapon_count)
                t = r.Next(0, weapon_count);

            init(t);
        }

        void init(int num)
        {
            img = new Bitmap(1, num);

            switch (num)
            {
                case 0:
                    // sword => paper
                    attack_mode = new int[5] { 0, 0, 0, 1, 2 };
                    break;
                case 1:
                    // hammer => stone
                    attack_mode = new int[5] { 0, 1, 1, 1, 2 };
                    break;
                case 2:
                    // spear => scissors
                    attack_mode = new int[5] { 0, 1, 2, 2, 2 };
                    break;
                default:
                    Console.WriteLine("weapon_num is out of range");
                    Console.Read();
                    break;
            }
        }

        public Bitmap Img
        {
            get { return img; }
        }

        public int[] Attack_mode
        {
            get { return attack_mode; }
        }

        Bitmap img;

        int[] attack_mode;

        public static Random r;

        //public static string[] weapon_symbol = new string[3] { "sword", "hammer", "spear" };
        public static string[] weapon_symbol = new string[3] { "長劍", "大錘", "長矛" };
        public static int weapon_count = 3;
        public static int attack_mode_count = 5;
    }
}
