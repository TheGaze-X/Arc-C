using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B04 RID: 19204
	[Token(Token = "0x2004B04")]
	public class HomeBackgroundChangeState : HomeReplaceableState, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0601CD9B RID: 118171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD9B")]
		[Address(RVA = "0x163E820", Offset = "0x163D420", VA = "0x18163E820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CD9C RID: 118172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD9C")]
		[Address(RVA = "0x163EE10", Offset = "0x163DA10", VA = "0x18163EE10")]
		private void _StartPreviewMode()
		{
		}

		// Token: 0x0601CD9D RID: 118173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD9D")]
		[Address(RVA = "0x163E570", Offset = "0x163D170", VA = "0x18163E570")]
		private void _ExitPreviewMode()
		{
		}

		// Token: 0x0601CD9E RID: 118174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CD9E")]
		[Address(RVA = "0x163E790", Offset = "0x163D390", VA = "0x18163E790")]
		private void _HandleBgSelectChanged(string bgId)
		{
		}

		// Token: 0x0601CD9F RID: 118175 RVA: 0x000A9A88 File Offset: 0x000A7C88
		[Token(Token = "0x601CD9F")]
		[Address(RVA = "0x163EBB0", Offset = "0x163D7B0", VA = "0x18163EBB0")]
		private bool _IsStateStable()
		{
			return default(bool);
		}

		// Token: 0x0601CDA0 RID: 118176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA0")]
		[Address(RVA = "0x163E1D0", Offset = "0x163CDD0", VA = "0x18163E1D0")]
		private void _CancelChanging()
		{
		}

		// Token: 0x0601CDA1 RID: 118177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA1")]
		[Address(RVA = "0x163ED10", Offset = "0x163D910", VA = "0x18163ED10")]
		private void _OnHideIllustClick()
		{
		}

		// Token: 0x0601CDA2 RID: 118178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA2")]
		[Address(RVA = "0x163ED80", Offset = "0x163D980", VA = "0x18163ED80")]
		private void _OnSortToggleClick(TwoStateToggle.State state)
		{
		}

		// Token: 0x0601CDA3 RID: 118179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA3")]
		[Address(RVA = "0x163EF00", Offset = "0x163DB00", VA = "0x18163EF00")]
		private void _UpdateSelectingBackground()
		{
		}

		// Token: 0x0601CDA4 RID: 118180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA4")]
		[Address(RVA = "0x163E0D0", Offset = "0x163CCD0", VA = "0x18163E0D0")]
		private void _OnSetBackgroundSuccess()
		{
		}

		// Token: 0x0601CDA5 RID: 118181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA5")]
		[Address(RVA = "0x163EC80", Offset = "0x163D880", VA = "0x18163EC80")]
		private void _OnApplyUIState()
		{
		}

		// Token: 0x0601CDA6 RID: 118182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDA6")]
		[Address(RVA = "0x163E9D0", Offset = "0x163D5D0", VA = "0x18163E9D0")]
		private void _InitView(bool ascend)
		{
		}

		// Token: 0x0601CDA7 RID: 118183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDA7")]
		[Address(RVA = "0x163E690", Offset = "0x163D290", VA = "0x18163E690")]
		private string _GetAndConsumeRoutedHomeBkgId()
		{
			return null;
		}

		// Token: 0x0601CDA8 RID: 118184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDA8")]
		[Address(RVA = "0x163D340", Offset = "0x163BF40", VA = "0x18163D340", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CDA9 RID: 118185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDA9")]
		[Address(RVA = "0x163DE30", Offset = "0x163CA30", VA = "0x18163DE30", Slot = "29")]
		protected override IEnumerator ShowEffect(HomeReplaceableState extractState)
		{
			return null;
		}

		// Token: 0x0601CDAA RID: 118186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDAA")]
		[Address(RVA = "0x163D3A0", Offset = "0x163BFA0", VA = "0x18163D3A0", Slot = "30")]
		protected override IEnumerator HideEffect()
		{
			return null;
		}

		// Token: 0x0601CDAB RID: 118187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDAB")]
		[Address(RVA = "0x163DEE0", Offset = "0x163CAE0", VA = "0x18163DEE0", Slot = "31")]
		protected override void ShowFastMode()
		{
		}

		// Token: 0x0601CDAC RID: 118188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDAC")]
		[Address(RVA = "0x163D450", Offset = "0x163C050", VA = "0x18163D450", Slot = "32")]
		protected override void HideFastMode()
		{
		}

		// Token: 0x0601CDAD RID: 118189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDAD")]
		[Address(RVA = "0x163D5F0", Offset = "0x163C1F0", VA = "0x18163D5F0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CDAE RID: 118190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDAE")]
		[Address(RVA = "0x163DBC0", Offset = "0x163C7C0", VA = "0x18163DBC0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601CDAF RID: 118191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDAF")]
		[Address(RVA = "0x163DCC0", Offset = "0x163C8C0", VA = "0x18163DCC0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CDB0 RID: 118192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB0")]
		[Address(RVA = "0x163D590", Offset = "0x163C190", VA = "0x18163D590")]
		private void OnEnable()
		{
		}

		// Token: 0x0601CDB1 RID: 118193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB1")]
		[Address(RVA = "0x163D530", Offset = "0x163C130", VA = "0x18163D530")]
		private void OnDisable()
		{
		}

		// Token: 0x0601CDB2 RID: 118194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB2")]
		[Address(RVA = "0x163D4C0", Offset = "0x163C0C0", VA = "0x18163D4C0")]
		protected void OnDestroy()
		{
		}

		// Token: 0x0601CDB3 RID: 118195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB3")]
		[Address(RVA = "0x163D0D0", Offset = "0x163BCD0", VA = "0x18163D0D0")]
		public void EventOnCancelClicked()
		{
		}

		// Token: 0x0601CDB4 RID: 118196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB4")]
		[Address(RVA = "0x163D150", Offset = "0x163BD50", VA = "0x18163D150")]
		public void EventOnConfirmChangeClicked()
		{
		}

		// Token: 0x0601CDB5 RID: 118197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB5")]
		[Address(RVA = "0x163D1D0", Offset = "0x163BDD0", VA = "0x18163D1D0")]
		public void EventOnEditIllustClicked()
		{
		}

		// Token: 0x0601CDB6 RID: 118198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB6")]
		[Address(RVA = "0x163D270", Offset = "0x163BE70", VA = "0x18163D270")]
		public void EventOnHideUiClick()
		{
		}

		// Token: 0x0601CDB7 RID: 118199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDB7")]
		[Address(RVA = "0x163CF50", Offset = "0x163BB50", VA = "0x18163CF50", Slot = "22")]
		public override void DismissSelf()
		{
		}

		// Token: 0x0601CDB8 RID: 118200 RVA: 0x000A9AA0 File Offset: 0x000A7CA0
		[Token(Token = "0x601CDB8")]
		[Address(RVA = "0x163E450", Offset = "0x163D050", VA = "0x18163E450")]
		private bool _CheckAndCloseVirtualPage()
		{
			return default(bool);
		}

		// Token: 0x0601CDB9 RID: 118201 RVA: 0x000A9AB8 File Offset: 0x000A7CB8
		[Token(Token = "0x601CDB9")]
		[Address(RVA = "0x163CE70", Offset = "0x163BA70", VA = "0x18163CE70", Slot = "33")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601CDBA RID: 118202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDBA")]
		[Address(RVA = "0x163DC50", Offset = "0x163C850", VA = "0x18163DC50", Slot = "34")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0601CDBB RID: 118203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDBB")]
		[Address(RVA = "0x163F210", Offset = "0x163DE10", VA = "0x18163F210")]
		public HomeBackgroundChangeState()
		{
		}

		// Token: 0x0601CDBE RID: 118206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDBE")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CDBF RID: 118207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDBF")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601CDC0 RID: 118208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CDC0")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CDC1 RID: 118209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CDC1")]
		[Address(RVA = "0x1637780", Offset = "0x1636380", VA = "0x181637780")]
		private void <>xLuaBaseProxy_DismissSelf()
		{
		}

		// Token: 0x04025DA0 RID: 155040
		[Token(Token = "0x4025DA0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04025DA1 RID: 155041
		[Token(Token = "0x4025DA1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _rectCancel;

		// Token: 0x04025DA2 RID: 155042
		[Token(Token = "0x4025DA2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HomeBackgroundChangeView _view;

		// Token: 0x04025DA3 RID: 155043
		[Token(Token = "0x4025DA3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _hideUI;

		// Token: 0x04025DA4 RID: 155044
		[Token(Token = "0x4025DA4")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x04025DA5 RID: 155045
		[Token(Token = "0x4025DA5")]
		[FieldOffset(Offset = "0x84")]
		private int m_instId;

		// Token: 0x04025DA6 RID: 155046
		[Token(Token = "0x4025DA6")]
		[FieldOffset(Offset = "0x88")]
		private HomeBackgroundChangeStateBean m_stateBean;

		// Token: 0x04025DA7 RID: 155047
		[Token(Token = "0x4025DA7")]
		[FieldOffset(Offset = "0x90")]
		private bool m_showUIFlag;

		// Token: 0x04025DA8 RID: 155048
		[Token(Token = "0x4025DA8")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_tween;

		// Token: 0x04025DA9 RID: 155049
		[Token(Token = "0x4025DA9")]
		private const bool INIT_SORT_IS_ASCEND = true;

		// Token: 0x04025DAA RID: 155050
		[Token(Token = "0x4025DAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025DAB RID: 155051
		[Token(Token = "0x4025DAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__StartPreviewMode;

		// Token: 0x04025DAC RID: 155052
		[Token(Token = "0x4025DAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ExitPreviewMode;

		// Token: 0x04025DAD RID: 155053
		[Token(Token = "0x4025DAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleBgSelectChanged;

		// Token: 0x04025DAE RID: 155054
		[Token(Token = "0x4025DAE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsStateStable;

		// Token: 0x04025DAF RID: 155055
		[Token(Token = "0x4025DAF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CancelChanging;

		// Token: 0x04025DB0 RID: 155056
		[Token(Token = "0x4025DB0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnHideIllustClick;

		// Token: 0x04025DB1 RID: 155057
		[Token(Token = "0x4025DB1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSortToggleClick;

		// Token: 0x04025DB2 RID: 155058
		[Token(Token = "0x4025DB2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateSelectingBackground;

		// Token: 0x04025DB3 RID: 155059
		[Token(Token = "0x4025DB3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnSetBackgroundSuccess;

		// Token: 0x04025DB4 RID: 155060
		[Token(Token = "0x4025DB4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnApplyUIState;

		// Token: 0x04025DB5 RID: 155061
		[Token(Token = "0x4025DB5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x04025DB6 RID: 155062
		[Token(Token = "0x4025DB6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetAndConsumeRoutedHomeBkgId;

		// Token: 0x04025DB7 RID: 155063
		[Token(Token = "0x4025DB7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025DB8 RID: 155064
		[Token(Token = "0x4025DB8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowEffect;

		// Token: 0x04025DB9 RID: 155065
		[Token(Token = "0x4025DB9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideEffect;

		// Token: 0x04025DBA RID: 155066
		[Token(Token = "0x4025DBA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ShowFastMode;

		// Token: 0x04025DBB RID: 155067
		[Token(Token = "0x4025DBB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_HideFastMode;

		// Token: 0x04025DBC RID: 155068
		[Token(Token = "0x4025DBC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025DBD RID: 155069
		[Token(Token = "0x4025DBD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04025DBE RID: 155070
		[Token(Token = "0x4025DBE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025DBF RID: 155071
		[Token(Token = "0x4025DBF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04025DC0 RID: 155072
		[Token(Token = "0x4025DC0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04025DC1 RID: 155073
		[Token(Token = "0x4025DC1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04025DC2 RID: 155074
		[Token(Token = "0x4025DC2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_EventOnCancelClicked;

		// Token: 0x04025DC3 RID: 155075
		[Token(Token = "0x4025DC3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_EventOnConfirmChangeClicked;

		// Token: 0x04025DC4 RID: 155076
		[Token(Token = "0x4025DC4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_EventOnEditIllustClicked;

		// Token: 0x04025DC5 RID: 155077
		[Token(Token = "0x4025DC5")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_EventOnHideUiClick;

		// Token: 0x04025DC6 RID: 155078
		[Token(Token = "0x4025DC6")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_DismissSelf;

		// Token: 0x04025DC7 RID: 155079
		[Token(Token = "0x4025DC7")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckAndCloseVirtualPage;

		// Token: 0x04025DC8 RID: 155080
		[Token(Token = "0x4025DC8")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04025DC9 RID: 155081
		[Token(Token = "0x4025DC9")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04025DCA RID: 155082
		[Token(Token = "0x4025DCA")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
