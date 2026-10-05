using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A9A RID: 23194
	[Token(Token = "0x2005A9A")]
	public class ShopDetailChooseGPState : ShopDetailCommonState
	{
		// Token: 0x06021BA8 RID: 138152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BA8")]
		[Address(RVA = "0x1C1F570", Offset = "0x1C1E170", VA = "0x181C1F570")]
		public void OnTransToDetail(ChooseGiftPackageShopOption option)
		{
		}

		// Token: 0x06021BA9 RID: 138153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BA9")]
		[Address(RVA = "0x1C1F7B0", Offset = "0x1C1E3B0", VA = "0x181C1F7B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06021BAA RID: 138154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021BAA")]
		[Address(RVA = "0x1C1FAD0", Offset = "0x1C1E6D0", VA = "0x181C1FAD0")]
		public ShopDetailChooseGPState()
		{
		}

		// Token: 0x06021BAD RID: 138157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021BAD")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402E23B RID: 188987
		[Token(Token = "0x402E23B")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public CharGachaVoucherData cacheData;

		// Token: 0x0402E23C RID: 188988
		[Token(Token = "0x402E23C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTransToDetail;

		// Token: 0x0402E23D RID: 188989
		[Token(Token = "0x402E23D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402E23E RID: 188990
		[Token(Token = "0x402E23E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
