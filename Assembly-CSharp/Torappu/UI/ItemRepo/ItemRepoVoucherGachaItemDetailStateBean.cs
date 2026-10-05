using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E65 RID: 24165
	[Token(Token = "0x2005E65")]
	public class ItemRepoVoucherGachaItemDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023042 RID: 143426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023042")]
		[Address(RVA = "0x1D88700", Offset = "0x1D87300", VA = "0x181D88700")]
		public ItemRepoVoucherGachaItemDetailStateBean()
		{
		}

		// Token: 0x040303AA RID: 197546
		[Token(Token = "0x40303AA")]
		[FieldOffset(Offset = "0x10")]
		public ItemVoucherData cacheItemData;

		// Token: 0x040303AB RID: 197547
		[Token(Token = "0x40303AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
