using HarmonyLib;
using Verse;
using RimWorld;
using Verse.AI;

[HarmonyPatch(typeof(JobGiver_Work), "TryIssueJobPackage")]
public static class JobGiver_Work_TryIssueJobPackage_Patch
{
    public static void Postfix(Pawn pawn, JobIssueParams jobParams, ref ThinkResult __result)
    {
        Log.Message("Postfix called for JobGiver_Work.TryIssueJobPackage");
        if (__result.Job != null && __result.Job.def == JobDefOf.BeatFire && pawn.Map.weatherManager.RainRate > 0.5f)
        {
            Log.Message("Preventing firefighting job during rain");
            __result = ThinkResult.NoJob;
        }
    }
}