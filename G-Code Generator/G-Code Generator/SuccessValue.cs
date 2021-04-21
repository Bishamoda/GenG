using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace G_Code_Generator
{
    static class SuccessValue
    {
        private static double _X;
        private static double _Z;
        private static double _nX;
        private static double _nZ;
        private static double _R;
        private static bool successNX = false;
        private static bool successNZ = false;
        private static bool successNR = false;
        public static bool successR = false;

        private static bool successSpindel = false;
        private static double _value;

        private static bool successL = false;
        private static bool successRUp = false;
        private static bool successRDown = false;
        private static bool successStartZ = false;
        public static double _fLength;
        public static double _fRadUp;
        public static double _fRadDown;
        public static double _startfZ;

        private static bool successSL = false;
        private static bool successSW = false;
        private static bool successSStartZ = false;
        public static double _sLength;
        public static double _sWidth;
        public static double _startSZ;

        private static bool successRL = false;
        private static bool successRW = false;
        private static bool successRStartZ = false;
        public static double _rLength;
        public static double _rWidth;
        public static double _startRZ;

        public static bool valueRectangle;
        public static bool valueFaska;
        public static bool valueSlot;

        public static void NextValues(double X, double Z)
        {
            _X = X;
            _Z = Z;
        }

        public static bool CheckValueFaska(string fL, string fRUp, string fRDown, string fSZ)
        {
            successL = double.TryParse(fL, out _fLength);
            successRUp = double.TryParse(fRUp, out _fRadUp);
            successStartZ = double.TryParse(fSZ, out _startfZ);
            successRDown = double.TryParse(fRDown, out _fRadDown);

            if (successL && successRUp && successRDown && successStartZ == true)
            {
                if ((_fLength <= 10000) && (_fRadUp <= 10000) && (_fRadDown <= 10000) && (_startfZ <= 10000) && (_fLength >= -10000) && (_fRadUp >= -10000) && (_fRadDown >= -10000) && (_startfZ >= -10000))
                {
                    valueFaska = true;
                }

            } else
            {
                valueFaska = false;
            }

            return valueFaska;
        }

        public static bool CheckValueSlot(string sW, string sL, string sSZ)
        {
            successSL = double.TryParse(sL, out _sLength);
            successSW = double.TryParse(sW, out _sWidth);
            successSStartZ = double.TryParse(sSZ, out _startSZ);
            

            if (successSL && successSW && successSStartZ == true)
            {
                if ((_sLength <= 10000) && (_sWidth <= 10000) && (_startSZ <= 10000) && (_sLength >= -10000) && (_sWidth >= -10000) && (_startSZ >= -10000))
                {
                    valueSlot = true;
                }
            }
            else
            {
                valueSlot = false;
            }
            return valueSlot;
        }

        public static  bool CheckValuesG02(string nX, string nZ, string R)
        {
            successNX = double.TryParse(nX, out _nX);
            successNZ = double.TryParse(nZ, out _nZ);
            successNR = double.TryParse(R, out _R);

            if (successNX && successNZ && successNR == true)
            {

                if ((_nX >= -10000) && (_nX <= 10000) && (_nZ >= -10000) && (_nZ <= 10000) && (_nX - _X == -(_R)) && (Math.Abs(_nZ - _Z) == _R) && (_R >= -10000) && (_R <= 10000))
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
            successNX = double.TryParse(nX, out _nX);
            successNZ = double.TryParse(nZ, out _nZ);
            successNR = double.TryParse(R, out _R);

            if (successNX && successNZ && successNR == true)
            {
                if ((_nX - _X == _R) && (Math.Abs(_nZ - _Z) == _R) && (_nX >= -10000) && (_nX <= 10000) && (_nZ >= -10000) && (_nZ <= 10000) && (_R >= -10000) && (_R <= 10000))
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
            successSpindel = double.TryParse(shpindel, out _value);

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

        public static bool CheckValueSpeed(string speed)
        {
            bool successSpeed = decimal.TryParse(speed, out decimal _valueF);

            if (successSpeed == true)
            {
                if (_valueF > 0 && _valueF <= 5000)
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

        public static bool CheckValueRectangle(string rW, string rL, string rSZ)
        {
            successRL = double.TryParse(rL, out _rLength);
            successRW = double.TryParse(rW, out _rWidth);
            successRStartZ = double.TryParse(rSZ, out _startRZ);

            if (successRL && successRW && successRStartZ == true)
            {
                if ((_rLength < 10000) && (_rWidth < 10000) && (_startRZ < 10000) && (_rLength > -10000) && (_rWidth > -10000) && (_startRZ > -10000))
                {
                    valueRectangle = true;

                    NextValues(_rWidth, (_rLength+_startRZ));
                }
                else
                {
                    MessageBox.Show("Введен неправильный размер", "Внимание", MessageBoxButtons.OK);
                }

            }
            else
            {
                valueRectangle = false;
            }

            return valueRectangle;
        }


        public static void InvalidData()
        {
            MessageBox.Show("Введены неверные данные", "Внимание", MessageBoxButtons.OK);
        }

        public static void ValidData()
        {
            MessageBox.Show("Запись прошла успешно!", "Внимание", MessageBoxButtons.OK);
        }
    }
}
