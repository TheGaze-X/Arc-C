using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005619 RID: 22041
	[Token(Token = "0x2005619")]
	public class RL05ShopGoodsViewModelPlugin : RoguelikeGameShopViewModelPlugin
	{
		// Token: 0x17004BBA RID: 19386
		// (get) Token: 0x06020556 RID: 132438 RVA: 0x000B5728 File Offset: 0x000B3928
		[Token(Token = "0x17004BBA")]
		public override bool canRefresh
		{
			[Token(Token = "0x6020556")]
			[Address(RVA = "0x1A7F5A0", Offset = "0x1A7E1A0", VA = "0x181A7F5A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004BBB RID: 19387
		// (get) Token: 0x06020557 RID: 132439 RVA: 0x000B5740 File Offset: 0x000B3940
		[Token(Token = "0x17004BBB")]
		public override bool showRefreshBtn
		{
			[Token(Token = "0x6020557")]
			[Address(RVA = "0x1A7F610", Offset = "0x1A7E210", VA = "0x181A7F610", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020558 RID: 132440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020558")]
		[Address(RVA = "0x1A7F290", Offset = "0x1A7DE90", VA = "0x181A7F290", Slot = "11")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x06020559 RID: 132441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020559")]
		[Address(RVA = "0x1A7F350", Offset = "0x1A7DF50", VA = "0x181A7F350", Slot = "14")]
		public override void OnShopRefreshed(RoguelikeShopStateBean stateBean)
		{
		}

		// Token: 0x0602055A RID: 132442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602055A")]
		[Address(RVA = "0x1A7F3F0", Offset = "0x1A7DFF0", VA = "0x181A7F3F0", Slot = "15")]
		public override void PostProcessSellGoods(List<RoguelikeGoodsViewModel> sellGoodsList)
		{
		}

		// Token: 0x0602055B RID: 132443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602055B")]
		[Address(RVA = "0x1A7F540", Offset = "0x1A7E140", VA = "0x181A7F540")]
		public RL05ShopGoodsViewModelPlugin()
		{
		}

		// Token: 0x0602055C RID: 132444 RVA: 0x000B5758 File Offset: 0x000B3958
		[Token(Token = "0x602055C")]
		[Address(RVA = "0x1A7F520", Offset = "0x1A7E120", VA = "0x181A7F520")]
		private bool <>xLuaBaseProxy_get_canRefresh()
		{
			return default(bool);
		}

		// Token: 0x0602055D RID: 132445 RVA: 0x000B5770 File Offset: 0x000B3970
		[Token(Token = "0x602055D")]
		[Address(RVA = "0x1A7F530", Offset = "0x1A7E130", VA = "0x181A7F530")]
		private bool <>xLuaBaseProxy_get_showRefreshBtn()
		{
			return default(bool);
		}

		// Token: 0x0602055E RID: 132446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602055E")]
		[Address(RVA = "0x1A7F4F0", Offset = "0x1A7E0F0", VA = "0x181A7F4F0")]
		private void <>xLuaBaseProxy_LoadData(string P0, PlayerRoguelikePendingEvent.ShopContent P1, PlayerRoguelikeV2.CurrentData P2)
		{
		}

		// Token: 0x0602055F RID: 132447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602055F")]
		[Address(RVA = "0x1A7F500", Offset = "0x1A7E100", VA = "0x181A7F500")]
		private void <>xLuaBaseProxy_OnShopRefreshed(RoguelikeShopStateBean P0)
		{
		}

		// Token: 0x06020560 RID: 132448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020560")]
		[Address(RVA = "0x1A7F510", Offset = "0x1A7E110", VA = "0x181A7F510")]
		private void <>xLuaBaseProxy_PostProcessSellGoods(List<RoguelikeGoodsViewModel> P0)
		{
		}

		// Token: 0x0402BC3A RID: 179258
		[Token(Token = "0x402BC3A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasBoss;

		// Token: 0x0402BC3B RID: 179259
		[Token(Token = "0x402BC3B")]
		[FieldOffset(Offset = "0x39")]
		private bool m_hasRefreshBuffUnlock;

		// Token: 0x0402BC3C RID: 179260
		[Token(Token = "0x402BC3C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x0402BC3D RID: 179261
		[Token(Token = "0x402BC3D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_showRefreshBtn;

		// Token: 0x0402BC3E RID: 179262
		[Token(Token = "0x402BC3E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BC3F RID: 179263
		[Token(Token = "0x402BC3F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShopRefreshed;

		// Token: 0x0402BC40 RID: 179264
		[Token(Token = "0x402BC40")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PostProcessSellGoods;

		// Token: 0x0402BC41 RID: 179265
		[Token(Token = "0x402BC41")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
