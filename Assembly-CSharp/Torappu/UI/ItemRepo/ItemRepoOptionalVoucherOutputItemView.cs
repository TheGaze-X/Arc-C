using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA7 RID: 24231
	[Token(Token = "0x2005EA7")]
	public class ItemRepoOptionalVoucherOutputItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602318B RID: 143755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318B")]
		[Address(RVA = "0x1D9B660", Offset = "0x1D9A260", VA = "0x181D9B660")]
		public void ApplyData(UIItemViewModel viewModel)
		{
		}

		// Token: 0x0602318C RID: 143756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318C")]
		[Address(RVA = "0x1D9B6F0", Offset = "0x1D9A2F0", VA = "0x181D9B6F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602318D RID: 143757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318D")]
		[Address(RVA = "0x1D9B950", Offset = "0x1D9A550", VA = "0x181D9B950")]
		private void _OnItemClicked(int index)
		{
		}

		// Token: 0x0602318E RID: 143758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318E")]
		[Address(RVA = "0x1D9BA40", Offset = "0x1D9A640", VA = "0x181D9BA40")]
		public ItemRepoOptionalVoucherOutputItemView()
		{
		}

		// Token: 0x040305BE RID: 198078
		[Token(Token = "0x40305BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x040305BF RID: 198079
		[Token(Token = "0x40305BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x040305C0 RID: 198080
		[Token(Token = "0x40305C0")]
		[FieldOffset(Offset = "0x28")]
		private UIItemCard m_itemCard;

		// Token: 0x040305C1 RID: 198081
		[Token(Token = "0x40305C1")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x040305C2 RID: 198082
		[Token(Token = "0x40305C2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040305C3 RID: 198083
		[Token(Token = "0x40305C3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040305C4 RID: 198084
		[Token(Token = "0x40305C4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x040305C5 RID: 198085
		[Token(Token = "0x40305C5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
