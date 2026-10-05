using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA1 RID: 24225
	[Token(Token = "0x2005EA1")]
	public class ItemRepoItemCommonAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17005323 RID: 21283
		// (get) Token: 0x06023179 RID: 143737 RVA: 0x000BFEB0 File Offset: 0x000BE0B0
		[Token(Token = "0x17005323")]
		public override int count
		{
			[Token(Token = "0x6023179")]
			[Address(RVA = "0x1D99250", Offset = "0x1D97E50", VA = "0x181D99250", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602317A RID: 143738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602317A")]
		[Address(RVA = "0x1D98E50", Offset = "0x1D97A50", VA = "0x181D98E50", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602317B RID: 143739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602317B")]
		[Address(RVA = "0x1D991E0", Offset = "0x1D97DE0", VA = "0x181D991E0")]
		public ItemRepoItemCommonAdapter()
		{
		}

		// Token: 0x04030592 RID: 198034
		[Token(Token = "0x4030592")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemVoucherPool> itemList;

		// Token: 0x04030593 RID: 198035
		[Token(Token = "0x4030593")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x04030594 RID: 198036
		[Token(Token = "0x4030594")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04030595 RID: 198037
		[Token(Token = "0x4030595")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04030596 RID: 198038
		[Token(Token = "0x4030596")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
