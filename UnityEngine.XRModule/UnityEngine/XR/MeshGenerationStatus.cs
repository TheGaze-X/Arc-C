using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	public enum MeshGenerationStatus
	{
		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		Success,
		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		InvalidMeshId,
		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		GenerationAlreadyInProgress,
		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		Canceled,
		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		UnknownError
	}
}
