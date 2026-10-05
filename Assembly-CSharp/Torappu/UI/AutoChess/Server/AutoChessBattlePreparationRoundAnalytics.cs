using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200642B RID: 25643
	[Token(Token = "0x200642B")]
	public class AutoChessBattlePreparationRoundAnalytics : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EB5 RID: 151221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB5")]
		[Address(RVA = "0x1FB0530", Offset = "0x1FAF130", VA = "0x181FB0530", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EB6 RID: 151222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EB6")]
		[Address(RVA = "0x1FB0610", Offset = "0x1FAF210", VA = "0x181FB0610")]
		public AutoChessBattlePreparationRoundAnalytics()
		{
		}

		// Token: 0x04033A2F RID: 211503
		[Token(Token = "0x4033A2F")]
		[FieldOffset(Offset = "0x10")]
		public List<AutoChessBattleChessCountInfo> chessGained;

		// Token: 0x04033A30 RID: 211504
		[Token(Token = "0x4033A30")]
		[FieldOffset(Offset = "0x18")]
		public int coinCost;

		// Token: 0x04033A31 RID: 211505
		[Token(Token = "0x4033A31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A32 RID: 211506
		[Token(Token = "0x4033A32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
