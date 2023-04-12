// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyProject7EditorTarget : TargetRules
{
	public MyProject7EditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
        bOverrideBuildEnvironment = true;
        AdditionalCompilerArguments = "-Wno-unused-but-set-logical";
        AdditionalCompilerArguments = "-Wno-unused-but-set-variable";
		ExtraModuleNames.AddRange( new string[] { "MyProject7" } );
	}
}
