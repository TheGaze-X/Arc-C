using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004104 RID: 16644
	[Token(Token = "0x2004104")]
	public class SandboxV2AdminShopItemDetailViewModel : IHotfixable
	{
		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06019BD3 RID: 105427 RVA: 0x0009F420 File Offset: 0x0009D620
		[Token(Token = "0x17003D61")]
		public bool canBuy
		{
			[Token(Token = "0x6019BD3")]
			[Address(RVA = "0x1293140", Offset = "0x1291D40", VA = "0x181293140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06019BD4 RID: 105428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BD4")]
		[Address(RVA = "0x12928F0", Offset = "0x12914F0", VA = "0x1812928F0")]
		public void LoadData(string topicId, int goodIndex, bool showGold, bool showDimensionCoin)
		{
		}

		// Token: 0x06019BD5 RID: 105429 RVA: 0x0009F438 File Offset: 0x0009D638
		[Token(Token = "0x6019BD5")]
		[Address(RVA = "0x1293000", Offset = "0x1291C00", VA = "0x181293000")]
		public bool TryIncreaseBuyCount()
		{
			return default(bool);
		}

		// Token: 0x06019BD6 RID: 105430 RVA: 0x0009F450 File Offset: 0x0009D650
		[Token(Token = "0x6019BD6")]
		[Address(RVA = "0x1292F80", Offset = "0x1291B80", VA = "0x181292F80")]
		public bool TryDecreaseBuyCount()
		{
			return default(bool);
		}

		// Token: 0x06019BD7 RID: 105431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BD7")]
		[Address(RVA = "0x1293080", Offset = "0x1291C80", VA = "0x181293080")]
		private void _UpdateCurrentCost()
		{
		}

		// Token: 0x06019BD8 RID: 105432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BD8")]
		[Address(RVA = "0x12930E0", Offset = "0x1291CE0", VA = "0x1812930E0")]
		public SandboxV2AdminShopItemDetailViewModel()
		{
		}

		// Token: 0x040203D2 RID: 132050
		[Token(Token = "0x40203D2")]
		private const int MIN_BUY_COUNT = 1;

		// Token: 0x040203D3 RID: 132051
		[Token(Token = "0x40203D3")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x040203D4 RID: 132052
		[Token(Token = "0x40203D4")]
		[FieldOffset(Offset = "0x18")]
		public int goodIndex;

		// Token: 0x040203D5 RID: 132053
		[Token(Token = "0x40203D5")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x040203D6 RID: 132054
		[Token(Token = "0x40203D6")]
		[FieldOffset(Offset = "0x28")]
		public string itemName;

		// Token: 0x040203D7 RID: 132055
		[Token(Token = "0x40203D7")]
		[FieldOffset(Offset = "0x30")]
		public int itemCount;

		// Token: 0x040203D8 RID: 132056
		[Token(Token = "0x40203D8")]
		[FieldOffset(Offset = "0x38")]
		public string itemUsage;

		// Token: 0x040203D9 RID: 132057
		[Token(Token = "0x40203D9")]
		[FieldOffset(Offset = "0x40")]
		public string itemDesc;

		// Token: 0x040203DA RID: 132058
		[Token(Token = "0x40203DA")]
		[FieldOffset(Offset = "0x48")]
		public int ownCount;

		// Token: 0x040203DB RID: 132059
		[Token(Token = "0x40203DB")]
		[FieldOffset(Offset = "0x4C")]
		public SandboxV2CoinType coinType;

		// Token: 0x040203DC RID: 132060
		[Token(Token = "0x40203DC")]
		[FieldOffset(Offset = "0x50")]
		public int originPrice;

		// Token: 0x040203DD RID: 132061
		[Token(Token = "0x40203DD")]
		[FieldOffset(Offset = "0x54")]
		public int currPrice;

		// Token: 0x040203DE RID: 132062
		[Token(Token = "0x40203DE")]
		[FieldOffset(Offset = "0x58")]
		public bool isDiscount;

		// Token: 0x040203DF RID: 132063
		[Token(Token = "0x40203DF")]
		[FieldOffset(Offset = "0x5C")]
		public int stock;

		// Token: 0x040203E0 RID: 132064
		[Token(Token = "0x40203E0")]
		[FieldOffset(Offset = "0x60")]
		public int buyCount;

		// Token: 0x040203E1 RID: 132065
		[Token(Token = "0x40203E1")]
		[FieldOffset(Offset = "0x64")]
		public int currentCost;

		// Token: 0x040203E2 RID: 132066
		[Token(Token = "0x40203E2")]
		[FieldOffset(Offset = "0x68")]
		public int goldCount;

		// Token: 0x040203E3 RID: 132067
		[Token(Token = "0x40203E3")]
		[FieldOffset(Offset = "0x70")]
		public string goldItemId;

		// Token: 0x040203E4 RID: 132068
		[Token(Token = "0x40203E4")]
		[FieldOffset(Offset = "0x78")]
		public int dimensionCoinCount;

		// Token: 0x040203E5 RID: 132069
		[Token(Token = "0x40203E5")]
		[FieldOffset(Offset = "0x80")]
		public string dimensionCoinItemId;

		// Token: 0x040203E6 RID: 132070
		[Token(Token = "0x40203E6")]
		[FieldOffset(Offset = "0x88")]
		public bool showGold;

		// Token: 0x040203E7 RID: 132071
		[Token(Token = "0x40203E7")]
		[FieldOffset(Offset = "0x89")]
		public bool showDimensionCoin;

		// Token: 0x040203E8 RID: 132072
		[Token(Token = "0x40203E8")]
		[FieldOffset(Offset = "0x8C")]
		public int canCostCoinCount;

		// Token: 0x040203E9 RID: 132073
		[Token(Token = "0x40203E9")]
		[FieldOffset(Offset = "0x90")]
		private string m_goodId;

		// Token: 0x040203EA RID: 132074
		[Token(Token = "0x40203EA")]
		[FieldOffset(Offset = "0x98")]
		private int m_canBuyMaxCount;

		// Token: 0x040203EB RID: 132075
		[Token(Token = "0x40203EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canBuy;

		// Token: 0x040203EC RID: 132076
		[Token(Token = "0x40203EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040203ED RID: 132077
		[Token(Token = "0x40203ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryIncreaseBuyCount;

		// Token: 0x040203EE RID: 132078
		[Token(Token = "0x40203EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryDecreaseBuyCount;

		// Token: 0x040203EF RID: 132079
		[Token(Token = "0x40203EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateCurrentCost;

		// Token: 0x040203F0 RID: 132080
		[Token(Token = "0x40203F0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
