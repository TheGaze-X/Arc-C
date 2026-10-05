using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026DD RID: 9949
	[Token(Token = "0x20026DD")]
	[Serializable]
	public class SailBoatTextAsset
	{
		// Token: 0x0601030B RID: 66315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601030B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SailBoatTextAsset()
		{
		}

		// Token: 0x0401216B RID: 74091
		[Token(Token = "0x401216B")]
		[FieldOffset(Offset = "0x10")]
		public TextAsset textAsset;

		// Token: 0x0401216C RID: 74092
		[Token(Token = "0x401216C")]
		[FieldOffset(Offset = "0x18")]
		public BoatDirection boatExit;
	}
}
