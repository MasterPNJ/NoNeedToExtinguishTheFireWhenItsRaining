using HarmonyLib;
using Verse;
using RimWorld;

[StaticConstructorOnStartup]
public static class PreventFirefightingDuringRain
{
    static PreventFirefightingDuringRain()
    {
        var harmony = new Harmony("com.MasterPNJ.preventfirefightingduringrain");
        Log.Message("Initializing Harmony patch for PreventFirefightingDuringRain");
        harmony.PatchAll();
    }
}