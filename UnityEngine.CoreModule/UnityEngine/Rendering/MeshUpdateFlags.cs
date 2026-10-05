using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000243 RID: 579
	[Token(Token = "0x2000243")]
	[Flags]
	public enum MeshUpdateFlags
	{
		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		Default = 0,
		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		DontValidateIndices = 1,
		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		DontResetBoneBounds = 2,
		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		DontNotifyMeshUsers = 4,
		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		DontRecalculateBounds = 8
	}
}
