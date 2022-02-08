using System;

namespace CGTK.Utils.Shared
{
    public static partial class Defaults
    {
        #region Alphanumerics

        /// <summary> Lowercase letters from a to z </summary>
        public const String LOWERCASE_LETTERS = "abcdefghijklmnopqrstuvwxyz";
        
        /// <summary> Uppercase letters from A to Z </summary>
        public const String UPPERCASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        
        /// <summary> All <see cref="LOWERCASE_LETTERS"/> and <see cref="UPPERCASE_LETTERS"/>. </summary>
        public const String LETTERS = LOWERCASE_LETTERS + UPPERCASE_LETTERS;
        
        /// <summary> Digits from 0 to 9 </summary>
        public const String DIGITS = "0123456789";
        
        /// <summary> All <see cref="LETTERS"/> and <see cref="DIGITS"/> </summary>
        public const String ALPHANUMERICS = LETTERS + DIGITS;

        #endregion
    }
}