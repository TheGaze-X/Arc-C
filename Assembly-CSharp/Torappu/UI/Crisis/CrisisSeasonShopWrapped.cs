using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059FF RID: 23039
	[Token(Token = "0x20059FF")]
	[Serializable]
	public class CrisisSeasonShopWrapped
	{
		// Token: 0x06021937 RID: 137527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021937")]
		[Address(RVA = "0x1C04740", Offset = "0x1C03340", VA = "0x181C04740")]
		public void CalcAvailCount()
		{
		}

		// Token: 0x06021938 RID: 137528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021938")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisSeasonShopWrapped()
		{
		}

		// Token: 0x0402DE12 RID: 187922
		[Token(Token = "0x402DE12")]
		[FieldOffset(Offset = "0x10")]
		public CrisisSeasonShopItemData viewModel;

		// Token: 0x0402DE13 RID: 187923
		[Token(Token = "0x402DE13")]
		[FieldOffset(Offset = "0x18")]
		public int buyCount;

		// Token: 0x0402DE14 RID: 187924
		[Token(Token = "0x402DE14")]
		[FieldOffset(Offset = "0x20")]
		public PlayerGoodProgressData progressInfo;

		// Token: 0x0402DE15 RID: 187925
		[Token(Token = "0x402DE15")]
		[FieldOffset(Offset = "0x28")]
		public List<CrisisProgressShopItemViewModel> progressViewModelList;

		// Token: 0x0402DE16 RID: 187926
		[Token(Token = "0x402DE16")]
		[FieldOffset(Offset = "0x30")]
		public CrisisShopVer shopVer;

		// Token: 0x0402DE17 RID: 187927
		[Token(Token = "0x402DE17")]
		[FieldOffset(Offset = "0x34")]
		public int ableBuyCount;

		// Token: 0x0402DE18 RID: 187928
		[Token(Token = "0x402DE18")]
		[FieldOffset(Offset = "0x38")]
		public bool isUnique;
	}
}
