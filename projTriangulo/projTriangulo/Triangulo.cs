using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTriangulo
{
    internal class Triangulo
    {
        private int l1;
        private int l2;
        private int l3;
        private int tipo; // 0 - NFT, 1 - EQ, 2 - IS, 3 - ES
        public Triangulo()
        {
            this.l1 = 0;
            this.l2 = 0;
            this.l3 = 0;
        }

        public Triangulo(int l1,int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public void setL1(int l1)
        {
            this.l1 = l1;
        }

        public void setL2(int l2)
        {
            this.l2 = l2;
        }
        public void setL3(int l3)
        {
            this.l3 = l3;
        }

        public int getL1()
        {
            return this.l1;
        }
        public int getL2()
        {
            return this.l2;
        }
        public int getL3()
        {
            return this.l3;
        }

        public int getTipo()
        {
            return this.tipo;
        }

        public void classificar()
        {
            if (this.l1 + this.l2 > this.l3 &&
                this.l1 + this.l3 > this.l2 &&
                this.l2 + this.l3 > this.l1)
                if (this.l1 == this.l2 && this.l1 == this.l3)
                    this.tipo = 1;
                else
                    if (this.l1 == this.l2 || this.l1 == this.l3 || this.l2 == this.l3)
                    this.tipo = 2;
                else
                    this.tipo = 3;
            else
                this.tipo = 0;
        }

    }
}
