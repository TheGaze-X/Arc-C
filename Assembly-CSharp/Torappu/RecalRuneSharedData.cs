using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200112E RID: 4398
	[Token(Token = "0x200112E")]
	public class RecalRuneSharedData
	{
		// Token: 0x06006F02 RID: 28418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F02")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecalRuneSharedData()
		{
		}

		// Token: 0x04005E39 RID: 24121
		[Token(Token = "0x4005E39")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RecalRuneSeasonData> seasons;

		// Token: 0x04005E3A RID: 24122
		[Token(Token = "0x4005E3A")]
		[FieldOffset(Offset = "0x18")]
		public RecalRuneConstData constData;
	}
}
