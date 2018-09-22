using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Mora
{
    class Bitmap
    {
        public Bitmap(int img_type, int img_num)
        {
            switch (img_type)
            {
                case 0:
                    // character type
                    switch (img_num)
                    {
                        case 0:
                            // hero
                            img = new string[]
                            {
                                "  *****    ",
                                "  *   *    ",
                                "  ***** *  ",
                                "    *  *  *",
                                "    * * *  ",
                                "    ***    ",
                                "    *      ",
                                "   * *     ",
                                "  *   *    ",
                                " *     *   ",
                                " *     *   "
                            };
                            break;
                        case 1:
                            // monster
                            img = new string[]
                            {
                                "           ",
                                "           ",
                                "      *    ",
                                "     *     ",
                                "     *     ",
                                "   *****   ",
                                " *** * *** ",
                                "***********",
                                " ********* ",
                                "           ",
                                "           "
                            };
                            break;
                        default:
                            Console.WriteLine("character img_num is out of range");
                            Console.Read();
                            break;
                    }
                    break;
                case 1:
                    // weapon type
                    switch (img_num)
                    {
                        case 0:
                            // sword
                            img = new string[]
                            {
                                "     *     ",
                                "   *   *   ",
                                "   *   *   ",
                                "   *   *   ",
                                "   *   *   ",
                                "   *   *   ",
                                " ********* ",
                                " ********* ",
                                "    ***    ",
                                "    ***    ",
                                "           "
                            };
                            break;
                        case 1:
                            // hammer
                            img = new string[]
                            {
                                "***********",
                                "***********",
                                "***********",
                                "    ***    ",
                                "    ***    ",
                                "    ***    ",
                                "    ***    ",
                                "    ***    ",
                                "    ***    ",
                                "    ***    ",
                                "           "
                            };
                            break;
                        case 2:
                            // spear
                            img = new string[]
                            {
                                "     *     ",
                                "    ***    ",
                                "   *****   ",
                                "  *******  ",
                                "     *     ",
                                "     *     ",
                                "     *     ",
                                "     *     ",
                                "     *     ",
                                "     *     ",
                                "           "
                            };
                            break;
                        default:
                            Console.WriteLine("weapon img_num is out of range");
                            Console.Read();
                            break;
                    }
                    break;
            }
        }

        public string get_img_row(int i)
        {
            return img[i];
        }

        public string[] Img
        {
            get { return img; }
        }

        string[] img;

        public static int weapon_img_count = 3;
        public static int character_img_count = 2;
        public static int h = 11;
        public static int w = 11;
    }
}
