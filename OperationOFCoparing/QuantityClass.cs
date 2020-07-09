using QuantityMesurement.Exception;
using QuantityMesurement.MesurmentEnum;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.Collections.Generic.QuantityMesurement.MesurmentEnum;

namespace QuantityMesurement
{
    public class QuantityClass
    {
        private Quantities unit;
        private int value;
        public QuantityClass(Length unit, int value)
        {
            this.unit.length = unit;
            this.value = value;
        }
        public QuantityClass(Volume unit, int value)
        {
            this.unit.volume = unit;
            this.value = value;
        }
        public QuantityClass(Mass unit, int value)
        {
            this.unit.mass = unit;
            this.value = value;
        }

        public static bool Compare(QuantityClass length1, QuantityClass length)
        {
            try 
            {  if (Convert( length1,  length))
                {
                    int variableA = (int)length.unit * length.value;
                    int variableB = (int)length1.unit * length1.value;
                    return (variableA == variableB);
                }
                else throw new QMException(QMException.ExceptionEnmu.INVAILD_VALUE);
            }
            catch (QMException e)
            {
                throw new QMException(QMException.ExceptionEnmu.INVAILD_VALUE,e.Message);
            }
         
            
        }
        private static bool Convert(QuantityClass length1, QuantityClass length)
        {
            if (length.unit != length1.unit)

                throw new QMException(QMException.ExceptionEnmu.INVAILD_VALUE);
            else
                return true;
        }

    }
}
