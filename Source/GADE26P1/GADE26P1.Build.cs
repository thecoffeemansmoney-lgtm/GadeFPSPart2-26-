// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GADE26P1 : ModuleRules
{
	public GADE26P1(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"GADE26P1",
			"GADE26P1/Variant_Horror",
			"GADE26P1/Variant_Horror/UI",
			"GADE26P1/Variant_Shooter",
			"GADE26P1/Variant_Shooter/AI",
			"GADE26P1/Variant_Shooter/UI",
			"GADE26P1/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
