using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006254 RID: 25172
	[Token(Token = "0x2006254")]
	public class AutoChessSetChessPoolDeployRequest
	{
		// Token: 0x0602455F RID: 148831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602455F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessSetChessPoolDeployRequest()
		{
		}

		// Token: 0x0403287D RID: 206973
		[Token(Token = "0x403287D")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403287E RID: 206974
		[Token(Token = "0x403287E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Deploy> chessPool;
	}
}
