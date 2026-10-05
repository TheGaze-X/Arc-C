using System;
using Il2CppDummyDll;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EA6 RID: 24230
	[Token(Token = "0x2005EA6")]
	public class ItemRepoOptionalVoucherChooseListAdapter : RecycleLoopScrollAdapter<ItemRepoOptionalVoucherChooseItemViewHolder, ItemRepoOptionalVoucherChooseItemViewModel>
	{
		// Token: 0x06023188 RID: 143752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023188")]
		[Address(RVA = "0x1D9B3B0", Offset = "0x1D99FB0", VA = "0x181D9B3B0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ItemRepoOptionalVoucherChooseItemViewHolder holder, ItemRepoOptionalVoucherChooseItemViewModel data)
		{
		}

		// Token: 0x06023189 RID: 143753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023189")]
		[Address(RVA = "0x1D9B530", Offset = "0x1D9A130", VA = "0x181D9B530", Slot = "14")]
		protected override GameObject ViewConstructor(GameObjectPool objectPool)
		{
			return null;
		}

		// Token: 0x0602318A RID: 143754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602318A")]
		[Address(RVA = "0x1D9B5F0", Offset = "0x1D9A1F0", VA = "0x181D9B5F0")]
		public ItemRepoOptionalVoucherChooseListAdapter()
		{
		}

		// Token: 0x040305B7 RID: 198071
		[Token(Token = "0x40305B7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ItemRepoOptionalVoucherChooseItemView _itemViewPrefab;

		// Token: 0x040305B8 RID: 198072
		[Token(Token = "0x40305B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIStringEvent onAddChooseItemClickEvent;

		// Token: 0x040305B9 RID: 198073
		[Token(Token = "0x40305B9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIStringEvent onMinusChooseItemClickEvent;

		// Token: 0x040305BA RID: 198074
		[Token(Token = "0x40305BA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIStringEvent onDetailItemInfoClickEvent;

		// Token: 0x040305BB RID: 198075
		[Token(Token = "0x40305BB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040305BC RID: 198076
		[Token(Token = "0x40305BC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ViewConstructor;

		// Token: 0x040305BD RID: 198077
		[Token(Token = "0x40305BD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
