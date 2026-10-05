using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Flags]
	[UsedByNativeCode]
	[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshBindings.h")]
	public enum MeshVertexAttributes
	{
		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		None = 0,
		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		Normals = 1,
		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		Tangents = 2,
		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		UVs = 4,
		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		Colors = 8
	}
}
