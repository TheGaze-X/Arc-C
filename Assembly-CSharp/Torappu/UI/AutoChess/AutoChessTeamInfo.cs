using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200625F RID: 25183
	[Token(Token = "0x200625F")]
	public class AutoChessTeamInfo
	{
		// Token: 0x0602456A RID: 148842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessTeamInfo()
		{
		}

		// Token: 0x0403288D RID: 206989
		[Token(Token = "0x403288D")]
		[FieldOffset(Offset = "0x10")]
		public string teamId;

		// Token: 0x0403288E RID: 206990
		[Token(Token = "0x403288E")]
		[FieldOffset(Offset = "0x18")]
		public string serverAddress;

		// Token: 0x0403288F RID: 206991
		[Token(Token = "0x403288F")]
		[FieldOffset(Offset = "0x20")]
		public string serverToken;
	}
}
