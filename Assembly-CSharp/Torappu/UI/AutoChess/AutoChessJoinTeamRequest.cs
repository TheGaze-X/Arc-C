using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006262 RID: 25186
	[Token(Token = "0x2006262")]
	public class AutoChessJoinTeamRequest
	{
		// Token: 0x0602456D RID: 148845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessJoinTeamRequest()
		{
		}

		// Token: 0x04032896 RID: 206998
		[Token(Token = "0x4032896")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04032897 RID: 206999
		[Token(Token = "0x4032897")]
		[FieldOffset(Offset = "0x18")]
		public string teamId;
	}
}
