using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200643E RID: 25662
	[Token(Token = "0x200643E")]
	public class AutoChessBattleSettleBossSettleRecordInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EDE RID: 151262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDE")]
		[Address(RVA = "0x1FC84D0", Offset = "0x1FC70D0", VA = "0x181FC84D0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EDF RID: 151263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EDF")]
		[Address(RVA = "0x1FC85A0", Offset = "0x1FC71A0", VA = "0x181FC85A0")]
		public AutoChessBattleSettleBossSettleRecordInfo()
		{
		}

		// Token: 0x04033A90 RID: 211600
		[Token(Token = "0x4033A90")]
		[FieldOffset(Offset = "0x10")]
		public string bossId;

		// Token: 0x04033A91 RID: 211601
		[Token(Token = "0x4033A91")]
		[FieldOffset(Offset = "0x18")]
		public bool isDead;

		// Token: 0x04033A92 RID: 211602
		[Token(Token = "0x4033A92")]
		[FieldOffset(Offset = "0x19")]
		public bool isHiddenBoss;

		// Token: 0x04033A93 RID: 211603
		[Token(Token = "0x4033A93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A94 RID: 211604
		[Token(Token = "0x4033A94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
