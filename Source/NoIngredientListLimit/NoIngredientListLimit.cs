using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoIngredientListLimit;

[StaticConstructorOnStartup]
public static class NoIngredientListLimit
{
    static NoIngredientListLimit()
    {
        var harmony = new Harmony("Mlie.NoIngredientListLimit");
        harmony.PatchAll(Assembly.GetExecutingAssembly());
        Log.Message("[NoIngredientListLimit]: Increasing ingredient list-window x10");
    }
}