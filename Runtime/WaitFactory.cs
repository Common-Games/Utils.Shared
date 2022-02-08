using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utils.Shared
{
    public static class WaitFactory
    {
        #region WaitForSeconds
        
        private static readonly Dictionary<Single, WaitForSeconds> WaitForSecondsDictionary = new Dictionary<Single, WaitForSeconds>();
        
        /// <summary> Gives you a reusable <see cref="WaitForSeconds"/>.</summary>
        /// <returns> A reusable <see cref="WaitForSeconds"/>. </returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WaitForSeconds Seconds(Single seconds)
        {
            //If the dictionary contains an entry with key 'seconds' it returns the found entry.
            if (WaitForSecondsDictionary.TryGetValue(key: seconds, value: out WaitForSeconds __result)) return __result;
            
            //If not, it adds it and returns the result.
            WaitForSecondsDictionary.Add(key: seconds, value: new WaitForSeconds(seconds: seconds));

            return WaitForSecondsDictionary[key: seconds];
        }
        
        #endregion
        
        #region WaitForSecondsRealtime
        
        private static readonly Dictionary<Single, WaitForSecondsRealtime> WaitForSecondsRealtimeDictionary = new Dictionary<Single, WaitForSecondsRealtime>();
        
        /// <summary> Gives you a reusable <see cref="WaitForSecondsRealtime"/>.</summary>
        /// <returns> A reusable <see cref="WaitForSecondsRealtime"/>. </returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WaitForSecondsRealtime SecondsRealtime(Single seconds)
        {
            //If the dictionary contains an entry with key 'seconds' it returns the found entry.
            if (WaitForSecondsRealtimeDictionary.TryGetValue(key: seconds, value: out WaitForSecondsRealtime __result)) return __result;
            
            //If not, it adds it and returns the result.
            WaitForSecondsRealtimeDictionary.Add(key: seconds, value: new WaitForSecondsRealtime(time: seconds));

            __result = WaitForSecondsRealtimeDictionary[key: seconds];

            return __result;
        }
        
        #endregion
    }
}
