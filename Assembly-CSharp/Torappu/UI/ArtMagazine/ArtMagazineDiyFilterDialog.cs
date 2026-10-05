using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065AB RID: 26027
	[Token(Token = "0x20065AB")]
	public class ArtMagazineDiyFilterDialog : UICompDialog<ArtMagazineDiyFilterDialog.Input>, IValueMsgReceiver
	{
		// Token: 0x06025697 RID: 153239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025697")]
		[Address(RVA = "0x20618D0", Offset = "0x20604D0", VA = "0x1820618D0", Slot = "18")]
		protected override void OnRender(ArtMagazineDiyFilterDialog.Input input)
		{
		}

		// Token: 0x06025698 RID: 153240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025698")]
		[Address(RVA = "0x2061670", Offset = "0x2060270", VA = "0x182061670", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06025699 RID: 153241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025699")]
		[Address(RVA = "0x20619D0", Offset = "0x20605D0", VA = "0x1820619D0")]
		private void _OnFilterItemClick(object objVal)
		{
		}

		// Token: 0x0602569A RID: 153242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602569A")]
		[Address(RVA = "0x20615B0", Offset = "0x20601B0", VA = "0x1820615B0")]
		public void CloseDialog()
		{
		}

		// Token: 0x0602569B RID: 153243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602569B")]
		[Address(RVA = "0x2061BD0", Offset = "0x20607D0", VA = "0x182061BD0")]
		public ArtMagazineDiyFilterDialog()
		{
		}

		// Token: 0x04034803 RID: 215043
		[Token(Token = "0x4034803")]
		[NonSerialized]
		public const int EVENT_FILTER_ITEM_CLICK = 0;

		// Token: 0x04034804 RID: 215044
		[Token(Token = "0x4034804")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FilterGroupType _groupType;

		// Token: 0x04034805 RID: 215045
		[Token(Token = "0x4034805")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtMagazineDiyFilterItemBase[] _filterItems;

		// Token: 0x04034806 RID: 215046
		[Token(Token = "0x4034806")]
		[FieldOffset(Offset = "0x80")]
		private ItemType m_cacheItemType;

		// Token: 0x04034807 RID: 215047
		[Token(Token = "0x4034807")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04034808 RID: 215048
		[Token(Token = "0x4034808")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04034809 RID: 215049
		[Token(Token = "0x4034809")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403480A RID: 215050
		[Token(Token = "0x403480A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnFilterItemClick;

		// Token: 0x0403480B RID: 215051
		[Token(Token = "0x403480B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CloseDialog;

		// Token: 0x0403480C RID: 215052
		[Token(Token = "0x403480C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065AC RID: 26028
		[Token(Token = "0x20065AC")]
		public class Input
		{
			// Token: 0x0602569C RID: 153244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602569C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403480D RID: 215053
			[Token(Token = "0x403480D")]
			[FieldOffset(Offset = "0x10")]
			public ItemType relateItemType;

			// Token: 0x0403480E RID: 215054
			[Token(Token = "0x403480E")]
			[FieldOffset(Offset = "0x18")]
			public object activeFilterParam;
		}
	}
}
