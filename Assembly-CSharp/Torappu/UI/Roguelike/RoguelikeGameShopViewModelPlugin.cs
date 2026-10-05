using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054E5 RID: 21733
	[Token(Token = "0x20054E5")]
	public abstract class RoguelikeGameShopViewModelPlugin : IHotfixable
	{
		// Token: 0x17004ADB RID: 19163
		// (get) Token: 0x0601FF66 RID: 130918 RVA: 0x000B3EE0 File Offset: 0x000B20E0
		[Token(Token = "0x17004ADB")]
		public virtual bool canRefresh
		{
			[Token(Token = "0x601FF66")]
			[Address(RVA = "0x1A107F0", Offset = "0x1A0F3F0", VA = "0x181A107F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004ADC RID: 19164
		// (get) Token: 0x0601FF67 RID: 130919 RVA: 0x000B3EF8 File Offset: 0x000B20F8
		[Token(Token = "0x17004ADC")]
		public bool refreshCountValid
		{
			[Token(Token = "0x601FF67")]
			[Address(RVA = "0x1A10D30", Offset = "0x1A0F930", VA = "0x181A10D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004ADD RID: 19165
		// (get) Token: 0x0601FF68 RID: 130920 RVA: 0x000B3F10 File Offset: 0x000B2110
		[Token(Token = "0x17004ADD")]
		public bool refreshCostValid
		{
			[Token(Token = "0x601FF68")]
			[Address(RVA = "0x1A10CC0", Offset = "0x1A0F8C0", VA = "0x181A10CC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004ADE RID: 19166
		// (get) Token: 0x0601FF69 RID: 130921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004ADE")]
		public string refreshCostId
		{
			[Token(Token = "0x601FF69")]
			[Address(RVA = "0x1A10C60", Offset = "0x1A0F860", VA = "0x181A10C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004ADF RID: 19167
		// (get) Token: 0x0601FF6A RID: 130922 RVA: 0x000B3F28 File Offset: 0x000B2128
		[Token(Token = "0x17004ADF")]
		public int refreshCostCount
		{
			[Token(Token = "0x601FF6A")]
			[Address(RVA = "0x1A10C00", Offset = "0x1A0F800", VA = "0x181A10C00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004AE0 RID: 19168
		// (get) Token: 0x0601FF6B RID: 130923 RVA: 0x000B3F40 File Offset: 0x000B2140
		[Token(Token = "0x17004AE0")]
		public virtual bool showRefreshBtn
		{
			[Token(Token = "0x601FF6B")]
			[Address(RVA = "0x1A10D90", Offset = "0x1A0F990", VA = "0x181A10D90", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004AE1 RID: 19169
		// (get) Token: 0x0601FF6C RID: 130924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AE1")]
		public virtual string refreshConfirmTipWithoutCost
		{
			[Token(Token = "0x601FF6C")]
			[Address(RVA = "0x1A10B80", Offset = "0x1A0F780", VA = "0x181A10B80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE2 RID: 19170
		// (get) Token: 0x0601FF6D RID: 130925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AE2")]
		public virtual string refreshConfirmTipWithCostFree
		{
			[Token(Token = "0x601FF6D")]
			[Address(RVA = "0x1A109C0", Offset = "0x1A0F5C0", VA = "0x181A109C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE3 RID: 19171
		// (get) Token: 0x0601FF6E RID: 130926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AE3")]
		public virtual string refreshConfirmTipWithCost
		{
			[Token(Token = "0x601FF6E")]
			[Address(RVA = "0x1A10A60", Offset = "0x1A0F660", VA = "0x181A10A60", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE4 RID: 19172
		// (get) Token: 0x0601FF6F RID: 130927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AE4")]
		public virtual string refreshConfirmRemainCount
		{
			[Token(Token = "0x601FF6F")]
			[Address(RVA = "0x1A10900", Offset = "0x1A0F500", VA = "0x181A10900", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004AE5 RID: 19173
		// (get) Token: 0x0601FF70 RID: 130928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004AE5")]
		public virtual Dictionary<string, RoguelikeGoodsViewModel> preloadedRecycleGoods
		{
			[Token(Token = "0x601FF70")]
			[Address(RVA = "0x1A108A0", Offset = "0x1A0F4A0", VA = "0x181A108A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601FF71 RID: 130929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF71")]
		[Address(RVA = "0x1A104E0", Offset = "0x1A0F0E0", VA = "0x181A104E0", Slot = "11")]
		public virtual void LoadData(string topicId, PlayerRoguelikePendingEvent.ShopContent shopPlayerData, PlayerRoguelikeV2.CurrentData current)
		{
		}

		// Token: 0x0601FF72 RID: 130930 RVA: 0x000B3F58 File Offset: 0x000B2158
		[Token(Token = "0x601FF72")]
		[Address(RVA = "0x1A103E0", Offset = "0x1A0EFE0", VA = "0x181A103E0", Slot = "12")]
		public virtual bool GetCannotRefreshToast(out string cantToast)
		{
			return default(bool);
		}

		// Token: 0x0601FF73 RID: 130931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF73")]
		[Address(RVA = "0x1A10310", Offset = "0x1A0EF10", VA = "0x181A10310", Slot = "13")]
		public virtual void EventOnLockSlotClicked(RoguelikeGoodsViewModel viewModel)
		{
		}

		// Token: 0x0601FF74 RID: 130932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF74")]
		[Address(RVA = "0x1A10670", Offset = "0x1A0F270", VA = "0x181A10670", Slot = "14")]
		public virtual void OnShopRefreshed(RoguelikeShopStateBean stateBean)
		{
		}

		// Token: 0x0601FF75 RID: 130933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF75")]
		[Address(RVA = "0x1A10730", Offset = "0x1A0F330", VA = "0x181A10730", Slot = "15")]
		public virtual void PostProcessSellGoods(List<RoguelikeGoodsViewModel> sellGoodsList)
		{
		}

		// Token: 0x0601FF76 RID: 130934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF76")]
		[Address(RVA = "0x1A106D0", Offset = "0x1A0F2D0", VA = "0x181A106D0", Slot = "16")]
		public virtual void PostProcessRecycleGoods(List<RoguelikeGoodsViewModel> recycleGoodsList)
		{
		}

		// Token: 0x0601FF77 RID: 130935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF77")]
		[Address(RVA = "0x1A10790", Offset = "0x1A0F390", VA = "0x181A10790")]
		protected RoguelikeGameShopViewModelPlugin()
		{
		}

		// Token: 0x0402B1E6 RID: 176614
		[Token(Token = "0x402B1E6")]
		[FieldOffset(Offset = "0x10")]
		private string m_topicId;

		// Token: 0x0402B1E7 RID: 176615
		[Token(Token = "0x402B1E7")]
		[FieldOffset(Offset = "0x18")]
		private int m_refreshCount;

		// Token: 0x0402B1E8 RID: 176616
		[Token(Token = "0x402B1E8")]
		[FieldOffset(Offset = "0x20")]
		private string m_refreshCostId;

		// Token: 0x0402B1E9 RID: 176617
		[Token(Token = "0x402B1E9")]
		[FieldOffset(Offset = "0x28")]
		private string m_refreshCostName;

		// Token: 0x0402B1EA RID: 176618
		[Token(Token = "0x402B1EA")]
		[FieldOffset(Offset = "0x30")]
		private int m_refreshCostCount;

		// Token: 0x0402B1EB RID: 176619
		[Token(Token = "0x402B1EB")]
		[FieldOffset(Offset = "0x34")]
		private bool m_refreshCostValid;

		// Token: 0x0402B1EC RID: 176620
		[Token(Token = "0x402B1EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canRefresh;

		// Token: 0x0402B1ED RID: 176621
		[Token(Token = "0x402B1ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_refreshCountValid;

		// Token: 0x0402B1EE RID: 176622
		[Token(Token = "0x402B1EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_refreshCostValid;

		// Token: 0x0402B1EF RID: 176623
		[Token(Token = "0x402B1EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_refreshCostId;

		// Token: 0x0402B1F0 RID: 176624
		[Token(Token = "0x402B1F0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_refreshCostCount;

		// Token: 0x0402B1F1 RID: 176625
		[Token(Token = "0x402B1F1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_showRefreshBtn;

		// Token: 0x0402B1F2 RID: 176626
		[Token(Token = "0x402B1F2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithoutCost;

		// Token: 0x0402B1F3 RID: 176627
		[Token(Token = "0x402B1F3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithCostFree;

		// Token: 0x0402B1F4 RID: 176628
		[Token(Token = "0x402B1F4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmTipWithCost;

		// Token: 0x0402B1F5 RID: 176629
		[Token(Token = "0x402B1F5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_refreshConfirmRemainCount;

		// Token: 0x0402B1F6 RID: 176630
		[Token(Token = "0x402B1F6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_preloadedRecycleGoods;

		// Token: 0x0402B1F7 RID: 176631
		[Token(Token = "0x402B1F7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B1F8 RID: 176632
		[Token(Token = "0x402B1F8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCannotRefreshToast;

		// Token: 0x0402B1F9 RID: 176633
		[Token(Token = "0x402B1F9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnLockSlotClicked;

		// Token: 0x0402B1FA RID: 176634
		[Token(Token = "0x402B1FA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnShopRefreshed;

		// Token: 0x0402B1FB RID: 176635
		[Token(Token = "0x402B1FB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_PostProcessSellGoods;

		// Token: 0x0402B1FC RID: 176636
		[Token(Token = "0x402B1FC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PostProcessRecycleGoods;

		// Token: 0x0402B1FD RID: 176637
		[Token(Token = "0x402B1FD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
