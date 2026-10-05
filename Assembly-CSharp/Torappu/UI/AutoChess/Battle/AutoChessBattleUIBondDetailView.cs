using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D1 RID: 25809
	[Token(Token = "0x20064D1")]
	public class AutoChessBattleUIBondDetailView : DataBinder<AutoChessBattleUIViewModelProperty>, IHotfixable
	{
		// Token: 0x06025167 RID: 151911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025167")]
		[Address(RVA = "0x1FE2B20", Offset = "0x1FE1720", VA = "0x181FE2B20", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025168 RID: 151912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025168")]
		[Address(RVA = "0x1FE2A90", Offset = "0x1FE1690", VA = "0x181FE2A90")]
		public void OnSwitchToPrevBond()
		{
		}

		// Token: 0x06025169 RID: 151913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025169")]
		[Address(RVA = "0x1FE2A00", Offset = "0x1FE1600", VA = "0x181FE2A00")]
		public void OnSwitchToNextBond()
		{
		}

		// Token: 0x0602516A RID: 151914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602516A")]
		[Address(RVA = "0x1FE2DF0", Offset = "0x1FE19F0", VA = "0x181FE2DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602516B RID: 151915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602516B")]
		[Address(RVA = "0x1FE32B0", Offset = "0x1FE1EB0", VA = "0x181FE32B0")]
		private void _RenderTitleInfo(AutoChessBondItemModel selectedModel)
		{
		}

		// Token: 0x0602516C RID: 151916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602516C")]
		[Address(RVA = "0x1FE3120", Offset = "0x1FE1D20", VA = "0x181FE3120")]
		private void _RenderContent(AutoChessBondItemModel selectedModel)
		{
		}

		// Token: 0x0602516D RID: 151917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602516D")]
		[Address(RVA = "0x1FE2F30", Offset = "0x1FE1B30", VA = "0x181FE2F30")]
		private void _RenderArrows(AutoChessHUDStatusModel model)
		{
		}

		// Token: 0x0602516E RID: 151918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602516E")]
		[Address(RVA = "0x1FE3650", Offset = "0x1FE2250", VA = "0x181FE3650")]
		public AutoChessBattleUIBondDetailView()
		{
		}

		// Token: 0x04033F27 RID: 212775
		[Token(Token = "0x4033F27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private AutoChessBattleUIBondIconView _iconView;

		// Token: 0x04033F28 RID: 212776
		[Token(Token = "0x4033F28")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Title")]
		private Text _nameText;

		// Token: 0x04033F29 RID: 212777
		[Token(Token = "0x4033F29")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Title")]
		private GameObject _activeTipObj;

		// Token: 0x04033F2A RID: 212778
		[Token(Token = "0x4033F2A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Title")]
		private GameObject _inactiveTipObj;

		// Token: 0x04033F2B RID: 212779
		[Token(Token = "0x4033F2B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Title")]
		private Text _activeCharReqText;

		// Token: 0x04033F2C RID: 212780
		[Token(Token = "0x4033F2C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Title")]
		private Text _inactiveReqText;

		// Token: 0x04033F2D RID: 212781
		[Token(Token = "0x4033F2D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Title")]
		private GameObject _stackGrp;

		// Token: 0x04033F2E RID: 212782
		[Token(Token = "0x4033F2E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Title")]
		private Text _stackText;

		// Token: 0x04033F2F RID: 212783
		[Token(Token = "0x4033F2F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Title")]
		private GameObject _activeBoardObj;

		// Token: 0x04033F30 RID: 212784
		[Token(Token = "0x4033F30")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Desc")]
		private Text _descText;

		// Token: 0x04033F31 RID: 212785
		[Token(Token = "0x4033F31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Desc")]
		private Color _activeDescColor;

		// Token: 0x04033F32 RID: 212786
		[Token(Token = "0x4033F32")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Desc")]
		private Color _inactiveDescColor;

		// Token: 0x04033F33 RID: 212787
		[Token(Token = "0x4033F33")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Char")]
		private SimpleLayoutContent _charContent;

		// Token: 0x04033F34 RID: 212788
		[Token(Token = "0x4033F34")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Arrow")]
		private GameObject _prevArrowObj;

		// Token: 0x04033F35 RID: 212789
		[Token(Token = "0x4033F35")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Arrow")]
		private GameObject _nextArrowObj;

		// Token: 0x04033F36 RID: 212790
		[Token(Token = "0x4033F36")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x04033F37 RID: 212791
		[Token(Token = "0x4033F37")]
		[FieldOffset(Offset = "0xB0")]
		private AutoChessBattleUIBondDetailView.CharAdapter m_charAdapter;

		// Token: 0x04033F38 RID: 212792
		[Token(Token = "0x4033F38")]
		[FieldOffset(Offset = "0xB8")]
		private List<AutoChessBondCharModel> m_charModels;

		// Token: 0x04033F39 RID: 212793
		[Token(Token = "0x4033F39")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033F3A RID: 212794
		[Token(Token = "0x4033F3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033F3B RID: 212795
		[Token(Token = "0x4033F3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSwitchToPrevBond;

		// Token: 0x04033F3C RID: 212796
		[Token(Token = "0x4033F3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnSwitchToNextBond;

		// Token: 0x04033F3D RID: 212797
		[Token(Token = "0x4033F3D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033F3E RID: 212798
		[Token(Token = "0x4033F3E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderTitleInfo;

		// Token: 0x04033F3F RID: 212799
		[Token(Token = "0x4033F3F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x04033F40 RID: 212800
		[Token(Token = "0x4033F40")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderArrows;

		// Token: 0x04033F41 RID: 212801
		[Token(Token = "0x4033F41")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064D2 RID: 25810
		[Token(Token = "0x20064D2")]
		private class CharAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602516F RID: 151919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602516F")]
			[Address(RVA = "0x1FF0810", Offset = "0x1FEF410", VA = "0x181FF0810")]
			public CharAdapter(AutoChessBattleUIBondDetailView closure)
			{
			}

			// Token: 0x17005781 RID: 22401
			// (get) Token: 0x06025170 RID: 151920 RVA: 0x000C66C0 File Offset: 0x000C48C0
			[Token(Token = "0x17005781")]
			public override int count
			{
				[Token(Token = "0x6025170")]
				[Address(RVA = "0x1FF0890", Offset = "0x1FEF490", VA = "0x181FF0890", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025171 RID: 151921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025171")]
			[Address(RVA = "0x1FF0590", Offset = "0x1FEF190", VA = "0x181FF0590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04033F42 RID: 212802
			[Token(Token = "0x4033F42")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessBattleUIBondDetailView m_closure;

			// Token: 0x04033F43 RID: 212803
			[Token(Token = "0x4033F43")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04033F44 RID: 212804
			[Token(Token = "0x4033F44")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033F45 RID: 212805
			[Token(Token = "0x4033F45")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
