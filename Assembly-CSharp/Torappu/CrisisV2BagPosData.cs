using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x02000FCF RID: 4047
	[Token(Token = "0x2000FCF")]
	public class CrisisV2BagPosData
	{
		// Token: 0x06006D1D RID: 27933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2BagPosData()
		{
		}

		// Token: 0x040055E2 RID: 21986
		[Token(Token = "0x40055E2")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 pos;

		// Token: 0x040055E3 RID: 21987
		[Token(Token = "0x40055E3")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 size;
	}
}
