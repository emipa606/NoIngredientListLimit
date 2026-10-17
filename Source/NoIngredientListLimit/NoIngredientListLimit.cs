using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoIngredientListLimit;

[StaticConstructorOnStartup]
public static class NoIngredientListLimit
{
    static NoIngredientListLimit()
    {
        new Harmony("Mlie.NoIngredientListLimit").PatchAll(Assembly.GetExecutingAssembly());
    }
}