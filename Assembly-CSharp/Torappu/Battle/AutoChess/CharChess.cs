using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002723 RID: 10019
	[Token(Token = "0x2002723")]
	public class CharChess
	{
		// Token: 0x0601047D RID: 66685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601047D")]
		[Address(RVA = "0x803890", Offset = "0x802490", VA = "0x180803890")]
		public CharChess()
		{
		}

		// Token: 0x0401232B RID: 74539
		[Token(Token = "0x401232B")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x0401232C RID: 74540
		[Token(Token = "0x401232C")]
		[FieldOffset(Offset = "0x18")]
		public List<int> equipSlots;

		// Token: 0x0401232D RID: 74541
		[Token(Token = "0x401232D")]
		[FieldOffset(Offset = "0x20")]
		public string chessId;
	}
}
