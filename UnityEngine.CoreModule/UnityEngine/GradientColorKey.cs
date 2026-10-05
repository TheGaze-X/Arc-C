using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[UsedByNativeCode]
	public struct GradientColorKey
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x594AA20", Offset = "0x5949620", VA = "0x18594AA20")]
		public GradientColorKey(Color col, float time)
		{
		}

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0x0")]
		public Color color;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0x10")]
		public float time;
	}
}
