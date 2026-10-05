using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x02006424 RID: 25636
	[Token(Token = "0x2006424")]
	public class AutoChessBattleStoreInfo : IStreamDeserialize, IHotfixable
	{
		// Token: 0x06024EA5 RID: 151205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA5")]
		[Address(RVA = "0x1FB47C0", Offset = "0x1FB33C0", VA = "0x181FB47C0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024EA6 RID: 151206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024EA6")]
		[Address(RVA = "0x1FB4960", Offset = "0x1FB3560", VA = "0x181FB4960")]
		public AutoChessBattleStoreInfo()
		{
		}

		// Token: 0x04033A02 RID: 211458
		[Token(Token = "0x4033A02")]
		[FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x04033A03 RID: 211459
		[Token(Token = "0x4033A03")]
		[FieldOffset(Offset = "0x14")]
		public int coin;

		// Token: 0x04033A04 RID: 211460
		[Token(Token = "0x4033A04")]
		[FieldOffset(Offset = "0x18")]
		public int upgradePrice;

		// Token: 0x04033A05 RID: 211461
		[Token(Token = "0x4033A05")]
		[FieldOffset(Offset = "0x1C")]
		public int refreshPrice;

		// Token: 0x04033A06 RID: 211462
		[Token(Token = "0x4033A06")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessBattleShopGoodsType isSpecialGoods;

		// Token: 0x04033A07 RID: 211463
		[Token(Token = "0x4033A07")]
		[FieldOffset(Offset = "0x24")]
		public int freeRefreshCnt;

		// Token: 0x04033A08 RID: 211464
		[Token(Token = "0x4033A08")]
		[FieldOffset(Offset = "0x28")]
		public bool specialRefresh;

		// Token: 0x04033A09 RID: 211465
		[Token(Token = "0x4033A09")]
		[FieldOffset(Offset = "0x30")]
		public List<AutoChessBattleStoreGoodInfo> goods;

		// Token: 0x04033A0A RID: 211466
		[Token(Token = "0x4033A0A")]
		[FieldOffset(Offset = "0x38")]
		public int refreshSeq;

		// Token: 0x04033A0B RID: 211467
		[Token(Token = "0x4033A0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04033A0C RID: 211468
		[Token(Token = "0x4033A0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
