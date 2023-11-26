using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using LC_WalkieTalkieTweaks.Patches;


namespace LC_WalkieTalkieTweaks
{
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {

        private readonly Harmony __harmony = new Harmony(PluginInfo.PLUGIN_GUID);
        private static Plugin __instance;
        
        private void Awake()
        {
            if (__instance == null)
            {
                __instance = this;
            }

            __harmony.PatchAll(typeof(Plugin));
            __harmony.PatchAll(typeof(WalkieTalkieItemPatch));
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID}-{PluginInfo.PLUGIN_VERSION} is loaded!");
        }
    }
}



