using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x020059F4 RID: 23028
	[Token(Token = "0x20059F4")]
	public class CrisisShopDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004ED5 RID: 20181
		// (get) Token: 0x060218F5 RID: 137461 RVA: 0x000BAC18 File Offset: 0x000B8E18
		[Token(Token = "0x17004ED5")]
		public int coin
		{
			[Token(Token = "0x60218F5")]
			[Address(RVA = "0x1C05580", Offset = "0x1C04180", VA = "0x181C05580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060218F6 RID: 137462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60218F6")]
		[Address(RVA = "0x1C05520", Offset = "0x1C04120", VA = "0x181C05520")]
		public CrisisShopDetailStateBean()
		{
		}

		// Token: 0x0402DDD0 RID: 187856
		[Token(Token = "0x402DDD0")]
		[FieldOffset(Offset = "0x10")]
		public CrisisShopVer shopVer;

		// Token: 0x0402DDD1 RID: 187857
		[Token(Token = "0x402DDD1")]
		[FieldOffset(Offset = "0x18")]
		public CrisisShopWrapped shopViewModel;

		// Token: 0x0402DDD2 RID: 187858
		[Token(Token = "0x402DDD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_coin;

		// Token: 0x0402DDD3 RID: 187859
		[Token(Token = "0x402DDD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
