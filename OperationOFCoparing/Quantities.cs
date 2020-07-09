using QuantityMesurement.MesurmentEnum;
using System;
using System.Text.Collections.Generic.QuantityMesurement.MesurmentEnum;

namespace QuantityMesurement
{
    public class Quantities
    {
        public Length length;
        public Mass mass;
        public Volume volume;

        public static Length  castTolength(Quantities v)
        {
            return v.length;
        }
        public static Mass castToMass(Quantities v)
        {
            return v.mass;
        }
        public static Volume castToVol(Quantities v)
        {
            return v.volume;
        }
    }
}