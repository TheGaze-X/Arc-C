using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B26 RID: 19238
	[Token(Token = "0x2004B26")]
	public class HomeSecretaryChangeState : HomeReplaceableState
	{
		// Token: 0x0601CF5E RID: 118622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF5E")]
		[Address(RVA = "0x1672820", Offset = "0x1671420", VA = "0x181672820")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0601CF5F RID: 118623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF5F")]
		[Address(RVA = "0x1672A60", Offset = "0x1671660", VA = "0x181672A60")]
		public void EventOnConfirmChangeClicked()
		{
		}

		// Token: 0x0601CF60 RID: 118624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF60")]
		[Address(RVA = "0x1672AD0", Offset = "0x16716D0", VA = "0x181672AD0")]
		public void EventOnFilterClick(CharacterFilterViewModel filterModel)
		{
		}

		// Token: 0x0601CF61 RID: 118625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF61")]
		[Address(RVA = "0x1672B60", Offset = "0x1671760", VA = "0x181672B60")]
		public void EventOnSortClick(CharacterSortType sortType)
		{
		}

		// Token: 0x0601CF62 RID: 118626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF62")]
		[Address(RVA = "0x1672BF0", Offset = "0x16717F0", VA = "0x181672BF0")]
		public void EventOnStarMarkToggleClick()
		{
		}

		// Token: 0x0601CF63 RID: 118627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF63")]
		[Address(RVA = "0x1672960", Offset = "0x1671560", VA = "0x181672960")]
		public void EventOnCharItemClick(int chrInstId)
		{
		}

		// Token: 0x0601CF64 RID: 118628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF64")]
		[Address(RVA = "0x1673C30", Offset = "0x1672830", VA = "0x181673C30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CF65 RID: 118629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF65")]
		[Address(RVA = "0x1674240", Offset = "0x1672E40", VA = "0x181674240")]
		private void _StartPreviewMode()
		{
		}

		// Token: 0x0601CF66 RID: 118630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF66")]
		[Address(RVA = "0x16738A0", Offset = "0x16724A0", VA = "0x1816738A0")]
		private void _ExitPreviewMode()
		{
		}

		// Token: 0x0601CF67 RID: 118631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF67")]
		[Address(RVA = "0x1674140", Offset = "0x1672D40", VA = "0x181674140")]
		private void _OnCancel()
		{
		}

		// Token: 0x0601CF68 RID: 118632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF68")]
		[Address(RVA = "0x16739C0", Offset = "0x16725C0", VA = "0x1816739C0")]
		private void _GotoSecretarySkinChangeState()
		{
		}

		// Token: 0x0601CF69 RID: 118633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF69")]
		[Address(RVA = "0x1673FC0", Offset = "0x1672BC0", VA = "0x181673FC0")]
		private void _ModifyIllustViewConfig(bool show)
		{
		}

		// Token: 0x0601CF6A RID: 118634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF6A")]
		[Address(RVA = "0x1674330", Offset = "0x1672F30", VA = "0x181674330")]
		private void _SyncIllustView()
		{
		}

		// Token: 0x0601CF6B RID: 118635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF6B")]
		[Address(RVA = "0x16743A0", Offset = "0x1672FA0", VA = "0x1816743A0")]
		private void _UpdateIllustView(bool show)
		{
		}

		// Token: 0x0601CF6C RID: 118636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF6C")]
		[Address(RVA = "0x1673820", Offset = "0x1672420", VA = "0x181673820")]
		private void _DisposeIllustConfig()
		{
		}

		// Token: 0x0601CF6D RID: 118637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF6D")]
		[Address(RVA = "0x1672C60", Offset = "0x1671860", VA = "0x181672C60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CF6E RID: 118638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF6E")]
		[Address(RVA = "0x1672E50", Offset = "0x1671A50", VA = "0x181672E50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CF6F RID: 118639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF6F")]
		[Address(RVA = "0x1673260", Offset = "0x1671E60", VA = "0x181673260", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CF70 RID: 118640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF70")]
		[Address(RVA = "0x16731E0", Offset = "0x1671DE0", VA = "0x1816731E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CF71 RID: 118641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF71")]
		[Address(RVA = "0x1672DE0", Offset = "0x16719E0", VA = "0x181672DE0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601CF72 RID: 118642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF72")]
		[Address(RVA = "0x1673460", Offset = "0x1672060", VA = "0x181673460", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CF73 RID: 118643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF73")]
		[Address(RVA = "0x1672CC0", Offset = "0x16718C0", VA = "0x181672CC0", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CF74 RID: 118644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF74")]
		[Address(RVA = "0x1673530", Offset = "0x1672130", VA = "0x181673530", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CF75 RID: 118645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF75")]
		[Address(RVA = "0x1672D70", Offset = "0x1671970", VA = "0x181672D70", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CF76 RID: 118646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF76")]
		[Address(RVA = "0x16732F0", Offset = "0x1671EF0", VA = "0x1816732F0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CF77 RID: 118647 RVA: 0x000A9DE8 File Offset: 0x000A7FE8
		[Token(Token = "0x601CF77")]
		[Address(RVA = "0x16737B0", Offset = "0x16723B0", VA = "0x1816737B0", Slot = "12")]
		public override bool UseEarlyFromDataListener(Type fromState)
		{
			return default(bool);
		}

		// Token: 0x0601CF78 RID: 118648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF78")]
		[Address(RVA = "0x1674420", Offset = "0x1673020", VA = "0x181674420")]
		public HomeSecretaryChangeState()
		{
		}

		// Token: 0x0601CF7C RID: 118652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF7C")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CF7D RID: 118653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF7D")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CF7E RID: 118654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CF7E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601CF7F RID: 118655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CF7F")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CF80 RID: 118656 RVA: 0x000A9E30 File Offset: 0x000A8030
		[Token(Token = "0x601CF80")]
		[Address(RVA = "0x11033F0", Offset = "0x1101FF0", VA = "0x1811033F0")]
		private bool <>xLuaBaseProxy_UseEarlyFromDataListener(Type P0)
		{
			return default(bool);
		}

		// Token: 0x04025FD8 RID: 155608
		[Token(Token = "0x4025FD8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaFadePart1;

		// Token: 0x04025FD9 RID: 155609
		[Token(Token = "0x4025FD9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _alphaFadePart2;

		// Token: 0x04025FDA RID: 155610
		[Token(Token = "0x4025FDA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _alphaNormPart1;

		// Token: 0x04025FDB RID: 155611
		[Token(Token = "0x4025FDB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _alphaNormPart2;

		// Token: 0x04025FDC RID: 155612
		[Token(Token = "0x4025FDC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04025FDD RID: 155613
		[Token(Token = "0x4025FDD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private HomeSecretaryChangeView _view;

		// Token: 0x04025FDE RID: 155614
		[Token(Token = "0x4025FDE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICharacterSortTypeGroupBinder _sortTypeBinder;

		// Token: 0x04025FDF RID: 155615
		[Token(Token = "0x4025FDF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UICharacterStarMarkTopItemBinder _starMarkBinder;

		// Token: 0x04025FE0 RID: 155616
		[Token(Token = "0x4025FE0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UICharacterSecretarySortFilterPanelBinder _filterBinder;

		// Token: 0x04025FE1 RID: 155617
		[Token(Token = "0x4025FE1")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x04025FE2 RID: 155618
		[Token(Token = "0x4025FE2")]
		[FieldOffset(Offset = "0xAC")]
		private int m_instId;

		// Token: 0x04025FE3 RID: 155619
		[Token(Token = "0x4025FE3")]
		[FieldOffset(Offset = "0xB0")]
		private HomeSecretaryChangeStateBean m_stateBean;

		// Token: 0x04025FE4 RID: 155620
		[Token(Token = "0x4025FE4")]
		[FieldOffset(Offset = "0xB8")]
		private HomeReplaceableState.SwitchTween m_tweenFadePart1;

		// Token: 0x04025FE5 RID: 155621
		[Token(Token = "0x4025FE5")]
		[FieldOffset(Offset = "0xC0")]
		private HomeReplaceableState.SwitchTween m_tweenFadePart2;

		// Token: 0x04025FE6 RID: 155622
		[Token(Token = "0x4025FE6")]
		[FieldOffset(Offset = "0xC8")]
		private HomeReplaceableState.SwitchTween m_tweenNormPart1;

		// Token: 0x04025FE7 RID: 155623
		[Token(Token = "0x4025FE7")]
		[FieldOffset(Offset = "0xD0")]
		private HomeReplaceableState.SwitchTween m_tweenNormPart2;

		// Token: 0x04025FE8 RID: 155624
		[Token(Token = "0x4025FE8")]
		[FieldOffset(Offset = "0xD8")]
		private HomeSecretaryChangeSkinStateBean.InputParams m_paramToSkinChangeState;

		// Token: 0x04025FE9 RID: 155625
		[Token(Token = "0x4025FE9")]
		[FieldOffset(Offset = "0xF8")]
		private HomeIllustView m_illustView;

		// Token: 0x04025FEA RID: 155626
		[Token(Token = "0x4025FEA")]
		[FieldOffset(Offset = "0x100")]
		private HomeIllustView.DisplayHandler m_IllustDisplayHandler;

		// Token: 0x04025FEB RID: 155627
		[Token(Token = "0x4025FEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04025FEC RID: 155628
		[Token(Token = "0x4025FEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmChangeClicked;

		// Token: 0x04025FED RID: 155629
		[Token(Token = "0x4025FED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnFilterClick;

		// Token: 0x04025FEE RID: 155630
		[Token(Token = "0x4025FEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnSortClick;

		// Token: 0x04025FEF RID: 155631
		[Token(Token = "0x4025FEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnStarMarkToggleClick;

		// Token: 0x04025FF0 RID: 155632
		[Token(Token = "0x4025FF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCharItemClick;

		// Token: 0x04025FF1 RID: 155633
		[Token(Token = "0x4025FF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025FF2 RID: 155634
		[Token(Token = "0x4025FF2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__StartPreviewMode;

		// Token: 0x04025FF3 RID: 155635
		[Token(Token = "0x4025FF3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ExitPreviewMode;

		// Token: 0x04025FF4 RID: 155636
		[Token(Token = "0x4025FF4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x04025FF5 RID: 155637
		[Token(Token = "0x4025FF5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GotoSecretarySkinChangeState;

		// Token: 0x04025FF6 RID: 155638
		[Token(Token = "0x4025FF6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ModifyIllustViewConfig;

		// Token: 0x04025FF7 RID: 155639
		[Token(Token = "0x4025FF7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__SyncIllustView;

		// Token: 0x04025FF8 RID: 155640
		[Token(Token = "0x4025FF8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateIllustView;

		// Token: 0x04025FF9 RID: 155641
		[Token(Token = "0x4025FF9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DisposeIllustConfig;

		// Token: 0x04025FFA RID: 155642
		[Token(Token = "0x4025FFA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025FFB RID: 155643
		[Token(Token = "0x4025FFB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025FFC RID: 155644
		[Token(Token = "0x4025FFC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025FFD RID: 155645
		[Token(Token = "0x4025FFD")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025FFE RID: 155646
		[Token(Token = "0x4025FFE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025FFF RID: 155647
		[Token(Token = "0x4025FFF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04026000 RID: 155648
		[Token(Token = "0x4026000")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04026001 RID: 155649
		[Token(Token = "0x4026001")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04026002 RID: 155650
		[Token(Token = "0x4026002")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04026003 RID: 155651
		[Token(Token = "0x4026003")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04026004 RID: 155652
		[Token(Token = "0x4026004")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_UseEarlyFromDataListener;

		// Token: 0x04026005 RID: 155653
		[Token(Token = "0x4026005")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
