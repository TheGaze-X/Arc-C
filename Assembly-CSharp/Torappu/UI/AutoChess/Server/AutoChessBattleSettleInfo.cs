using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643D RID: 25661
	[Token(Token = "0x200643D")]
	public class AutoChessBattleSettleInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EDC RID: 151260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDC")]
		[Address(RVA = "0x1FC8600", Offset = "0x1FC7200", VA = "0x181FC8600", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EDD RID: 151261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDD")]
		[Address(RVA = "0x1FC86C0", Offset = "0x1FC72C0", VA = "0x181FC86C0")]
		public AutoChessBattleSettleInfo()
		{
		}

		// Token: 0x04033A8C RID: 211596
		[Token(Token = "0x4033A8C")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessSettleStateType settleState;

		// Token: 0x04033A8D RID: 211597
		[Token(Token = "0x4033A8D")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleSettleBossSettleRecordInfo> bossRecords;

		// Token: 0x04033A8E RID: 211598
		[Token(Token = "0x4033A8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A8F RID: 211599
		[Token(Token = "0x4033A8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
