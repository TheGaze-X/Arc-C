using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CFE RID: 7422
	[Token(Token = "0x2001CFE")]
	public class BuildingShopOutputSlot : DataBinder<SRoomViewProperty>
	{
		// Token: 0x0600B752 RID: 46930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B752")]
		[Address(RVA = "0x3344540", Offset = "0x3343140", VA = "0x183344540", Slot = "7")]
		public override void OnValueChanged(SRoomViewProperty property)
		{
		}

		// Token: 0x0600B753 RID: 46931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B753")]
		[Address(RVA = "0x33448F0", Offset = "0x33434F0", VA = "0x1833448F0")]
		private UIItemViewModel _FindItemViewModel(ItemType itemType)
		{
			return null;
		}

		// Token: 0x0600B754 RID: 46932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B754")]
		[Address(RVA = "0x3344A50", Offset = "0x3343650", VA = "0x183344A50")]
		private void _Init()
		{
		}

		// Token: 0x0600B755 RID: 46933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B755")]
		[Address(RVA = "0x3344B70", Offset = "0x3343770", VA = "0x183344B70")]
		private void _UpdateOutput(ShopInfoViewModel shopInfo)
		{
		}

		// Token: 0x0600B756 RID: 46934 RVA: 0x000451E0 File Offset: 0x000433E0
		[Token(Token = "0x600B756")]
		[Address(RVA = "0x3344810", Offset = "0x3343410", VA = "0x183344810")]
		private int _CountItems(List<ItemType> icons, ItemType itemType)
		{
			return 0;
		}

		// Token: 0x0600B757 RID: 46935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B757")]
		[Address(RVA = "0x3344E90", Offset = "0x3343A90", VA = "0x183344E90")]
		public BuildingShopOutputSlot()
		{
		}

		// Token: 0x0400B53E RID: 46398
		[Token(Token = "0x400B53E")]
		private const string STACK_CARD_NAME = "stack_card";

		// Token: 0x0400B53F RID: 46399
		[Token(Token = "0x400B53F")]
		private const float ANIM_DUR = 0.18f;

		// Token: 0x0400B540 RID: 46400
		[Token(Token = "0x400B540")]
		private const int MAX_STACK_COUNT = 30;

		// Token: 0x0400B541 RID: 46401
		[Token(Token = "0x400B541")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400B542 RID: 46402
		[Token(Token = "0x400B542")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLimit;

		// Token: 0x0400B543 RID: 46403
		[Token(Token = "0x400B543")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _cardLayout;

		// Token: 0x0400B544 RID: 46404
		[Token(Token = "0x400B544")]
		[FieldOffset(Offset = "0x38")]
		private BuildingShopOutputSlot.CardAdapter m_adapter;

		// Token: 0x0400B545 RID: 46405
		[Token(Token = "0x400B545")]
		[FieldOffset(Offset = "0x40")]
		private List<ItemType> m_iconInfoList;

		// Token: 0x0400B546 RID: 46406
		[Token(Token = "0x400B546")]
		[FieldOffset(Offset = "0x48")]
		private List<UIItemViewModel> m_itemModels;

		// Token: 0x0400B547 RID: 46407
		[Token(Token = "0x400B547")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedSlotId;

		// Token: 0x0400B548 RID: 46408
		[Token(Token = "0x400B548")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400B549 RID: 46409
		[Token(Token = "0x400B549")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B54A RID: 46410
		[Token(Token = "0x400B54A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__FindItemViewModel;

		// Token: 0x0400B54B RID: 46411
		[Token(Token = "0x400B54B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400B54C RID: 46412
		[Token(Token = "0x400B54C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateOutput;

		// Token: 0x0400B54D RID: 46413
		[Token(Token = "0x400B54D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CountItems;

		// Token: 0x0400B54E RID: 46414
		[Token(Token = "0x400B54E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CFF RID: 7423
		[Token(Token = "0x2001CFF")]
		private class CardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0600B758 RID: 46936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B758")]
			[Address(RVA = "0x334B1D0", Offset = "0x3349DD0", VA = "0x18334B1D0")]
			public CardAdapter(BuildingShopOutputSlot closure)
			{
			}

			// Token: 0x170015F3 RID: 5619
			// (get) Token: 0x0600B759 RID: 46937 RVA: 0x000451F8 File Offset: 0x000433F8
			[Token(Token = "0x170015F3")]
			public override int count
			{
				[Token(Token = "0x600B759")]
				[Address(RVA = "0x334B250", Offset = "0x3349E50", VA = "0x18334B250", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600B75A RID: 46938 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B75A")]
			[Address(RVA = "0x334AD10", Offset = "0x3349910", VA = "0x18334AD10", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0400B54F RID: 46415
			[Token(Token = "0x400B54F")]
			[FieldOffset(Offset = "0x20")]
			private BuildingShopOutputSlot m_closure;

			// Token: 0x0400B550 RID: 46416
			[Token(Token = "0x400B550")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400B551 RID: 46417
			[Token(Token = "0x400B551")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0400B552 RID: 46418
			[Token(Token = "0x400B552")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
