using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200646A RID: 25706
	[Token(Token = "0x200646A")]
	public class AutoChessTeamLost
	{
		// Token: 0x06024F32 RID: 151346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024F32")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessTeamLost()
		{
		}

		// Token: 0x04033B5C RID: 211804
		[Token(Token = "0x4033B5C")]
		[FieldOffset(Offset = "0x10")]
		public bool stillInTeam;

		// Token: 0x04033B5D RID: 211805
		[Token(Token = "0x4033B5D")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessTeamLostReason lostReason;
	}
}
