using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D0C RID: 19724
	[Token(Token = "0x2004D0C")]
	public class GrocerySellResultStateSellViewModel : IHotfixable
	{
		// Token: 0x0601D8F5 RID: 121077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8F5")]
		[Address(RVA = "0x17189E0", Offset = "0x17175E0", VA = "0x1817189E0")]
		public GrocerySellResultStateSellViewModel.SellInfo GetPlayerSellInfo()
		{
			return null;
		}

		// Token: 0x0601D8F6 RID: 121078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8F6")]
		[Address(RVA = "0x1718AD0", Offset = "0x17176D0", VA = "0x181718AD0")]
		public void LoadStateSellData(string actId, string goodId)
		{
		}

		// Token: 0x0601D8F7 RID: 121079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8F7")]
		[Address(RVA = "0x1719190", Offset = "0x1717D90", VA = "0x181719190")]
		public GrocerySellResultStateSellViewModel()
		{
		}

		// Token: 0x04027064 RID: 159844
		[Token(Token = "0x4027064")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04027065 RID: 159845
		[Token(Token = "0x4027065")]
		[FieldOffset(Offset = "0x18")]
		public string goodIconId;

		// Token: 0x04027066 RID: 159846
		[Token(Token = "0x4027066")]
		[FieldOffset(Offset = "0x20")]
		public string goodName;

		// Token: 0x04027067 RID: 159847
		[Token(Token = "0x4027067")]
		[FieldOffset(Offset = "0x28")]
		public int totalIncome;

		// Token: 0x04027068 RID: 159848
		[Token(Token = "0x4027068")]
		[FieldOffset(Offset = "0x30")]
		public GrocerySellResultStateSellViewModel.PlayerPurchaseInfo playerPurchaseInfo;

		// Token: 0x04027069 RID: 159849
		[Token(Token = "0x4027069")]
		[FieldOffset(Offset = "0x38")]
		public List<GrocerySellResultStateSellViewModel.SellInfo> sellInfos;

		// Token: 0x0402706A RID: 159850
		[Token(Token = "0x402706A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlayerSellInfo;

		// Token: 0x0402706B RID: 159851
		[Token(Token = "0x402706B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadStateSellData;

		// Token: 0x0402706C RID: 159852
		[Token(Token = "0x402706C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D0D RID: 19725
		[Token(Token = "0x2004D0D")]
		public class PlayerPurchaseInfo : IHotfixable
		{
			// Token: 0x0601D8F8 RID: 121080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8F8")]
			[Address(RVA = "0x1722410", Offset = "0x1721010", VA = "0x181722410")]
			public PlayerPurchaseInfo()
			{
			}

			// Token: 0x0402706D RID: 159853
			[Token(Token = "0x402706D")]
			[FieldOffset(Offset = "0x10")]
			public int purchaseCost;

			// Token: 0x0402706E RID: 159854
			[Token(Token = "0x402706E")]
			[FieldOffset(Offset = "0x14")]
			public int purchaseCount;

			// Token: 0x0402706F RID: 159855
			[Token(Token = "0x402706F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004D0E RID: 19726
		[Token(Token = "0x2004D0E")]
		public class SellInfo : IHotfixable, IComparable
		{
			// Token: 0x17004569 RID: 17769
			// (get) Token: 0x0601D8F9 RID: 121081 RVA: 0x000ABF30 File Offset: 0x000AA130
			[Token(Token = "0x17004569")]
			public bool isPlayerSoldOut
			{
				[Token(Token = "0x601D8F9")]
				[Address(RVA = "0x17229F0", Offset = "0x17215F0", VA = "0x1817229F0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700456A RID: 17770
			// (get) Token: 0x0601D8FA RID: 121082 RVA: 0x000ABF48 File Offset: 0x000AA148
			[Token(Token = "0x1700456A")]
			public int income
			{
				[Token(Token = "0x601D8FA")]
				[Address(RVA = "0x1722990", Offset = "0x1721590", VA = "0x181722990")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D8FB RID: 121083 RVA: 0x000ABF60 File Offset: 0x000AA160
			[Token(Token = "0x601D8FB")]
			[Address(RVA = "0x1722780", Offset = "0x1721380", VA = "0x181722780", Slot = "4")]
			public int CompareTo(object obj)
			{
				return 0;
			}

			// Token: 0x0601D8FC RID: 121084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D8FC")]
			[Address(RVA = "0x1722930", Offset = "0x1721530", VA = "0x181722930")]
			public SellInfo()
			{
			}

			// Token: 0x04027070 RID: 159856
			[Token(Token = "0x4027070")]
			[FieldOffset(Offset = "0x10")]
			public string shopId;

			// Token: 0x04027071 RID: 159857
			[Token(Token = "0x4027071")]
			[FieldOffset(Offset = "0x18")]
			public string shopIconId;

			// Token: 0x04027072 RID: 159858
			[Token(Token = "0x4027072")]
			[FieldOffset(Offset = "0x20")]
			public int sellPrice;

			// Token: 0x04027073 RID: 159859
			[Token(Token = "0x4027073")]
			[FieldOffset(Offset = "0x24")]
			public int sellCount;

			// Token: 0x04027074 RID: 159860
			[Token(Token = "0x4027074")]
			[FieldOffset(Offset = "0x28")]
			public int stockCount;

			// Token: 0x04027075 RID: 159861
			[Token(Token = "0x4027075")]
			[FieldOffset(Offset = "0x2C")]
			public int prizeReward;

			// Token: 0x04027076 RID: 159862
			[Token(Token = "0x4027076")]
			[FieldOffset(Offset = "0x30")]
			public bool isPlayer;

			// Token: 0x04027077 RID: 159863
			[Token(Token = "0x4027077")]
			[FieldOffset(Offset = "0x34")]
			public int sortId;

			// Token: 0x04027078 RID: 159864
			[Token(Token = "0x4027078")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isPlayerSoldOut;

			// Token: 0x04027079 RID: 159865
			[Token(Token = "0x4027079")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_income;

			// Token: 0x0402707A RID: 159866
			[Token(Token = "0x402707A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0402707B RID: 159867
			[Token(Token = "0x402707B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
