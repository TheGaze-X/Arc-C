using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TMPro
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public struct TMP_MaterialReference
	{
		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x0")]
		public Material material;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x8")]
		public int referenceCount;
	}
}
