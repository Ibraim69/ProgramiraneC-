using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Rnumber
    {
        private int chislitel;
        private int znamenatel;
        public int Chislitel
        {
            set
            {
                chislitel = value;
            }

            get
            {
                return chislitel;
            }
        }
        public int Znamenatel
        {
            set
            {
                if (value == 0)
                    throw new ArgumentException("znamenatelq ne moje da bude 0");
                znamenatel = value;
            }


            get
            {
                return znamenatel;
            }
        }
        Rnumber(int chislitel, int znamenatel)
        {
            this.Chislitel = chislitel;
            this.Znamenatel = znamenatel;
        }

        public Rnumber() : this(0, 1)
        {

        }
        public override string ToString()
        {
            return Chislitel+"/"+Znamenatel;
        }
        public Rnumber Add(Rnumber rn)
        {
        int chi;
        int z;
        chi = this.chislitel* rn.znamenatel + rn.chislitel* this.znamenatel;
            z = this.znamenatel * rn.znamenatel;
            return new Rnumber(chi, z);
    }
    public Rnumber substract(Rnumber rn)
    {
        int ch;
        int z;
        ch = this.chislitel * rn.Znamenatel - rn.Chislitel * this.znamenatel;
        z = this.znamenatel * rn.Znamenatel;
            return new Rnumber(ch, z);
            }
    public Rnumber Multiply(Rnumber rn)
    {
        int ch;
        int z;
        ch = this.chislitel * rn.Chislitel;
        z = this.znamenatel * rn.znamenatel;
        return new Rnumber(ch, z);
    }
    public Rnumber Devide(Rnumber rn)
    {
        int ch;
        int z;
        ch = this.chislitel * rn.Znamenatel;
        z = this.znamenatel * rn.Chislitel;
        return new Rnumber(ch, z);
    }





}
}
