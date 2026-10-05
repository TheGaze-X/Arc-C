using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E85 RID: 24197
	[Token(Token = "0x2005E85")]
	public class ItemRepoUseVoucherItemStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06023110 RID: 143632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023110")]
		[Address(RVA = "0x1DA2E20", Offset = "0x1DA1A20", VA = "0x181DA2E20")]
		public ItemRepoUseVoucherItemStateBean()
		{
		}

		// Token: 0x040304AA RID: 197802
		[Token(Token = "0x40304AA")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIItemViewModel itemViewModel;

		// Token: 0x040304AB RID: 197803
		[Token(Token = "0x40304AB")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public ItemVoucherData cacheItemData;

		// Token: 0x040304AC RID: 197804
		[Token(Token = "0x40304AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
