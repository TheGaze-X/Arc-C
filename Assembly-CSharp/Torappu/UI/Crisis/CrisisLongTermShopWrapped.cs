using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059FE RID: 23038
	[Token(Token = "0x20059FE")]
	[Serializable]
	public class CrisisLongTermShopWrapped
	{
		// Token: 0x06021935 RID: 137525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021935")]
		[Address(RVA = "0x1C03A40", Offset = "0x1C02640", VA = "0x181C03A40")]
		public void CalcAvailCount()
		{
		}

		// Token: 0x06021936 RID: 137526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021936")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisLongTermShopWrapped()
		{
		}

		// Token: 0x0402DE0A RID: 187914
		[Token(Token = "0x402DE0A")]
		[FieldOffset(Offset = "0x10")]
		public CrisisLongTermShopItemData viewModel;

		// Token: 0x0402DE0B RID: 187915
		[Token(Token = "0x402DE0B")]
		[FieldOffset(Offset = "0x18")]
		public int buyCount;

		// Token: 0x0402DE0C RID: 187916
		[Token(Token = "0x402DE0C")]
		[FieldOffset(Offset = "0x1C")]
		public bool isTimeLimited;

		// Token: 0x0402DE0D RID: 187917
		[Token(Token = "0x402DE0D")]
		[FieldOffset(Offset = "0x20")]
		public PlayerGoodProgressData progressInfo;

		// Token: 0x0402DE0E RID: 187918
		[Token(Token = "0x402DE0E")]
		[FieldOffset(Offset = "0x28")]
		public List<CrisisProgressShopItemViewModel> progressViewModelList;

		// Token: 0x0402DE0F RID: 187919
		[Token(Token = "0x402DE0F")]
		[FieldOffset(Offset = "0x30")]
		public CrisisShopVer shopVer;

		// Token: 0x0402DE10 RID: 187920
		[Token(Token = "0x402DE10")]
		[FieldOffset(Offset = "0x34")]
		public int ableBuyCount;

		// Token: 0x0402DE11 RID: 187921
		[Token(Token = "0x402DE11")]
		[FieldOffset(Offset = "0x38")]
		public bool isUnique;
	}
}
