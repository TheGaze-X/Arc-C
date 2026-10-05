using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200618E RID: 24974
	[Token(Token = "0x200618E")]
	public class BossRushRelicUpgradeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06024069 RID: 147561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024069")]
		[Address(RVA = "0x1EA7D00", Offset = "0x1EA6900", VA = "0x181EA7D00")]
		public void LoadData()
		{
		}

		// Token: 0x0602406A RID: 147562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602406A")]
		[Address(RVA = "0x1EA7FC0", Offset = "0x1EA6BC0", VA = "0x181EA7FC0")]
		public BossRushRelicUpgradeStateBean()
		{
		}

		// Token: 0x040320CB RID: 205003
		[Token(Token = "0x40320CB")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x040320CC RID: 205004
		[Token(Token = "0x40320CC")]
		[FieldOffset(Offset = "0x18")]
		public BossRushRelicUpgradeViewProperty viewProperty;

		// Token: 0x040320CD RID: 205005
		[Token(Token = "0x40320CD")]
		[FieldOffset(Offset = "0x20")]
		public BossRushRelicNodeModel relicData;

		// Token: 0x040320CE RID: 205006
		[Token(Token = "0x40320CE")]
		[FieldOffset(Offset = "0x28")]
		public string tokenName;

		// Token: 0x040320CF RID: 205007
		[Token(Token = "0x40320CF")]
		[FieldOffset(Offset = "0x30")]
		public int tokenCount;

		// Token: 0x040320D0 RID: 205008
		[Token(Token = "0x40320D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040320D1 RID: 205009
		[Token(Token = "0x40320D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
