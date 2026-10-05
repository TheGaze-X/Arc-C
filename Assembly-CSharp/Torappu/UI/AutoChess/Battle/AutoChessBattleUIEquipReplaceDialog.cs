using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064C0 RID: 25792
	[Token(Token = "0x20064C0")]
	public class AutoChessBattleUIEquipReplaceDialog : UICompDialog<AutoChessBattleUIEquipReplaceDialog.Input>
	{
		// Token: 0x06025119 RID: 151833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025119")]
		[Address(RVA = "0x1FE83D0", Offset = "0x1FE6FD0", VA = "0x181FE83D0", Slot = "18")]
		protected override void OnRender(AutoChessBattleUIEquipReplaceDialog.Input input)
		{
		}

		// Token: 0x0602511A RID: 151834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602511A")]
		[Address(RVA = "0x1FE82C0", Offset = "0x1FE6EC0", VA = "0x181FE82C0", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0602511B RID: 151835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602511B")]
		[Address(RVA = "0x1FE7EA0", Offset = "0x1FE6AA0", VA = "0x181FE7EA0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0602511C RID: 151836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602511C")]
		[Address(RVA = "0x1FE7FF0", Offset = "0x1FE6BF0", VA = "0x181FE7FF0")]
		public void EventOnReplaceBtnClicked(int index)
		{
		}

		// Token: 0x0602511D RID: 151837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602511D")]
		[Address(RVA = "0x1FE8740", Offset = "0x1FE7340", VA = "0x181FE8740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602511E RID: 151838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602511E")]
		[Address(RVA = "0x1FE8850", Offset = "0x1FE7450", VA = "0x181FE8850")]
		private void _RenderItems()
		{
		}

		// Token: 0x0602511F RID: 151839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602511F")]
		[Address(RVA = "0x1FE8B20", Offset = "0x1FE7720", VA = "0x181FE8B20")]
		public AutoChessBattleUIEquipReplaceDialog()
		{
		}

		// Token: 0x06025120 RID: 151840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025120")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x04033E90 RID: 212624
		[Token(Token = "0x4033E90")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _showAnimLocation;

		// Token: 0x04033E91 RID: 212625
		[Token(Token = "0x4033E91")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _hideAnimLocation;

		// Token: 0x04033E92 RID: 212626
		[Token(Token = "0x4033E92")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _txtCharName;

		// Token: 0x04033E93 RID: 212627
		[Token(Token = "0x4033E93")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x04033E94 RID: 212628
		[Token(Token = "0x4033E94")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private List<AutoChessBattleUIEquipReplaceDialog.ItemViewInfo> _itemViews;

		// Token: 0x04033E95 RID: 212629
		[Token(Token = "0x4033E95")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform _rectTransformBack;

		// Token: 0x04033E96 RID: 212630
		[Token(Token = "0x4033E96")]
		[FieldOffset(Offset = "0xB0")]
		private AutoChessBattleUIEquipReplaceViewModel m_viewModel;

		// Token: 0x04033E97 RID: 212631
		[Token(Token = "0x4033E97")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x04033E98 RID: 212632
		[Token(Token = "0x4033E98")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033E99 RID: 212633
		[Token(Token = "0x4033E99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033E9A RID: 212634
		[Token(Token = "0x4033E9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x04033E9B RID: 212635
		[Token(Token = "0x4033E9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04033E9C RID: 212636
		[Token(Token = "0x4033E9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnReplaceBtnClicked;

		// Token: 0x04033E9D RID: 212637
		[Token(Token = "0x4033E9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033E9E RID: 212638
		[Token(Token = "0x4033E9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderItems;

		// Token: 0x04033E9F RID: 212639
		[Token(Token = "0x4033E9F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064C1 RID: 25793
		[Token(Token = "0x20064C1")]
		public class Input
		{
			// Token: 0x06025121 RID: 151841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025121")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04033EA0 RID: 212640
			[Token(Token = "0x4033EA0")]
			[FieldOffset(Offset = "0x10")]
			public AutoChessBattleUIEquipReplaceViewModel viewModel;
		}

		// Token: 0x020064C2 RID: 25794
		[Token(Token = "0x20064C2")]
		public class Output
		{
			// Token: 0x06025122 RID: 151842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025122")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Output()
			{
			}

			// Token: 0x04033EA1 RID: 212641
			[Token(Token = "0x4033EA1")]
			[FieldOffset(Offset = "0x10")]
			public bool isCancel;

			// Token: 0x04033EA2 RID: 212642
			[Token(Token = "0x4033EA2")]
			[FieldOffset(Offset = "0x14")]
			public int replaceInstId;
		}

		// Token: 0x020064C3 RID: 25795
		[Token(Token = "0x20064C3")]
		[Serializable]
		public class ItemViewInfo
		{
			// Token: 0x06025123 RID: 151843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025123")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ItemViewInfo()
			{
			}

			// Token: 0x04033EA3 RID: 212643
			[Token(Token = "0x4033EA3")]
			[FieldOffset(Offset = "0x10")]
			public GameObject itemView;

			// Token: 0x04033EA4 RID: 212644
			[Token(Token = "0x4033EA4")]
			[FieldOffset(Offset = "0x18")]
			public Image equipImage;

			// Token: 0x04033EA5 RID: 212645
			[Token(Token = "0x4033EA5")]
			[FieldOffset(Offset = "0x20")]
			public Text equipName;

			// Token: 0x04033EA6 RID: 212646
			[Token(Token = "0x4033EA6")]
			[FieldOffset(Offset = "0x28")]
			public Text equipDesc;

			// Token: 0x04033EA7 RID: 212647
			[Token(Token = "0x4033EA7")]
			[FieldOffset(Offset = "0x30")]
			public TwoStateFadeSwitcher fadeSwitcher;
		}
	}
}
