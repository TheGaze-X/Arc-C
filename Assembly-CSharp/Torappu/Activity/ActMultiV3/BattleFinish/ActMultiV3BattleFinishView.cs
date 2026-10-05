using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Multiplayer;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using Torappu.UI.ReportPlayer;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007098 RID: 28824
	[Token(Token = "0x2007098")]
	public class ActMultiV3BattleFinishView : DynBattleFinishView
	{
		// Token: 0x06028F32 RID: 167730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F32")]
		[Address(RVA = "0x2456660", Offset = "0x2455260", VA = "0x182456660", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x06028F33 RID: 167731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F33")]
		[Address(RVA = "0x2455CE0", Offset = "0x24548E0", VA = "0x182455CE0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028F34 RID: 167732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F34")]
		[Address(RVA = "0x2456960", Offset = "0x2455560", VA = "0x182456960")]
		private ActMultiV3BattleFinishViewModel _CreateViewModel()
		{
			return null;
		}

		// Token: 0x06028F35 RID: 167733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F35")]
		[Address(RVA = "0x24579C0", Offset = "0x24565C0", VA = "0x1824579C0")]
		private MultiplayerInput _GetMultiplayerInput()
		{
			return null;
		}

		// Token: 0x06028F36 RID: 167734 RVA: 0x000D3AA0 File Offset: 0x000D1CA0
		[Token(Token = "0x6028F36")]
		[Address(RVA = "0x2456720", Offset = "0x2455320", VA = "0x182456720")]
		private bool _CheckIfTraining()
		{
			return default(bool);
		}

		// Token: 0x06028F37 RID: 167735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F37")]
		[Address(RVA = "0x2457760", Offset = "0x2456360", VA = "0x182457760")]
		private BattleFinishRspData _GetBattleFinishRspData(bool isTraining)
		{
			return null;
		}

		// Token: 0x06028F38 RID: 167736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F38")]
		[Address(RVA = "0x2457540", Offset = "0x2456140", VA = "0x182457540")]
		private void _EventOnReportShow()
		{
		}

		// Token: 0x06028F39 RID: 167737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F39")]
		[Address(RVA = "0x24574E0", Offset = "0x24560E0", VA = "0x1824574E0")]
		private void _EventOnReportHide()
		{
		}

		// Token: 0x06028F3A RID: 167738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3A")]
		[Address(RVA = "0x2457470", Offset = "0x2456070", VA = "0x182457470")]
		private void _EventOnReportButNoItemSelect(string toast)
		{
		}

		// Token: 0x06028F3B RID: 167739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3B")]
		[Address(RVA = "0x24575A0", Offset = "0x24561A0", VA = "0x1824575A0")]
		private void _EventOnReportSuc(string uid)
		{
		}

		// Token: 0x06028F3C RID: 167740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3C")]
		[Address(RVA = "0x2458C70", Offset = "0x2457870", VA = "0x182458C70")]
		private void _SetReportPanelVisible(bool isShow)
		{
		}

		// Token: 0x06028F3D RID: 167741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3D")]
		[Address(RVA = "0x2458920", Offset = "0x2457520", VA = "0x182458920")]
		private void _OnNextClick()
		{
		}

		// Token: 0x06028F3E RID: 167742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3E")]
		[Address(RVA = "0x2458500", Offset = "0x2457100", VA = "0x182458500")]
		private void _OnBackHomeClick()
		{
		}

		// Token: 0x06028F3F RID: 167743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F3F")]
		[Address(RVA = "0x24585E0", Offset = "0x24571E0", VA = "0x1824585E0")]
		private void _OnBackRoomClick()
		{
		}

		// Token: 0x06028F40 RID: 167744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F40")]
		[Address(RVA = "0x2458690", Offset = "0x2457290", VA = "0x182458690")]
		private void _OnContinueCoop()
		{
		}

		// Token: 0x06028F41 RID: 167745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F41")]
		[Address(RVA = "0x2458570", Offset = "0x2457170", VA = "0x182458570")]
		private void _OnBackMatchClick()
		{
		}

		// Token: 0x06028F42 RID: 167746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F42")]
		[Address(RVA = "0x2456FD0", Offset = "0x2455BD0", VA = "0x182456FD0")]
		private void _EventOnBtnLikeClick()
		{
		}

		// Token: 0x06028F43 RID: 167747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F43")]
		[Address(RVA = "0x2458A00", Offset = "0x2457600", VA = "0x182458A00")]
		private void _RouteToAct(bool isBackToEntry, bool continueCoop)
		{
		}

		// Token: 0x06028F44 RID: 167748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F44")]
		[Address(RVA = "0x2458320", Offset = "0x2456F20", VA = "0x182458320")]
		private void _HandleTeamChanged(object arg)
		{
		}

		// Token: 0x06028F45 RID: 167749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F45")]
		[Address(RVA = "0x2457BF0", Offset = "0x24567F0", VA = "0x182457BF0")]
		private void _HandleGotLike()
		{
		}

		// Token: 0x06028F46 RID: 167750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F46")]
		[Address(RVA = "0x2457E40", Offset = "0x2456A40", VA = "0x182457E40")]
		private void _HandlePartnerContinue()
		{
		}

		// Token: 0x06028F47 RID: 167751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F47")]
		[Address(RVA = "0x24581C0", Offset = "0x2456DC0", VA = "0x1824581C0")]
		private void _HandleSelfContinue()
		{
		}

		// Token: 0x06028F48 RID: 167752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F48")]
		[Address(RVA = "0x2458DA0", Offset = "0x24579A0", VA = "0x182458DA0")]
		public ActMultiV3BattleFinishView()
		{
		}

		// Token: 0x06028F4A RID: 167754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F4A")]
		[Address(RVA = "0x17E4700", Offset = "0x17E3300", VA = "0x1817E4700")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0403A729 RID: 239401
		[Token(Token = "0x403A729")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _blurBg;

		// Token: 0x0403A72A RID: 239402
		[Token(Token = "0x403A72A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3BattleFinishCompleteInfoView _completeInfoPrefab;

		// Token: 0x0403A72B RID: 239403
		[Token(Token = "0x403A72B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ActMultiV3BattleFinishPlayerDisplayView _playerDisplayPrefab;

		// Token: 0x0403A72C RID: 239404
		[Token(Token = "0x403A72C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ReportPlayerPanel _reportPanelPrefab;

		// Token: 0x0403A72D RID: 239405
		[Token(Token = "0x403A72D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _completeInfoContainer;

		// Token: 0x0403A72E RID: 239406
		[Token(Token = "0x403A72E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _playerDisplayContainer;

		// Token: 0x0403A72F RID: 239407
		[Token(Token = "0x403A72F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _reportPanelContainer;

		// Token: 0x0403A730 RID: 239408
		[Token(Token = "0x403A730")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _autoNextInterval;

		// Token: 0x0403A731 RID: 239409
		[Token(Token = "0x403A731")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_hasConfirm;

		// Token: 0x0403A732 RID: 239410
		[Token(Token = "0x403A732")]
		[FieldOffset(Offset = "0x60")]
		private ActMultiV3BattleFinishViewModel m_viewModel;

		// Token: 0x0403A733 RID: 239411
		[Token(Token = "0x403A733")]
		[FieldOffset(Offset = "0x68")]
		private ActMultiV3BattleFinishCompleteInfoView m_completeInfoView;

		// Token: 0x0403A734 RID: 239412
		[Token(Token = "0x403A734")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3BattleFinishPlayerDisplayView m_playerDisplayView;

		// Token: 0x0403A735 RID: 239413
		[Token(Token = "0x403A735")]
		[FieldOffset(Offset = "0x78")]
		private ReportPlayerPanel m_reportPanel;

		// Token: 0x0403A736 RID: 239414
		[Token(Token = "0x403A736")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403A737 RID: 239415
		[Token(Token = "0x403A737")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A738 RID: 239416
		[Token(Token = "0x403A738")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateViewModel;

		// Token: 0x0403A739 RID: 239417
		[Token(Token = "0x403A739")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetMultiplayerInput;

		// Token: 0x0403A73A RID: 239418
		[Token(Token = "0x403A73A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfTraining;

		// Token: 0x0403A73B RID: 239419
		[Token(Token = "0x403A73B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetBattleFinishRspData;

		// Token: 0x0403A73C RID: 239420
		[Token(Token = "0x403A73C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnReportShow;

		// Token: 0x0403A73D RID: 239421
		[Token(Token = "0x403A73D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnReportHide;

		// Token: 0x0403A73E RID: 239422
		[Token(Token = "0x403A73E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EventOnReportButNoItemSelect;

		// Token: 0x0403A73F RID: 239423
		[Token(Token = "0x403A73F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnReportSuc;

		// Token: 0x0403A740 RID: 239424
		[Token(Token = "0x403A740")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetReportPanelVisible;

		// Token: 0x0403A741 RID: 239425
		[Token(Token = "0x403A741")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnNextClick;

		// Token: 0x0403A742 RID: 239426
		[Token(Token = "0x403A742")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnBackHomeClick;

		// Token: 0x0403A743 RID: 239427
		[Token(Token = "0x403A743")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnBackRoomClick;

		// Token: 0x0403A744 RID: 239428
		[Token(Token = "0x403A744")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnContinueCoop;

		// Token: 0x0403A745 RID: 239429
		[Token(Token = "0x403A745")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnBackMatchClick;

		// Token: 0x0403A746 RID: 239430
		[Token(Token = "0x403A746")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__EventOnBtnLikeClick;

		// Token: 0x0403A747 RID: 239431
		[Token(Token = "0x403A747")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__RouteToAct;

		// Token: 0x0403A748 RID: 239432
		[Token(Token = "0x403A748")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HandleTeamChanged;

		// Token: 0x0403A749 RID: 239433
		[Token(Token = "0x403A749")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__HandleGotLike;

		// Token: 0x0403A74A RID: 239434
		[Token(Token = "0x403A74A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandlePartnerContinue;

		// Token: 0x0403A74B RID: 239435
		[Token(Token = "0x403A74B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleSelfContinue;

		// Token: 0x0403A74C RID: 239436
		[Token(Token = "0x403A74C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
