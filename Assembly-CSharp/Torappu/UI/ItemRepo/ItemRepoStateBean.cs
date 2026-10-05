using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E83 RID: 24195
	[Token(Token = "0x2005E83")]
	public class ItemRepoStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x06023104 RID: 143620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023104")]
		[Address(RVA = "0x1DA0280", Offset = "0x1D9EE80", VA = "0x181DA0280")]
		public void ChangeClassify(ClassifyFilter filter)
		{
		}

		// Token: 0x06023105 RID: 143621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023105")]
		[Address(RVA = "0x1DA0340", Offset = "0x1D9EF40", VA = "0x181DA0340")]
		public List<UIItemViewModel> GetCurrentItemList()
		{
			return null;
		}

		// Token: 0x06023106 RID: 143622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023106")]
		[Address(RVA = "0x1DA0C00", Offset = "0x1D9F800", VA = "0x181DA0C00")]
		public void RefreshData()
		{
		}

		// Token: 0x06023107 RID: 143623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023107")]
		[Address(RVA = "0x1DA0960", Offset = "0x1D9F560", VA = "0x181DA0960")]
		public void LoadData()
		{
		}

		// Token: 0x06023108 RID: 143624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023108")]
		[Address(RVA = "0x1DA0B10", Offset = "0x1D9F710", VA = "0x181DA0B10")]
		public void LoadItemDesc(int itemIndex)
		{
		}

		// Token: 0x06023109 RID: 143625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023109")]
		[Address(RVA = "0x1DA0CD0", Offset = "0x1D9F8D0", VA = "0x181DA0CD0")]
		public void UnLoadItemDesc()
		{
		}

		// Token: 0x0602310A RID: 143626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602310A")]
		[Address(RVA = "0x1DA08A0", Offset = "0x1D9F4A0", VA = "0x181DA08A0")]
		public UIItemViewModel GetItemViewModel()
		{
			return null;
		}

		// Token: 0x0602310B RID: 143627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602310B")]
		[Address(RVA = "0x1DA0D70", Offset = "0x1D9F970", VA = "0x181DA0D70")]
		private void _AddNonInventoryItems(List<UIItemViewModel> itemList)
		{
		}

		// Token: 0x0602310C RID: 143628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602310C")]
		[Address(RVA = "0x1DA0F20", Offset = "0x1D9FB20", VA = "0x181DA0F20")]
		public ItemRepoStateBean()
		{
		}

		// Token: 0x0403049B RID: 197787
		[Token(Token = "0x403049B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemCardGroupViewProperty _itemCardGroupProperty;

		// Token: 0x0403049C RID: 197788
		[Token(Token = "0x403049C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIItemDescViewProperty _itemDescProperty;

		// Token: 0x0403049D RID: 197789
		[Token(Token = "0x403049D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ResourceBarViewProperty _resourceProperty;

		// Token: 0x0403049E RID: 197790
		[Token(Token = "0x403049E")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public int clickPosition;

		// Token: 0x0403049F RID: 197791
		[Token(Token = "0x403049F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ChangeClassify;

		// Token: 0x040304A0 RID: 197792
		[Token(Token = "0x40304A0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCurrentItemList;

		// Token: 0x040304A1 RID: 197793
		[Token(Token = "0x40304A1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040304A2 RID: 197794
		[Token(Token = "0x40304A2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040304A3 RID: 197795
		[Token(Token = "0x40304A3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadItemDesc;

		// Token: 0x040304A4 RID: 197796
		[Token(Token = "0x40304A4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UnLoadItemDesc;

		// Token: 0x040304A5 RID: 197797
		[Token(Token = "0x40304A5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetItemViewModel;

		// Token: 0x040304A6 RID: 197798
		[Token(Token = "0x40304A6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddNonInventoryItems;

		// Token: 0x040304A7 RID: 197799
		[Token(Token = "0x40304A7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
