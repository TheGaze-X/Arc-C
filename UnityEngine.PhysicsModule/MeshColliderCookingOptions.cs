using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[Flags]
	public enum MeshColliderCookingOptions
	{
		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		None = 0,
		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Obsolete("No longer used because the problem this was trying to solve is gone since Unity 2018.3", true)]
		InflateConvexMesh = 1,
		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		CookForFasterSimulation = 2,
		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		EnableMeshCleaning = 4,
		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		WeldColocatedVertices = 8,
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		UseFastMidphase = 16
	}
}
