using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA3 RID: 24227
	[Token(Token = "0x2005EA3")]
	public class ItemRepoItemListAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17005324 RID: 21284
		// (get) Token: 0x0602317E RID: 143742 RVA: 0x000BFEC8 File Offset: 0x000BE0C8
		[Token(Token = "0x17005324")]
		public override int count
		{
			[Token(Token = "0x602317E")]
			[Address(RVA = "0x1D9ABE0", Offset = "0x1D997E0", VA = "0x181D9ABE0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602317F RID: 143743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602317F")]
		[Address(RVA = "0x1D9A720", Offset = "0x1D99320", VA = "0x181D9A720", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06023180 RID: 143744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023180")]
		[Address(RVA = "0x1D9AB70", Offset = "0x1D99770", VA = "0x181D9AB70")]
		public ItemRepoItemListAdapter()
		{
		}

		// Token: 0x04030599 RID: 198041
		[Token(Token = "0x4030599")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemVoucherViewModel> viewModelList;

		// Token: 0x0403059A RID: 198042
		[Token(Token = "0x403059A")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x0403059B RID: 198043
		[Token(Token = "0x403059B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403059C RID: 198044
		[Token(Token = "0x403059C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403059D RID: 198045
		[Token(Token = "0x403059D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
