using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC3 RID: 23235
	[Token(Token = "0x2005AC3")]
	public class FurnGroupViewModel
	{
		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x06021C68 RID: 138344 RVA: 0x000BB3C8 File Offset: 0x000B95C8
		[Token(Token = "0x17004F17")]
		public bool alreadyHave
		{
			[Token(Token = "0x6021C68")]
			[Address(RVA = "0x1C30FB0", Offset = "0x1C2FBB0", VA = "0x181C30FB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06021C69 RID: 138345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C69")]
		[Address(RVA = "0x1C309A0", Offset = "0x1C2F5A0", VA = "0x181C309A0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06021C6A RID: 138346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C6A")]
		[Address(RVA = "0x1C2FED0", Offset = "0x1C2EAD0", VA = "0x181C2FED0")]
		public void InitData(BuildingGetFurnitureGoodListResponse.Group iGroupData, List<BuildingGetFurnitureGoodListResponse.Good> goodList)
		{
		}

		// Token: 0x06021C6B RID: 138347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C6B")]
		[Address(RVA = "0x1C30F20", Offset = "0x1C2FB20", VA = "0x181C30F20")]
		public FurnGroupViewModel()
		{
		}

		// Token: 0x0402E39B RID: 189339
		[Token(Token = "0x402E39B")]
		private const int INITGROUPMAX = 99;

		// Token: 0x0402E39C RID: 189340
		[Token(Token = "0x402E39C")]
		[FieldOffset(Offset = "0x10")]
		public int maxGroup;

		// Token: 0x0402E39D RID: 189341
		[Token(Token = "0x402E39D")]
		[FieldOffset(Offset = "0x14")]
		public int currentGroup;

		// Token: 0x0402E39E RID: 189342
		[Token(Token = "0x402E39E")]
		[FieldOffset(Offset = "0x18")]
		public int totalDiamondPrice;

		// Token: 0x0402E39F RID: 189343
		[Token(Token = "0x402E39F")]
		[FieldOffset(Offset = "0x1C")]
		public int totalCoinPrice;

		// Token: 0x0402E3A0 RID: 189344
		[Token(Token = "0x402E3A0")]
		[FieldOffset(Offset = "0x20")]
		public int allDiamondPrice;

		// Token: 0x0402E3A1 RID: 189345
		[Token(Token = "0x402E3A1")]
		[FieldOffset(Offset = "0x24")]
		public int allCoinPrice;

		// Token: 0x0402E3A2 RID: 189346
		[Token(Token = "0x402E3A2")]
		[FieldOffset(Offset = "0x28")]
		public int totalAtmos;

		// Token: 0x0402E3A3 RID: 189347
		[Token(Token = "0x402E3A3")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, List<FurnGroupViewModel.FurnCurrentInfoViewModel>> goodList;

		// Token: 0x0402E3A4 RID: 189348
		[Token(Token = "0x402E3A4")]
		[FieldOffset(Offset = "0x38")]
		public BuildingGetFurnitureGoodListResponse.Group groupData;

		// Token: 0x02005AC4 RID: 23236
		[Token(Token = "0x2005AC4")]
		public class FurnCurrentInfoViewModel
		{
			// Token: 0x17004F18 RID: 20248
			// (get) Token: 0x06021C6C RID: 138348 RVA: 0x000BB3E0 File Offset: 0x000B95E0
			// (set) Token: 0x06021C6D RID: 138349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004F18")]
			public int perCountWrapped
			{
				[Token(Token = "0x6021C6C")]
				[Address(RVA = "0x1C2FB90", Offset = "0x1C2E790", VA = "0x181C2FB90")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6021C6D")]
				[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
				set
				{
				}
			}

			// Token: 0x06021C6E RID: 138350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021C6E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FurnCurrentInfoViewModel()
			{
			}

			// Token: 0x0402E3A5 RID: 189349
			[Token(Token = "0x402E3A5")]
			[FieldOffset(Offset = "0x10")]
			public string goodId;

			// Token: 0x0402E3A6 RID: 189350
			[Token(Token = "0x402E3A6")]
			[FieldOffset(Offset = "0x18")]
			public string furnName;

			// Token: 0x0402E3A7 RID: 189351
			[Token(Token = "0x402E3A7")]
			[FieldOffset(Offset = "0x20")]
			public string setName;

			// Token: 0x0402E3A8 RID: 189352
			[Token(Token = "0x402E3A8")]
			[FieldOffset(Offset = "0x28")]
			public string furnId;

			// Token: 0x0402E3A9 RID: 189353
			[Token(Token = "0x402E3A9")]
			[FieldOffset(Offset = "0x30")]
			public int currentCount;

			// Token: 0x0402E3AA RID: 189354
			[Token(Token = "0x402E3AA")]
			[FieldOffset(Offset = "0x34")]
			public int remainCount;

			// Token: 0x0402E3AB RID: 189355
			[Token(Token = "0x402E3AB")]
			[FieldOffset(Offset = "0x38")]
			public int diamondPrice;

			// Token: 0x0402E3AC RID: 189356
			[Token(Token = "0x402E3AC")]
			[FieldOffset(Offset = "0x3C")]
			public int furnCoinPrice;

			// Token: 0x0402E3AD RID: 189357
			[Token(Token = "0x402E3AD")]
			[FieldOffset(Offset = "0x40")]
			public bool ableToBuy;

			// Token: 0x0402E3AE RID: 189358
			[Token(Token = "0x402E3AE")]
			[FieldOffset(Offset = "0x44")]
			public int buyCount;

			// Token: 0x0402E3AF RID: 189359
			[Token(Token = "0x402E3AF")]
			[FieldOffset(Offset = "0x48")]
			private int m_perCount;
		}
	}
}
