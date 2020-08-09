// This is free and unencumbered software released into the public domain.

using UnrealBuildTool;
using System.Collections.Generic;

public class VoxFormatModuleEditorTarget : TargetRules
{
	public VoxFormatModuleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "VoxFormatModule", "VoxFormat" } );
	}
}
