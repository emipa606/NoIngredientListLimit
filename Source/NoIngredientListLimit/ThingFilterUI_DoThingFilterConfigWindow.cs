using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace NoIngredientListLimit;

[HarmonyPatch(typeof(ThingFilterUI), "DoThingFilterConfigWindow")]
public static class ThingFilterUI_DoThingFilterConfigWindow
{
    private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
    {
        foreach (var instruction in instructions)
        {
            if (instruction.operand is float operand and 9999f)
            {
                instruction.operand = operand * 10;
            }

            yield return instruction;
        }
    }
}