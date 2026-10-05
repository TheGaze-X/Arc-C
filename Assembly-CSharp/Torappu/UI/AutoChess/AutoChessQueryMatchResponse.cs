using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006282 RID: 25218
	[Token(Token = "0x2006282")]
	public class AutoChessQueryMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x060245A5 RID: 148901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245A5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessQueryMatchResponse()
		{
		}

		// Token: 0x040328F1 RID: 207089
		[Token(Token = "0x40328F1")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessQueryMatchResponse.QueryMatchResultType result;

		// Token: 0x040328F2 RID: 207090
		[Token(Token = "0x40328F2")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessQueryMatchResponse.TeamInfo team;

		// Token: 0x02006283 RID: 25219
		[Token(Token = "0x2006283")]
		public class TeamInfo
		{
			// Token: 0x060245A6 RID: 148902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60245A6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TeamInfo()
			{
			}

			// Token: 0x040328F3 RID: 207091
			[Token(Token = "0x40328F3")]
			[FieldOffset(Offset = "0x10")]
			public string teamId;

			// Token: 0x040328F4 RID: 207092
			[Token(Token = "0x40328F4")]
			[FieldOffset(Offset = "0x18")]
			public string serverAddress;

			// Token: 0x040328F5 RID: 207093
			[Token(Token = "0x40328F5")]
			[FieldOffset(Offset = "0x20")]
			public string serverToken;
		}

		// Token: 0x02006284 RID: 25220
		[Token(Token = "0x2006284")]
		public enum QueryMatchResultType
		{
			// Token: 0x040328F7 RID: 207095
			[Token(Token = "0x40328F7")]
			OK,
			// Token: 0x040328F8 RID: 207096
			[Token(Token = "0x40328F8")]
			CANCEL,
			// Token: 0x040328F9 RID: 207097
			[Token(Token = "0x40328F9")]
			TIME_OUT
		}
	}
}
