# GitHub Copilot Instructions for No Ingredient List Limit Mod

## Mod Overview and Purpose

**Mod Name**: No Ingredient List Limit  
**Author**: Mlie  
**PackageId**: Mlie.NoIngredientListLimit  

**Description**:  
The "No Ingredient List Limit" mod addresses the limitations of RimWorld's vanilla ingredient list, which cuts off at around 400 items when selecting ingredients for recipes. This can be problematic for users who have added a large number of mods, resulting in an overwhelming number of ingredients. To solve this, No Ingredient List Limit increases the maximum number of displayed ingredients by tenfold, accommodating up to 4000 items. The mod is designed with flexibility in mind, allowing further increases if necessary. Additionally, it expands lists in other areas, such as storage lists.

**Inspiration**:  
The mod was inspired by discussions with RimWorld modding community member HydromancerX, which also influenced the design and preview image of the mod.

## Key Features and Systems

- **Expanded Ingredient List**: Increases the display capacity of ingredient lists up to 4000 items.
- **Universal Application**: The expanded list capacity applies not only to ingredient selection in recipes but also to storage and inventory lists.

## Coding Patterns and Conventions

- **Namespace Organization**: Each class is likely organized within appropriately named namespaces that reflect their function in the mod, conforming to industry conventions for C# programming.
- **Commenting and Documentation**: Code is well-documented with comments explaining purpose and functionality.
- **Consistency**: Consistent naming conventions are used throughout the code for variables, methods, and classes to ensure readability and maintainability.

## XML Integration

- **XML Files**: The mod uses XML definitions, such as `TestingDef.xml`, to potentially define new or adjusted game objects or behaviors.
- **ThingDef Definitions**: XML is utilized to manage game entity and behavior definitions, applying changes uniformly across the mod where needed.

## Harmony Patching

- **Dependency**: The mod depends on the `brrainz.harmony` library to implement patches.
- **Transpiler Usage**: The C# code contains a `Transpiler` method found in `ThingFilterUI_DoThingFilterConfigWindow.cs` to modify existing game methods, allowing the expansion of list limits in a low-impact manner.
- **Efficiency**: Harmony patching is employed to ensure the mod integrates seamlessly without altering core game files directly, minimizing compatibility issues with other mods.

## Suggestions for Copilot

- **Pattern Enhancement**: Use Copilot to identify and suggest optimization patterns within the C# code that align with efficient list handling methods.
- **Error Detection**: Copilot can assist in identifying potential error points in the harmony patches, especially concerning edge cases where list sizes approach the expanded limit.
- **Code Readability**: Suggest improvements for code readability and maintenance, such as refactoring complex methods or enhancing inline documentation.
- **Integration Points**: Recommend additional points in the game's codebase where future expansions of list limitations might be necessary or beneficial.
- **Testing Suggestions**: Provide test scenarios to run after implementing changes to ensure the mod's functionality meets user needs without introducing unforeseen issues.

--- 

Ensure to review all Copilot suggestions carefully, as game mods may introduce unique challenges and require nuanced handling to maintain compatibility and functionality.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

