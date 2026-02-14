using System.Collections.Generic;
using HarmonyLib;

namespace ItemChanger.Silksong;

public static class SilksongEvents
{
    public static void AddFsmEdit(FsmId id, Action<PlayMakerFSM> edit)
    {
        edits[id] = edits.GetValueOrDefault(id) + edit;
    }

    public static void RemoveFsmEdit(FsmId id, Action<PlayMakerFSM> edit)
    {
        edits[id] -= edit;
    }

    internal static void Hook()
    {
        var patch = typeof(Patches);
        new Harmony(patch.FullName).PatchAll(patch);
    }

    internal static void Unhook()
    {
        Harmony.UnpatchID(typeof(Patches).FullName);
        foreach (var id in edits.Keys)
        {
            Logger.LogWarn($"FSM edit not cleaned up for {id.FsmName} in object {id.ObjectName} in scene {id.SceneName}");
        }
        edits.Clear();
    }

    private static Dictionary<FsmId, Action<PlayMakerFSM>?> edits = [];

    [HarmonyPatch]
    private static class Patches
    {
        [HarmonyPatch(typeof(PlayMakerFSM), nameof(PlayMakerFSM.Start))]
        [HarmonyPrefix]
        private static void Prefix(PlayMakerFSM __instance)
        {
            var fsm = __instance;
            FsmId id = new(fsm.gameObject.scene.name, fsm.gameObject.name, fsm.FsmName);
            try
            {
                edits.GetValueOrDefault(id)?.Invoke(fsm);
            }
            catch (Exception err)
            {
                Logger.LogError($"Error applying FSM edit to FSM {id.FsmName} in object {id.ObjectName} in scene {id.SceneName}: {err}");
            }
        }
    }
}