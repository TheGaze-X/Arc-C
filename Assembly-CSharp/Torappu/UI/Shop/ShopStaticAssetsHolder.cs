using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B58 RID: 23384
	[Token(Token = "0x2005B58")]
	public class ShopStaticAssetsHolder : PageSingleComponent
	{
		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x06021F28 RID: 139048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F71")]
		public SpriteHub priceTypeHub
		{
			[Token(Token = "0x6021F28")]
			[Address(RVA = "0x1C79BF0", Offset = "0x1C787F0", VA = "0x181C79BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021F29 RID: 139049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021F29")]
		[Address(RVA = "0x1C799B0", Offset = "0x1C785B0", VA = "0x181C799B0")]
		public static SpriteHub GetPriceTypeHub([Optional] State state)
		{
			return null;
		}

		// Token: 0x06021F2A RID: 139050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F2A")]
		[Address(RVA = "0x1C79B90", Offset = "0x1C78790", VA = "0x181C79B90")]
		public ShopStaticAssetsHolder()
		{
		}

		// Token: 0x0402E815 RID: 190485
		[Token(Token = "0x402E815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priceTypeHub;

		// Token: 0x0402E816 RID: 190486
		[Token(Token = "0x402E816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPriceTypeHub;

		// Token: 0x0402E817 RID: 190487
		[Token(Token = "0x402E817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
