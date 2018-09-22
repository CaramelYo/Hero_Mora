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
            img = new Bitmap(1, weapon_num);

            switch (weapon_num)
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

        //public static string[] weapon_symbol = new string[3] { "sword", "hammer", "spear" };
        public static string[] weapon_symbol = new string[3] { "長劍", "大錘", "長毛" };
        public static int weapon_count = 3;
        public static int attack_mode_count = 5;
    }
}
