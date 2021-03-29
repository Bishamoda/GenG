using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace G_Code_Generator
{
    static class SuccessValue
    {
        private static decimal _X;
        private static decimal _Z;
        private static decimal _nX;
        private static decimal _nZ;
        private static decimal _R;
        private static bool successX = false;
        private static bool successZ = false;
        private static bool successNX = false;
        private static bool successNZ = false;
        private static bool successNR = false;

        public static bool successR = false;

        private static bool successSpindel = false;
        private static decimal _value;


        public static bool NextValuesLine(string X, string Z)
        {
            successX = decimal.TryParse(X, out _X);
            successZ = decimal.TryParse(Z, out _Z);

            if (successX && successZ == true)
            {
                return true;
            }
            else
            {
                return false;
            }    
            
        }

        public static  bool CheckValuesG02(string nX, string nZ, string R)
        {
            successNX = decimal.TryParse(nX, out _nX);
            successNZ = decimal.TryParse(nZ, out _nZ);
            successNR = decimal.TryParse(R, out _R);

            if (successNX && successNZ && successNR == true)
            {

                if ((_nX - _X == -(_R)) && (Math.Abs(_nZ - _Z) == _R))
                {
                    successR = true;
                }
                else
                {
                    MessageBox.Show("Введен неправильный радиус", "Внимание", MessageBoxButtons.OK);
                }
            }
            else
            {
                successR = false;
            }

            return successR;

        }

        public static bool CheckValuesG03(string nX, string nZ, string R)
        {
            successNX = decimal.TryParse(nX, out _nX);
            successNZ = decimal.TryParse(nZ, out _nZ);
            successNR = decimal.TryParse(R, out _R);

            if (successNX && successNZ && successNR == true)
            {
                if ((_nX - _X == _R) && (Math.Abs(_nZ - _Z) == _R))
                {
                    successR = true;
                }
                else
                {
                    MessageBox.Show("Введен неправильный радиус", "Внимание", MessageBoxButtons.OK);
                }
                
            }
            else
            {
                successR = false;
            }

            return successR;
        }

        public static bool CheckValueShpindel(string shpindel)
        {
            successSpindel = decimal.TryParse(shpindel, out _value);

            if (successSpindel == true)
            {
                if (_value > 0 && _value <= 10000)
                {
                    return true;
                }
                else
                { 
                    return false; 
                }
                
            }
            else
            { 
                return false; 
            }
        }


        public static void InvalidData()
        {
            MessageBox.Show("Введены неверные данные", "Внимание", MessageBoxButtons.OK);
        }
    }
}
