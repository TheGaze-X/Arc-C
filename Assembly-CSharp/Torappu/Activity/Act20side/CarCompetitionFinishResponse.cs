using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007639 RID: 30265
	[Token(Token = "0x2007639")]
	public class CarCompetitionFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602A999 RID: 174489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A999")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public CarCompetitionFinishResponse()
		{
		}

		// Token: 0x0403D55D RID: 251229
		[Token(Token = "0x403D55D")]
		[FieldOffset(Offset = "0xA0")]
		public int performance;

		// Token: 0x0403D55E RID: 251230
		[Token(Token = "0x403D55E")]
		[FieldOffset(Offset = "0xA4")]
		public int expression;

		// Token: 0x0403D55F RID: 251231
		[Token(Token = "0x403D55F")]
		[FieldOffset(Offset = "0xA8")]
		public int operation;

		// Token: 0x0403D560 RID: 251232
		[Token(Token = "0x403D560")]
		[FieldOffset(Offset = "0xAC")]
		public int total;

		// Token: 0x0403D561 RID: 251233
		[Token(Token = "0x403D561")]
		[FieldOffset(Offset = "0xB0")]
		public CartCompetitionRank level;

		// Token: 0x0403D562 RID: 251234
		[Token(Token = "0x403D562")]
		[FieldOffset(Offset = "0xB4")]
		public bool isNew;
	}
}
