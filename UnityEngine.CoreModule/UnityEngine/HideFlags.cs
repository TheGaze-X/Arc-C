using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Flags]
	public enum HideFlags
	{
		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		None = 0,
		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		HideInHierarchy = 1,
		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		HideInInspector = 2,
		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		DontSaveInEditor = 4,
		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		NotEditable = 8,
		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		DontSaveInBuild = 16,
		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		DontUnloadUnusedAsset = 32,
		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		DontSave = 52,
		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		HideAndDontSave = 61
	}
}
