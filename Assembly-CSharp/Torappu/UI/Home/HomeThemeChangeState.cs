using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B2D RID: 19245
	[Token(Token = "0x2004B2D")]
	public class HomeThemeChangeState : HomeReplaceableState, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0601CFC1 RID: 118721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFC1")]
		[Address(RVA = "0x1678F40", Offset = "0x1677B40", VA = "0x181678F40")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CFC2 RID: 118722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFC2")]
		[Address(RVA = "0x1677D00", Offset = "0x1676900", VA = "0x181677D00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CFC3 RID: 118723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFC3")]
		[Address(RVA = "0x16782C0", Offset = "0x1676EC0", VA = "0x1816782C0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFC4")]
		[Address(RVA = "0x1678680", Offset = "0x1677280", VA = "0x181678680", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CFC5 RID: 118725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFC5")]
		[Address(RVA = "0x16787E0", Offset = "0x16773E0", VA = "0x1816787E0", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CFC6 RID: 118726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFC6")]
		[Address(RVA = "0x1677AC0", Offset = "0x16766C0", VA = "0x181677AC0", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CFC7 RID: 118727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFC7")]
		[Address(RVA = "0x1677720", Offset = "0x1676320", VA = "0x181677720", Slot = "22")]
		public override void DismissSelf()
		{
		}

		// Token: 0x0601CFC8 RID: 118728 RVA: 0x000A9F20 File Offset: 0x000A8120
		[Token(Token = "0x601CFC8")]
		[Address(RVA = "0x1678D30", Offset = "0x1677930", VA = "0x181678D30")]
		private bool _CheckAndCloseVirtualPage()
		{
			return default(bool);
		}

		// Token: 0x0601CFC9 RID: 118729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFC9")]
		[Address(RVA = "0x1678890", Offset = "0x1677490", VA = "0x181678890", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CFCA RID: 118730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFCA")]
		[Address(RVA = "0x1677B70", Offset = "0x1676770", VA = "0x181677B70", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CFCB RID: 118731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFCB")]
		[Address(RVA = "0x1677A60", Offset = "0x1676660", VA = "0x181677A60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CFCC RID: 118732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFCC")]
		[Address(RVA = "0x16778A0", Offset = "0x16764A0", VA = "0x1816778A0")]
		public void EventOnConfirmChangeClicked()
		{
		}

		// Token: 0x0601CFCD RID: 118733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFCD")]
		[Address(RVA = "0x1677990", Offset = "0x1676590", VA = "0x181677990")]
		public void EventOnHideUiClick()
		{
		}

		// Token: 0x0601CFCE RID: 118734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFCE")]
		[Address(RVA = "0x1677920", Offset = "0x1676520", VA = "0x181677920")]
		public void EventOnHideIllustClick()
		{
		}

		// Token: 0x0601CFCF RID: 118735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFCF")]
		[Address(RVA = "0x16791A0", Offset = "0x1677DA0", VA = "0x1816791A0")]
		private void _OnApplyUIState()
		{
		}

		// Token: 0x0601CFD0 RID: 118736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD0")]
		[Address(RVA = "0x16775E0", Offset = "0x16761E0", VA = "0x1816775E0")]
		public void CancelClick()
		{
		}

		// Token: 0x0601CFD1 RID: 118737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD1")]
		[Address(RVA = "0x16781C0", Offset = "0x1676DC0", VA = "0x1816781C0")]
		public void OnOpenBackGround()
		{
		}

		// Token: 0x0601CFD2 RID: 118738 RVA: 0x000A9F38 File Offset: 0x000A8138
		[Token(Token = "0x601CFD2")]
		[Address(RVA = "0x16790D0", Offset = "0x1677CD0", VA = "0x1816790D0")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601CFD3 RID: 118739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD3")]
		[Address(RVA = "0x1678B40", Offset = "0x1677740", VA = "0x181678B40")]
		private void _CancelChanging()
		{
		}

		// Token: 0x0601CFD4 RID: 118740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD4")]
		[Address(RVA = "0x16792C0", Offset = "0x1677EC0", VA = "0x1816792C0")]
		private void _UpdateSelectingTheme()
		{
		}

		// Token: 0x0601CFD5 RID: 118741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD5")]
		[Address(RVA = "0x1678A40", Offset = "0x1677640", VA = "0x181678A40")]
		private void _OnSetThemeSuccess()
		{
		}

		// Token: 0x0601CFD6 RID: 118742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD6")]
		[Address(RVA = "0x1679230", Offset = "0x1677E30", VA = "0x181679230")]
		private void _OnSortToggleClick(TwoStateToggle.State state)
		{
		}

		// Token: 0x0601CFD7 RID: 118743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFD7")]
		[Address(RVA = "0x1678E50", Offset = "0x1677A50", VA = "0x181678E50")]
		private string _GetAndConsumeRoutedHomeThemeId()
		{
			return null;
		}

		// Token: 0x0601CFD8 RID: 118744 RVA: 0x000A9F50 File Offset: 0x000A8150
		[Token(Token = "0x601CFD8")]
		[Address(RVA = "0x1677640", Offset = "0x1676240", VA = "0x181677640", Slot = "33")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601CFD9 RID: 118745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFD9")]
		[Address(RVA = "0x1678250", Offset = "0x1676E50", VA = "0x181678250", Slot = "34")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601CFDA RID: 118746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFDA")]
		[Address(RVA = "0x1677CA0", Offset = "0x16768A0", VA = "0x181677CA0")]
		private void OnEnable()
		{
		}

		// Token: 0x0601CFDB RID: 118747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFDB")]
		[Address(RVA = "0x1677C40", Offset = "0x1676840", VA = "0x181677C40")]
		private void OnDisable()
		{
		}

		// Token: 0x0601CFDC RID: 118748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFDC")]
		[Address(RVA = "0x1677BE0", Offset = "0x16767E0", VA = "0x181677BE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601CFDD RID: 118749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFDD")]
		[Address(RVA = "0x16795C0", Offset = "0x16781C0", VA = "0x1816795C0")]
		public HomeThemeChangeState()
		{
		}

		// Token: 0x0601CFE0 RID: 118752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFE0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CFE1 RID: 118753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFE1")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CFE2 RID: 118754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CFE2")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CFE3 RID: 118755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CFE3")]
		[Address(RVA = "0x1637780", Offset = "0x1636380", VA = "0x181637780")]
		private void <>xLuaBaseProxy_DismissSelf()
		{
		}

		// Token: 0x04026050 RID: 155728
		[Token(Token = "0x4026050")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04026051 RID: 155729
		[Token(Token = "0x4026051")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HomeThemeChangeView _view;

		// Token: 0x04026052 RID: 155730
		[Token(Token = "0x4026052")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _showUICanvas;

		// Token: 0x04026053 RID: 155731
		[Token(Token = "0x4026053")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _rectCancel;

		// Token: 0x04026054 RID: 155732
		[Token(Token = "0x4026054")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelRouteToBkgChange;

		// Token: 0x04026055 RID: 155733
		[Token(Token = "0x4026055")]
		[FieldOffset(Offset = "0x88")]
		private HomeThemeChangeStateBean m_stateBean;

		// Token: 0x04026056 RID: 155734
		[Token(Token = "0x4026056")]
		[FieldOffset(Offset = "0x90")]
		private bool m_showUIFlag;

		// Token: 0x04026057 RID: 155735
		[Token(Token = "0x4026057")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_tween;

		// Token: 0x04026058 RID: 155736
		[Token(Token = "0x4026058")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04026059 RID: 155737
		[Token(Token = "0x4026059")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402605A RID: 155738
		[Token(Token = "0x402605A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402605B RID: 155739
		[Token(Token = "0x402605B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402605C RID: 155740
		[Token(Token = "0x402605C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402605D RID: 155741
		[Token(Token = "0x402605D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x0402605E RID: 155742
		[Token(Token = "0x402605E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x0402605F RID: 155743
		[Token(Token = "0x402605F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x04026060 RID: 155744
		[Token(Token = "0x4026060")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckAndCloseVirtualPage;

		// Token: 0x04026061 RID: 155745
		[Token(Token = "0x4026061")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04026062 RID: 155746
		[Token(Token = "0x4026062")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04026063 RID: 155747
		[Token(Token = "0x4026063")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04026064 RID: 155748
		[Token(Token = "0x4026064")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnConfirmChangeClicked;

		// Token: 0x04026065 RID: 155749
		[Token(Token = "0x4026065")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnHideUiClick;

		// Token: 0x04026066 RID: 155750
		[Token(Token = "0x4026066")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnHideIllustClick;

		// Token: 0x04026067 RID: 155751
		[Token(Token = "0x4026067")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnApplyUIState;

		// Token: 0x04026068 RID: 155752
		[Token(Token = "0x4026068")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CancelClick;

		// Token: 0x04026069 RID: 155753
		[Token(Token = "0x4026069")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnOpenBackGround;

		// Token: 0x0402606A RID: 155754
		[Token(Token = "0x402606A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x0402606B RID: 155755
		[Token(Token = "0x402606B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CancelChanging;

		// Token: 0x0402606C RID: 155756
		[Token(Token = "0x402606C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateSelectingTheme;

		// Token: 0x0402606D RID: 155757
		[Token(Token = "0x402606D")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSetThemeSuccess;

		// Token: 0x0402606E RID: 155758
		[Token(Token = "0x402606E")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnSortToggleClick;

		// Token: 0x0402606F RID: 155759
		[Token(Token = "0x402606F")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__GetAndConsumeRoutedHomeThemeId;

		// Token: 0x04026070 RID: 155760
		[Token(Token = "0x4026070")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04026071 RID: 155761
		[Token(Token = "0x4026071")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04026072 RID: 155762
		[Token(Token = "0x4026072")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04026073 RID: 155763
		[Token(Token = "0x4026073")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04026074 RID: 155764
		[Token(Token = "0x4026074")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04026075 RID: 155765
		[Token(Token = "0x4026075")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
