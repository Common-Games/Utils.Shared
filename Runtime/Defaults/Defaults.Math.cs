using System;
using UnityEngine;

namespace CGTK.Utils.Shared
{
    using F32 = Single;
    using F64 = Double;

    using I8  = SByte;
    using I16 = Int16;
    using I32 = Int32;
    using I64 = Int64;

    using U8  = Byte;
    using U16 = UInt16;
    using U32 = UInt32;
    using U64 = UInt64;
    
    public static partial class Defaults
    {
        /// <summary>
        /// Circle constant relating the circumference of a circle to its linear dimension.
        /// (circumference / radius)
        /// </summary>
        public const F32 TAU = 6.28318530717959f;
        
        /// <summary> TAU times 2. </summary>
        public const F32 TAU_X2 = TAU * 2;

        /// <summary> TAU times 4. </summary>
        public const F32 TAU_X4 = TAU_X2 * 2;
        
        /// <summary> TAU times 8. </summary>
        public const F32 TAU_X8 = TAU_X4 * 2;
        
        public const F32 PI = Mathf.PI;
        
        public const F32 PI_HALF = (PI * 0.5f);
        
        /// <summary> Use this to convert from Degrees to Radians. </summary>
        /// <remarks> (TAU / 360) or (PI / 180) </remarks>
        public const F32 DEG_TO_RAD = (TAU / 360f);
        
        /// <summary> Use this to convert from Radians to Degrees. </summary>
        /// <remarks> (360 / TAU) or (180 / PI) </remarks>
        public const F32 RAD_TO_DEG = (360f / TAU);
        
        public const F32 INFINITY = Mathf.Infinity;
        
        public const F32 NEGATIVE_INFINITY = Mathf.NegativeInfinity;
        
        public static F32 EPSILON = Mathf.Epsilon;

        /// <summary> Square root of 0.5 </summary>
        public const F32 SQRT_05 = 0.7071067811865475244f;
        
        /// <summary> Square root of 2. </summary>
        public const F32 SQRT_2 = 1.4142135623730950488f;
        
        /// <summary> Square root of 5. </summary>
        public const F32 SQRT_5 = 2.2360679774997896964f;
        
        /// <summary> Golden angle in radians. </summary>
        
        public const F32 GOLDEN_ANGLE = PI * (3 - SQRT_5);
    }
}