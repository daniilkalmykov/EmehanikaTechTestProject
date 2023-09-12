using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-Csharp")]
namespace Source.PlayerData
{
    internal static class PlayerData
    {
        private const string Time = "Time";

        public static void SetTime(float time)
        {
            PlayerPrefs.SetFloat(Time, time);
        }

        public static float GetTime()
        {
            return PlayerPrefs.GetFloat(Time);
        }
    }
}