using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002784 RID: 10116
	[Token(Token = "0x2002784")]
	public class AutoChessShopDataModel : AutoChessDataCenter.AutoChessDataModelBase
	{
		// Token: 0x0601082A RID: 67626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601082A")]
		[Address(RVA = "0x84E5B0", Offset = "0x84D1B0", VA = "0x18084E5B0")]
		public void UpdateData(ShopData dataModel)
		{
		}

		// Token: 0x0601082B RID: 67627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601082B")]
		[Address(RVA = "0x84E420", Offset = "0x84D020", VA = "0x18084E420")]
		public string GetSlotChessId(int slotId)
		{
			return null;
		}

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x0601082C RID: 67628 RVA: 0x00064B00 File Offset: 0x00062D00
		[Token(Token = "0x1700241A")]
		public bool allFrozen
		{
			[Token(Token = "0x601082C")]
			[Address(RVA = "0x84E7C0", Offset = "0x84D3C0", VA = "0x18084E7C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601082D RID: 67629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601082D")]
		[Address(RVA = "0x84E710", Offset = "0x84D310", VA = "0x18084E710")]
		public AutoChessShopDataModel()
		{
		}

		// Token: 0x04012848 RID: 75848
		[Token(Token = "0x4012848")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04012849 RID: 75849
		[Token(Token = "0x4012849")]
		[FieldOffset(Offset = "0x1C")]
		public int currentCoin;

		// Token: 0x0401284A RID: 75850
		[Token(Token = "0x401284A")]
		[FieldOffset(Offset = "0x20")]
		public int upgradePrice;

		// Token: 0x0401284B RID: 75851
		[Token(Token = "0x401284B")]
		[FieldOffset(Offset = "0x24")]
		public int refreshPrice;

		// Token: 0x0401284C RID: 75852
		[Token(Token = "0x401284C")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessBattleShopGoodsType goodsType;

		// Token: 0x0401284D RID: 75853
		[Token(Token = "0x401284D")]
		[FieldOffset(Offset = "0x2C")]
		public int freeRefreshCnt;

		// Token: 0x0401284E RID: 75854
		[Token(Token = "0x401284E")]
		[FieldOffset(Offset = "0x30")]
		public bool specialRefresh;

		// Token: 0x0401284F RID: 75855
		[Token(Token = "0x401284F")]
		[FieldOffset(Offset = "0x38")]
		public List<ChessGoods> chessGoods;

		// Token: 0x04012850 RID: 75856
		[Token(Token = "0x4012850")]
		[FieldOffset(Offset = "0x40")]
		public int refreshSeq;

		// Token: 0x04012851 RID: 75857
		[Token(Token = "0x4012851")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04012852 RID: 75858
		[Token(Token = "0x4012852")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSlotChessId;

		// Token: 0x04012853 RID: 75859
		[Token(Token = "0x4012853")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_allFrozen;

		// Token: 0x04012854 RID: 75860
		[Token(Token = "0x4012854")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
