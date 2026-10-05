using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F57 RID: 20311
	[Token(Token = "0x2004F57")]
	public struct MileStoneInfo
	{
		// Token: 0x04028547 RID: 165191
		[Token(Token = "0x4028547")]
		[FieldOffset(Offset = "0x0")]
		public int currPoint;

		// Token: 0x04028548 RID: 165192
		[Token(Token = "0x4028548")]
		[FieldOffset(Offset = "0x4")]
		public int currLevel;

		// Token: 0x04028549 RID: 165193
		[Token(Token = "0x4028549")]
		[FieldOffset(Offset = "0x8")]
		public int currLevelNeedPoint;

		// Token: 0x0402854A RID: 165194
		[Token(Token = "0x402854A")]
		[FieldOffset(Offset = "0xC")]
		public int nextLevelNeedPoint;

		// Token: 0x0402854B RID: 165195
		[Token(Token = "0x402854B")]
		[FieldOffset(Offset = "0x10")]
		public int currPointInCurrLevel;

		// Token: 0x0402854C RID: 165196
		[Token(Token = "0x402854C")]
		[FieldOffset(Offset = "0x14")]
		public int totalPointInCurrLevel;

		// Token: 0x0402854D RID: 165197
		[Token(Token = "0x402854D")]
		[FieldOffset(Offset = "0x18")]
		public bool isMax;
	}
}
