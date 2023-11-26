using HarmonyLib;
using GameNetcodeStuff;


namespace LC_WalkieTalkieTweaks.Patches
{
     [HarmonyPatch(typeof(WalkieTalkie))]
     internal class WalkieTalkieItemPatch
     {
         [HarmonyPatch("ItemActivate")]
         [HarmonyPostfix]
         private static void ChangeWalkieTalkieBatteryCapacity(ref WalkieTalkie __instance)
         {
             __instance.itemProperties.batteryUsage = 400;
         }
     }
}