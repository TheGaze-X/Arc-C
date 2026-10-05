using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E9C RID: 24220
	[Token(Token = "0x2005E9C")]
	public class ItemRepoIssueVoucherItemListAdapter : LoopScrollAdapter<ItemRepoIssueVoucherItemListAdapter.ViewHolder, ItemRepoIssueVoucherItemViewModel>
	{
		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x0602315D RID: 143709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602315E RID: 143710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700531F")]
		public Func<int, int, bool> onSelectItem
		{
			[Token(Token = "0x602315D")]
			[Address(RVA = "0x1D94D50", Offset = "0x1D93950", VA = "0x181D94D50")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602315E")]
			[Address(RVA = "0x1D94DB0", Offset = "0x1D939B0", VA = "0x181D94DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602315F RID: 143711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602315F")]
		[Address(RVA = "0x1D94AF0", Offset = "0x1D936F0", VA = "0x181D94AF0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ItemRepoIssueVoucherItemListAdapter.ViewHolder holder, ItemRepoIssueVoucherItemViewModel data)
		{
		}

		// Token: 0x06023160 RID: 143712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023160")]
		[Address(RVA = "0x1D94A30", Offset = "0x1D93630", VA = "0x181D94A30", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06023161 RID: 143713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023161")]
		[Address(RVA = "0x1D94CE0", Offset = "0x1D938E0", VA = "0x181D94CE0")]
		public ItemRepoIssueVoucherItemListAdapter()
		{
		}

		// Token: 0x0403054B RID: 197963
		[Token(Token = "0x403054B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ItemRepoIssueVoucherItemView _itemPrefab;

		// Token: 0x0403054D RID: 197965
		[Token(Token = "0x403054D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSelectItem;

		// Token: 0x0403054E RID: 197966
		[Token(Token = "0x403054E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSelectItem;

		// Token: 0x0403054F RID: 197967
		[Token(Token = "0x403054F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04030550 RID: 197968
		[Token(Token = "0x4030550")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04030551 RID: 197969
		[Token(Token = "0x4030551")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E9D RID: 24221
		[Token(Token = "0x2005E9D")]
		public class ViewHolder
		{
			// Token: 0x06023162 RID: 143714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023162")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x04030552 RID: 197970
			[Token(Token = "0x4030552")]
			[FieldOffset(Offset = "0x10")]
			public ItemRepoIssueVoucherItemView itemView;
		}
	}
}
