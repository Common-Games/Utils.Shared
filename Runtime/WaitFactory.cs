using System.Collections.Generic;
using System.Runtime.CompilerServices;

using JetBrains.Annotations;
using UnityEngine;

namespace CGTK.Utilities.Shared
{
    public static class WaitFactory
    {
        #region WaitForSeconds
        
        private static readonly Dictionary<float, WaitForSeconds> WaitForSecondsDictionary = new Dictionary<float, WaitForSeconds>();
        
        /// <summary> Gives you a reusable <see cref="WaitForSeconds"/>.</summary>
        /// <returns> A reusable <see cref="WaitForSeconds"/>. </returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WaitForSeconds WaitForSeconds(float seconds)
        {
            //If the dictionary contains an entry with key 'seconds' it returns the found entry.
            if (WaitForSecondsDictionary.TryGetValue(key: seconds, value: out WaitForSeconds __result)) return __result;
            
            //If not, it adds it and returns the result.
            WaitForSecondsDictionary.Add(key: seconds, value: new WaitForSeconds(seconds: seconds));

            __result = WaitForSecondsDictionary[key: seconds];

            return __result;
        }
        
        #endregion
        
        #region WaitForSecondsRealtime
        
        private static readonly Dictionary<float, WaitForSecondsRealtime> WaitForSecondsRealtimeDictionary = new Dictionary<float, WaitForSecondsRealtime>();
        
        /// <summary> Gives you a reusable <see cref="WaitForSecondsRealtime"/>.</summary>
        /// <returns> A reusable <see cref="WaitForSecondsRealtime"/>. </returns>
        [PublicAPI]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static WaitForSecondsRealtime WaitForSecondsRealtime(float seconds)
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
