using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Skin
{
	// Token: 0x02003ED1 RID: 16081
	[Token(Token = "0x2003ED1")]
	public class SkinSelectState : State, IValueMsgReceiver
	{
		// Token: 0x06018F29 RID: 102185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018F29")]
		[Address(RVA = "0x11A3710", Offset = "0x11A2310", VA = "0x1811A3710", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06018F2A RID: 102186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2A")]
		[Address(RVA = "0x11A3D00", Offset = "0x11A2900", VA = "0x1811A3D00")]
		private void _ChangeSkinSelectState(SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F2B RID: 102187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2B")]
		[Address(RVA = "0x11A48F0", Offset = "0x11A34F0", VA = "0x1811A48F0")]
		private void _SendChangeSkinRequest(SkinSelectViewModel viewModel, PlayerCharacter playerChar, UIPage page)
		{
		}

		// Token: 0x06018F2C RID: 102188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2C")]
		[Address(RVA = "0x11A4690", Offset = "0x11A3290", VA = "0x1811A4690")]
		private void _SendChangeDynIllustSpStateRequest(SkinSelectViewModel viewModel, bool state, UIPage page)
		{
		}

		// Token: 0x06018F2D RID: 102189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2D")]
		[Address(RVA = "0x11A3830", Offset = "0x11A2430", VA = "0x1811A3830", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06018F2E RID: 102190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2E")]
		[Address(RVA = "0x11A39B0", Offset = "0x11A25B0", VA = "0x1811A39B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06018F2F RID: 102191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F2F")]
		[Address(RVA = "0x11A3C50", Offset = "0x11A2850", VA = "0x1811A3C50", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06018F30 RID: 102192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F30")]
		[Address(RVA = "0x11A4B50", Offset = "0x11A3750", VA = "0x1811A4B50")]
		private void _TryRefreshData()
		{
		}

		// Token: 0x06018F31 RID: 102193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F31")]
		[Address(RVA = "0x11A37D0", Offset = "0x11A23D0", VA = "0x1811A37D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06018F32 RID: 102194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F32")]
		[Address(RVA = "0x11A3770", Offset = "0x11A2370", VA = "0x1811A3770")]
		private void OnDisable()
		{
		}

		// Token: 0x06018F33 RID: 102195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F33")]
		[Address(RVA = "0x11A3A10", Offset = "0x11A2610", VA = "0x1811A3A10", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06018F34 RID: 102196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F34")]
		[Address(RVA = "0x11A4200", Offset = "0x11A2E00", VA = "0x1811A4200")]
		private void _HandleSkinPreviewHide()
		{
		}

		// Token: 0x06018F35 RID: 102197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F35")]
		[Address(RVA = "0x11A4260", Offset = "0x11A2E60", VA = "0x1811A4260")]
		private void _HandleSkinPreviewShow()
		{
		}

		// Token: 0x06018F36 RID: 102198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F36")]
		[Address(RVA = "0x11A3F20", Offset = "0x11A2B20", VA = "0x1811A3F20")]
		private void _HandleIllustClick(object objVal)
		{
		}

		// Token: 0x06018F37 RID: 102199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F37")]
		[Address(RVA = "0x11A4180", Offset = "0x11A2D80", VA = "0x1811A4180")]
		private void _HandleSkinItemClicked(string skinId)
		{
		}

		// Token: 0x06018F38 RID: 102200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F38")]
		[Address(RVA = "0x11A4C40", Offset = "0x11A3840", VA = "0x1811A4C40")]
		private void _UpdateSkinIllustVisible()
		{
		}

		// Token: 0x06018F39 RID: 102201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F39")]
		[Address(RVA = "0x11A42C0", Offset = "0x11A2EC0", VA = "0x1811A42C0")]
		private void _HandleSkinStateChanged()
		{
		}

		// Token: 0x06018F3A RID: 102202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F3A")]
		[Address(RVA = "0x11A30E0", Offset = "0x11A1CE0", VA = "0x1811A30E0")]
		public void EventOnBtnPreview()
		{
		}

		// Token: 0x06018F3B RID: 102203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F3B")]
		[Address(RVA = "0x11A33A0", Offset = "0x11A1FA0", VA = "0x1811A33A0")]
		public void EventOnBtnSwitchSpDynIllust()
		{
		}

		// Token: 0x06018F3C RID: 102204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F3C")]
		[Address(RVA = "0x11A3060", Offset = "0x11A1C60", VA = "0x1811A3060")]
		public void ChangeSelectState(SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F3D RID: 102205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F3D")]
		[Address(RVA = "0x11A3550", Offset = "0x11A2150", VA = "0x1811A3550")]
		public void EventOnSkinBuyState(SkinSelectViewModel viewModel)
		{
		}

		// Token: 0x06018F3E RID: 102206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F3E")]
		[Address(RVA = "0x11A4EC0", Offset = "0x11A3AC0", VA = "0x1811A4EC0")]
		public SkinSelectState()
		{
		}

		// Token: 0x06018F41 RID: 102209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F41")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06018F42 RID: 102210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F42")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06018F43 RID: 102211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018F43")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0401ECB6 RID: 126134
		[Token(Token = "0x401ECB6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkinSelectStateBean _stateBean;

		// Token: 0x0401ECB7 RID: 126135
		[Token(Token = "0x401ECB7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SkinSelectScrollView _view;

		// Token: 0x0401ECB8 RID: 126136
		[Token(Token = "0x401ECB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SkinSelectMenuView _menuView;

		// Token: 0x0401ECB9 RID: 126137
		[Token(Token = "0x401ECB9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SkinPreviewPanel _previewPanelPrefab;

		// Token: 0x0401ECBA RID: 126138
		[Token(Token = "0x401ECBA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _previewPanelRoot;

		// Token: 0x0401ECBB RID: 126139
		[Token(Token = "0x401ECBB")]
		[NonSerialized]
		public const int MSG_SKIN_STATE_CHANGED = 1;

		// Token: 0x0401ECBC RID: 126140
		[Token(Token = "0x401ECBC")]
		[NonSerialized]
		public const int MSG_SKIN_PREVIEW_SHOW = 2;

		// Token: 0x0401ECBD RID: 126141
		[Token(Token = "0x401ECBD")]
		[NonSerialized]
		public const int MSG_SKIN_PREVIEW_HIDE = 3;

		// Token: 0x0401ECBE RID: 126142
		[Token(Token = "0x401ECBE")]
		[NonSerialized]
		public const int MSG_ILLUST_CLICK = 4;

		// Token: 0x0401ECBF RID: 126143
		[Token(Token = "0x401ECBF")]
		[NonSerialized]
		public const int MSG_SKIN_ITEM_CLICKED = 5;

		// Token: 0x0401ECC0 RID: 126144
		[Token(Token = "0x401ECC0")]
		[FieldOffset(Offset = "0x78")]
		private bool m_refreshDataFlag;

		// Token: 0x0401ECC1 RID: 126145
		[Token(Token = "0x401ECC1")]
		[FieldOffset(Offset = "0x79")]
		private bool m_isThisStateEntered;

		// Token: 0x0401ECC2 RID: 126146
		[Token(Token = "0x401ECC2")]
		[FieldOffset(Offset = "0x7C")]
		private SkinPage.PageReferrer m_pageReferrer;

		// Token: 0x0401ECC3 RID: 126147
		[Token(Token = "0x401ECC3")]
		[FieldOffset(Offset = "0x80")]
		private SkinPreviewPanel m_previewPanel;

		// Token: 0x0401ECC4 RID: 126148
		[Token(Token = "0x401ECC4")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401ECC5 RID: 126149
		[Token(Token = "0x401ECC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401ECC6 RID: 126150
		[Token(Token = "0x401ECC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ChangeSkinSelectState;

		// Token: 0x0401ECC7 RID: 126151
		[Token(Token = "0x401ECC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SendChangeSkinRequest;

		// Token: 0x0401ECC8 RID: 126152
		[Token(Token = "0x401ECC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendChangeDynIllustSpStateRequest;

		// Token: 0x0401ECC9 RID: 126153
		[Token(Token = "0x401ECC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401ECCA RID: 126154
		[Token(Token = "0x401ECCA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401ECCB RID: 126155
		[Token(Token = "0x401ECCB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401ECCC RID: 126156
		[Token(Token = "0x401ECCC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryRefreshData;

		// Token: 0x0401ECCD RID: 126157
		[Token(Token = "0x401ECCD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401ECCE RID: 126158
		[Token(Token = "0x401ECCE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401ECCF RID: 126159
		[Token(Token = "0x401ECCF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401ECD0 RID: 126160
		[Token(Token = "0x401ECD0")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleSkinPreviewHide;

		// Token: 0x0401ECD1 RID: 126161
		[Token(Token = "0x401ECD1")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__HandleSkinPreviewShow;

		// Token: 0x0401ECD2 RID: 126162
		[Token(Token = "0x401ECD2")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HandleIllustClick;

		// Token: 0x0401ECD3 RID: 126163
		[Token(Token = "0x401ECD3")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__HandleSkinItemClicked;

		// Token: 0x0401ECD4 RID: 126164
		[Token(Token = "0x401ECD4")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateSkinIllustVisible;

		// Token: 0x0401ECD5 RID: 126165
		[Token(Token = "0x401ECD5")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__HandleSkinStateChanged;

		// Token: 0x0401ECD6 RID: 126166
		[Token(Token = "0x401ECD6")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnBtnPreview;

		// Token: 0x0401ECD7 RID: 126167
		[Token(Token = "0x401ECD7")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnBtnSwitchSpDynIllust;

		// Token: 0x0401ECD8 RID: 126168
		[Token(Token = "0x401ECD8")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_ChangeSelectState;

		// Token: 0x0401ECD9 RID: 126169
		[Token(Token = "0x401ECD9")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnSkinBuyState;

		// Token: 0x0401ECDA RID: 126170
		[Token(Token = "0x401ECDA")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003ED2 RID: 16082
		[Token(Token = "0x2003ED2")]
		public class IllustClickInfo
		{
			// Token: 0x06018F44 RID: 102212 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018F44")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IllustClickInfo()
			{
			}

			// Token: 0x0401ECDB RID: 126171
			[Token(Token = "0x401ECDB")]
			[FieldOffset(Offset = "0x10")]
			public SkinSelectViewModel viewModel;

			// Token: 0x0401ECDC RID: 126172
			[Token(Token = "0x401ECDC")]
			[FieldOffset(Offset = "0x18")]
			public UICharacterIllust illust;
		}
	}
}
