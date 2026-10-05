using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006260 RID: 25184
	[Token(Token = "0x2006260")]
	public class AutoChessCreateTeamRequest
	{
		// Token: 0x0602456B RID: 148843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessCreateTeamRequest()
		{
		}

		// Token: 0x04032890 RID: 206992
		[Token(Token = "0x4032890")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04032891 RID: 206993
		[Token(Token = "0x4032891")]
		[FieldOffset(Offset = "0x18")]
		public string modeId;

		// Token: 0x04032892 RID: 206994
		[Token(Token = "0x4032892")]
		[FieldOffset(Offset = "0x20")]
		public int matchOpt;

		// Token: 0x04032893 RID: 206995
		[Token(Token = "0x4032893")]
		[FieldOffset(Offset = "0x24")]
		public bool matchFlag;
	}
}
