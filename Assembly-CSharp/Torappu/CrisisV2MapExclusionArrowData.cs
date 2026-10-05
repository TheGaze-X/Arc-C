using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000FCD RID: 4045
	[Token(Token = "0x2000FCD")]
	public class CrisisV2MapExclusionArrowData
	{
		// Token: 0x06006D1B RID: 27931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MapExclusionArrowData()
		{
		}

		// Token: 0x040055DC RID: 21980
		[Token(Token = "0x40055DC")]
		[FieldOffset(Offset = "0x10")]
		public string upSlotId;

		// Token: 0x040055DD RID: 21981
		[Token(Token = "0x40055DD")]
		[FieldOffset(Offset = "0x18")]
		public string downSlotId;

		// Token: 0x040055DE RID: 21982
		[Token(Token = "0x40055DE")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 pos;
	}
}
