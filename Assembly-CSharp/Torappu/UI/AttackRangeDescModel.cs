using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003895 RID: 14485
	[Token(Token = "0x2003895")]
	public struct AttackRangeDescModel
	{
		// Token: 0x0401BABA RID: 113338
		[Token(Token = "0x401BABA")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly AttackRangeDescModel EMPTY;

		// Token: 0x0401BABB RID: 113339
		[Token(Token = "0x401BABB")]
		[FieldOffset(Offset = "0x0")]
		public ChrAttackRangeTile[][] grids;

		// Token: 0x0401BABC RID: 113340
		[Token(Token = "0x401BABC")]
		[FieldOffset(Offset = "0x8")]
		public string rangeId;
	}
}
