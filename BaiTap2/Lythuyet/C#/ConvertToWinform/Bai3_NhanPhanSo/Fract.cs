using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_NhanPhanSo   // cac ham thuoc class nay dung de su ly voi phan so
{
    struct Fract    /// tao mot struct de luu phan so
    {
        double element;
        double sample;

        public double Element { get => element; set => element = value; }
        public double Sample { get => sample; set => sample = value; }
    }
    class FractProces
    {
        public Fract compactFract(Fract opt)   //ham nay dung de rut gon phan so
        {
            if (opt.Element == 0)
            {
                return opt;
            }
            if (opt.Element == opt.Sample)
            {
                opt.Element = 1; opt.Sample = 1;
                return opt;
            }
        FindCom:
            if (getDivesor(opt.Element, opt.Sample) != 1)
            {
                int commonDevisor = getDivesor(opt.Element, opt.Sample);
                opt.Element = opt.Element / commonDevisor;
                opt.Sample = opt.Sample / commonDevisor;
            }
            if (getDivesor(opt.Element, opt.Sample) != 1)
            {
                goto FindCom;
            }
            return opt;
        }
        public int getDivesor(double opt1, double opt2)  //ham nay dung de tim uoc chung cua hai so
        {
            for (int i = 2; i < Math.Min(Math.Abs(opt1), Math.Abs(opt2)) + 1; i++)
            {
                if (opt1 % i == 0 && opt2 % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }

}
