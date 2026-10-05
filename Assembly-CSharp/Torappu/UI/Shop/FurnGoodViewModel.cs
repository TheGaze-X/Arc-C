using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC5 RID: 23237
	[Token(Token = "0x2005AC5")]
	public class FurnGoodViewModel : IHotfixable
	{
		// Token: 0x06021C6F RID: 138351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C6F")]
		[Address(RVA = "0x1C2FBA0", Offset = "0x1C2E7A0", VA = "0x181C2FBA0")]
		public void InitData(BuildingGetFurnitureGoodListResponse.Good good)
		{
		}

		// Token: 0x06021C70 RID: 138352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C70")]
		[Address(RVA = "0x1C2FC90", Offset = "0x1C2E890", VA = "0x181C2FC90")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06021C71 RID: 138353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C71")]
		[Address(RVA = "0x1C2FE70", Offset = "0x1C2EA70", VA = "0x181C2FE70")]
		public FurnGoodViewModel()
		{
		}

		// Token: 0x0402E3B0 RID: 189360
		[Token(Token = "0x402E3B0")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0402E3B1 RID: 189361
		[Token(Token = "0x402E3B1")]
		[FieldOffset(Offset = "0x18")]
		public int sequence;

		// Token: 0x0402E3B2 RID: 189362
		[Token(Token = "0x402E3B2")]
		[FieldOffset(Offset = "0x20")]
		public BuildingGetFurnitureGoodListResponse.Good good;

		// Token: 0x0402E3B3 RID: 189363
		[Token(Token = "0x402E3B3")]
		[FieldOffset(Offset = "0x28")]
		public BuildingData.CustomData.FurnitureData furnitureData;

		// Token: 0x0402E3B4 RID: 189364
		[Token(Token = "0x402E3B4")]
		[FieldOffset(Offset = "0x30")]
		public int availCount;

		// Token: 0x0402E3B5 RID: 189365
		[Token(Token = "0x402E3B5")]
		[FieldOffset(Offset = "0x34")]
		public bool availFlag;

		// Token: 0x0402E3B6 RID: 189366
		[Token(Token = "0x402E3B6")]
		[FieldOffset(Offset = "0x35")]
		public bool alreadyHave;

		// Token: 0x0402E3B7 RID: 189367
		[Token(Token = "0x402E3B7")]
		[FieldOffset(Offset = "0x36")]
		public bool soldOut;

		// Token: 0x0402E3B8 RID: 189368
		[Token(Token = "0x402E3B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402E3B9 RID: 189369
		[Token(Token = "0x402E3B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0402E3BA RID: 189370
		[Token(Token = "0x402E3BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
