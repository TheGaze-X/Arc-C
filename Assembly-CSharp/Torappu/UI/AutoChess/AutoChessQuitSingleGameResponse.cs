using System;
using Il2CppDummyDll;
using Torappu.Activity.AutoChess;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200627B RID: 25211
	[Token(Token = "0x200627B")]
	public class AutoChessQuitSingleGameResponse : PlayerDeltaResponse
	{
		// Token: 0x0602459E RID: 148894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602459E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessQuitSingleGameResponse()
		{
		}

		// Token: 0x040328E6 RID: 207078
		[Token(Token = "0x40328E6")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040328E7 RID: 207079
		[Token(Token = "0x40328E7")]
		[FieldOffset(Offset = "0x30")]
		public ActAutoChessSyncInfoBattleInfo battleInfo;
	}
}
