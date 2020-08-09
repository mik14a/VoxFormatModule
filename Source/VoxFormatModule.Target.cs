// This is free and unencumbered software released into the public domain.

using UnrealBuildTool;
using System.Collections.Generic;

public class VoxFormatModuleTarget : TargetRules
{
	public VoxFormatModuleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "VoxFormatModule", "VoxFormat" } );
	}
}
