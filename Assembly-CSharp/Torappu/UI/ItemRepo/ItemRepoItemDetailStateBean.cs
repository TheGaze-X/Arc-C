using System;
using Il2CppDummyDll;
using Torappu.Gacha;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E7D RID: 24189
	[Token(Token = "0x2005E7D")]
	public class ItemRepoItemDetailStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x060230E7 RID: 143591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230E7")]
		[Address(RVA = "0x1D99C30", Offset = "0x1D98830", VA = "0x181D99C30")]
		public ItemRepoItemDetailStateBean()
		{
		}

		// Token: 0x0403046B RID: 197739
		[Token(Token = "0x403046B")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403046C RID: 197740
		[Token(Token = "0x403046C")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CharGachaVoucherData cacheCharData;

		// Token: 0x0403046D RID: 197741
		[Token(Token = "0x403046D")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public ItemVoucherData cacheItemData;

		// Token: 0x0403046E RID: 197742
		[Token(Token = "0x403046E")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public GachaResult[] cacheGachaResult;

		// Token: 0x0403046F RID: 197743
		[Token(Token = "0x403046F")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public GachaController.Output cacheGachaOutput;

		// Token: 0x04030470 RID: 197744
		[Token(Token = "0x4030470")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
