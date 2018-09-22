using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Mora
{
    class Character
    {
        public Character(string name, int img_num, int weapon_num)
        {
            this.name = name;

            img = new Bitmap(0, img_num);
            wp = new Weapon(weapon_num);
            r = new Random();
        }

        public int attack()
        {
            return wp.Attack_mode[r.Next(0, Weapon.attack_mode_count)];
        }

        public Bitmap Img
        {
            get { return img; }
        }

        public Weapon Wp
        {
            get { return wp; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Bitmap img;
        Weapon wp;
        Random r;

        string name;
    }
}
