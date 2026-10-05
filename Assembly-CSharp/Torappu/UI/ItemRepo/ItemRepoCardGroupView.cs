using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E8B RID: 24203
	[Token(Token = "0x2005E8B")]
	public class ItemRepoCardGroupView : DataBinder<ItemCardGroupViewProperty>, IHotfixable
	{
		// Token: 0x06023126 RID: 143654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023126")]
		[Address(RVA = "0x1D8FA10", Offset = "0x1D8E610", VA = "0x181D8FA10", Slot = "7")]
		public override void OnValueChanged(ItemCardGroupViewProperty property)
		{
		}

		// Token: 0x06023127 RID: 143655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023127")]
		[Address(RVA = "0x1D8FC40", Offset = "0x1D8E840", VA = "0x181D8FC40")]
		private void _OnItemCardClick(int position)
		{
		}

		// Token: 0x06023128 RID: 143656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023128")]
		[Address(RVA = "0x1D8FCD0", Offset = "0x1D8E8D0", VA = "0x181D8FCD0")]
		public ItemRepoCardGroupView()
		{
		}

		// Token: 0x040304CF RID: 197839
		[Token(Token = "0x40304CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIIntEvent _cardClickEvent;

		// Token: 0x040304D0 RID: 197840
		[Token(Token = "0x40304D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ItemRepoCardGroupAdapter _adapter;

		// Token: 0x040304D1 RID: 197841
		[Token(Token = "0x40304D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _noItemImg;

		// Token: 0x040304D2 RID: 197842
		[Token(Token = "0x40304D2")]
		[FieldOffset(Offset = "0x38")]
		private ClassifyFilter m_cachedClass;

		// Token: 0x040304D3 RID: 197843
		[Token(Token = "0x40304D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040304D4 RID: 197844
		[Token(Token = "0x40304D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x040304D5 RID: 197845
		[Token(Token = "0x40304D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
