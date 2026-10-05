using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006259 RID: 25177
	[Token(Token = "0x2006259")]
	public class AutoChessRemoveChessPoolCharRequest
	{
		// Token: 0x06024564 RID: 148836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024564")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessRemoveChessPoolCharRequest()
		{
		}

		// Token: 0x04032885 RID: 206981
		[Token(Token = "0x4032885")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032886 RID: 206982
		[Token(Token = "0x4032886")]
		[FieldOffset(Offset = "0x18")]
		public string chessId;
	}
}
