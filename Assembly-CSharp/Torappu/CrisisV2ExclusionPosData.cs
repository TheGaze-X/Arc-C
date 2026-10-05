using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000FCE RID: 4046
	[Token(Token = "0x2000FCE")]
	public class CrisisV2ExclusionPosData
	{
		// Token: 0x06006D1C RID: 27932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2ExclusionPosData()
		{
		}

		// Token: 0x040055DF RID: 21983
		[Token(Token = "0x40055DF")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040055E0 RID: 21984
		[Token(Token = "0x40055E0")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 pos;

		// Token: 0x040055E1 RID: 21985
		[Token(Token = "0x40055E1")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 size;
	}
}
