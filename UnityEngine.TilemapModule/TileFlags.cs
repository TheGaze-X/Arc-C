using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[Flags]
	public enum TileFlags
	{
		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		None = 0,
		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		LockColor = 1,
		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		LockTransform = 2,
		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		InstantiateGameObjectRuntimeOnly = 4,
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		KeepGameObjectRuntimeOnly = 8,
		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		LockAll = 3
	}
}
