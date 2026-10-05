using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000FD0 RID: 4048
	[Token(Token = "0x2000FD0")]
	public class CrisisV2MapRoadInflectionData
	{
		// Token: 0x06006D1E RID: 27934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MapRoadInflectionData()
		{
		}

		// Token: 0x040055E4 RID: 21988
		[Token(Token = "0x40055E4")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 cornerPos;

		// Token: 0x040055E5 RID: 21989
		[Token(Token = "0x40055E5")]
		[FieldOffset(Offset = "0x18")]
		public int radius;
	}
}
