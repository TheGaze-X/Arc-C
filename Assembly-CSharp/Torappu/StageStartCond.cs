using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001364 RID: 4964
	[Token(Token = "0x2001364")]
	public class StageStartCond
	{
		// Token: 0x0600732D RID: 29485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732D")]
		[Address(RVA = "0x2213C40", Offset = "0x2212840", VA = "0x182213C40")]
		public StageStartCond()
		{
		}

		// Token: 0x04006E25 RID: 28197
		[Token(Token = "0x4006E25")]
		[FieldOffset(Offset = "0x10")]
		public List<StageStartCond.RequireChar> requireChars;

		// Token: 0x04006E26 RID: 28198
		[Token(Token = "0x4006E26")]
		[FieldOffset(Offset = "0x18")]
		public List<string> excludeAssists;

		// Token: 0x04006E27 RID: 28199
		[Token(Token = "0x4006E27")]
		[FieldOffset(Offset = "0x20")]
		public bool isNotPass;

		// Token: 0x02001365 RID: 4965
		[Token(Token = "0x2001365")]
		public class RequireChar
		{
			// Token: 0x0600732E RID: 29486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600732E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RequireChar()
			{
			}

			// Token: 0x04006E28 RID: 28200
			[Token(Token = "0x4006E28")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x04006E29 RID: 28201
			[Token(Token = "0x4006E29")]
			[FieldOffset(Offset = "0x18")]
			public EvolvePhase evolvePhase;
		}
	}
}
