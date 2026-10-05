using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006257 RID: 25175
	[Token(Token = "0x2006257")]
	public class AutoChessSetChessPoolDiyCharRequest
	{
		// Token: 0x06024562 RID: 148834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024562")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessSetChessPoolDiyCharRequest()
		{
		}

		// Token: 0x04032883 RID: 206979
		[Token(Token = "0x4032883")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032884 RID: 206980
		[Token(Token = "0x4032884")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, DiyCharDeploy> diyChessPool;
	}
}
