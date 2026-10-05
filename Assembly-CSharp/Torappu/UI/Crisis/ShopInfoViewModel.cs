using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A01 RID: 23041
	[Token(Token = "0x2005A01")]
	[Serializable]
	public class ShopInfoViewModel : IHotfixable
	{
		// Token: 0x06021939 RID: 137529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021939")]
		[Address(RVA = "0x1C0ED80", Offset = "0x1C0D980", VA = "0x181C0ED80")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0602193A RID: 137530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602193A")]
		[Address(RVA = "0x1C0F3D0", Offset = "0x1C0DFD0", VA = "0x181C0F3D0")]
		public ShopInfoViewModel()
		{
		}

		// Token: 0x0402DE1C RID: 187932
		[Token(Token = "0x402DE1C")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402DE1D RID: 187933
		[Token(Token = "0x402DE1D")]
		[FieldOffset(Offset = "0x18")]
		public bool isFirstTimeToRender;

		// Token: 0x0402DE1E RID: 187934
		[Token(Token = "0x402DE1E")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisLongTermShopWrapped> longTermShopList;

		// Token: 0x0402DE1F RID: 187935
		[Token(Token = "0x402DE1F")]
		[FieldOffset(Offset = "0x28")]
		public List<CrisisSeasonShopWrapped> seasonShopList;

		// Token: 0x0402DE20 RID: 187936
		[Token(Token = "0x402DE20")]
		[FieldOffset(Offset = "0x30")]
		public CrisisShopVer shopVer;

		// Token: 0x0402DE21 RID: 187937
		[Token(Token = "0x402DE21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0402DE22 RID: 187938
		[Token(Token = "0x402DE22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
