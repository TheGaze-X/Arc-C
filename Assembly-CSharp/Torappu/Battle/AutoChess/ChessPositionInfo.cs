using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002726 RID: 10022
	[Token(Token = "0x2002726")]
	public class ChessPositionInfo
	{
		// Token: 0x06010480 RID: 66688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010480")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChessPositionInfo()
		{
		}

		// Token: 0x04012334 RID: 74548
		[Token(Token = "0x4012334")]
		[FieldOffset(Offset = "0x10")]
		public int instId;

		// Token: 0x04012335 RID: 74549
		[Token(Token = "0x4012335")]
		[FieldOffset(Offset = "0x14")]
		public int position;

		// Token: 0x04012336 RID: 74550
		[Token(Token = "0x4012336")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessItemType chessType;

		// Token: 0x04012337 RID: 74551
		[Token(Token = "0x4012337")]
		[FieldOffset(Offset = "0x1C")]
		public SharedConsts.Direction direction;
	}
}
