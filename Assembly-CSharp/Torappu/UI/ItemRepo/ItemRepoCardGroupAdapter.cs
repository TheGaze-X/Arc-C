using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E89 RID: 24201
	[Token(Token = "0x2005E89")]
	public class ItemRepoCardGroupAdapter : LoopScrollAdapter<ItemRepoCardGroupAdapter.ViewHolder, UIItemViewModel>, IHotfixable
	{
		// Token: 0x06023120 RID: 143648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023120")]
		[Address(RVA = "0x1D8F600", Offset = "0x1D8E200", VA = "0x181D8F600", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ItemRepoCardGroupAdapter.ViewHolder holder, UIItemViewModel data)
		{
		}

		// Token: 0x06023121 RID: 143649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023121")]
		[Address(RVA = "0x1D8F580", Offset = "0x1D8E180", VA = "0x181D8F580")]
		protected void OnDestroy()
		{
		}

		// Token: 0x06023122 RID: 143650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023122")]
		[Address(RVA = "0x1D8F8C0", Offset = "0x1D8E4C0", VA = "0x181D8F8C0")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06023123 RID: 143651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023123")]
		[Address(RVA = "0x1D8F490", Offset = "0x1D8E090", VA = "0x181D8F490", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x06023124 RID: 143652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023124")]
		[Address(RVA = "0x1D8F940", Offset = "0x1D8E540", VA = "0x181D8F940")]
		public ItemRepoCardGroupAdapter()
		{
		}

		// Token: 0x040304C4 RID: 197828
		[Token(Token = "0x40304C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x040304C5 RID: 197829
		[Token(Token = "0x40304C5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LoopHorizontalScrollRect _loopScroll;

		// Token: 0x040304C6 RID: 197830
		[Token(Token = "0x40304C6")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<int, UIItemCard> m_activeCards;

		// Token: 0x040304C7 RID: 197831
		[Token(Token = "0x40304C7")]
		[FieldOffset(Offset = "0x70")]
		public Action<int> onItemCardClick;

		// Token: 0x040304C8 RID: 197832
		[Token(Token = "0x40304C8")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public ClassifyFilter classifyType;

		// Token: 0x040304C9 RID: 197833
		[Token(Token = "0x40304C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040304CA RID: 197834
		[Token(Token = "0x40304CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040304CB RID: 197835
		[Token(Token = "0x40304CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x040304CC RID: 197836
		[Token(Token = "0x40304CC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x040304CD RID: 197837
		[Token(Token = "0x40304CD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E8A RID: 24202
		[Token(Token = "0x2005E8A")]
		public class ViewHolder
		{
			// Token: 0x06023125 RID: 143653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023125")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewHolder()
			{
			}

			// Token: 0x040304CE RID: 197838
			[Token(Token = "0x40304CE")]
			[FieldOffset(Offset = "0x10")]
			public UIItemCard itemCard;
		}
	}
}
