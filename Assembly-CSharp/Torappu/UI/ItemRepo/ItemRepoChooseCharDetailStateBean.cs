using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E96 RID: 24214
	[Token(Token = "0x2005E96")]
	public class ItemRepoChooseCharDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023149 RID: 143689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023149")]
		[Address(RVA = "0x1D90650", Offset = "0x1D8F250", VA = "0x181D90650")]
		public ItemRepoChooseCharDetailStateBean()
		{
		}

		// Token: 0x0403051D RID: 197917
		[Token(Token = "0x403051D")]
		[FieldOffset(Offset = "0x10")]
		[NonSerialized]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403051E RID: 197918
		[Token(Token = "0x403051E")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public string cacheCharId;

		// Token: 0x0403051F RID: 197919
		[Token(Token = "0x403051F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
