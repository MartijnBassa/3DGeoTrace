using UnrealBuildTool;

public class MigrateMartijnTarget : TargetRules
{
	public MigrateMartijnTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MigrateMartijn");
	}
}
