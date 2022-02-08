using System;
using JetBrains.Annotations;

namespace CGTK.Utils.Shared
{

    [PublicAPI]
    public static partial class Defaults
    {
        /// <summary> A static System.Random, used when functions don't get one send to them. </summary>
        public static Random RNG { get; } = new Random();
    }
}