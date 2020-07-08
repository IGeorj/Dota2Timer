using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Dota2Timer
{
    class Skill
    {
        private string _Name;

        public string Name
        {
            get { return this._Name; }
            set { this._Name = value; }
        }

        private BitmapImage _ImageData;

        public BitmapImage ImageData
        {
            get { return this._ImageData; }
            set { this._ImageData = value; }
        }

        private int[] _SkillCooldown;

        public int[] SkillCooldown
        {
            get { return this._SkillCooldown; }
            set { this._SkillCooldown = value; }
        }

    }
}
