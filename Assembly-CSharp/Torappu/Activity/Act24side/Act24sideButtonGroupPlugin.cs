using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007589 RID: 30089
	[Token(Token = "0x2007589")]
	public class Act24sideButtonGroupPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A5C0 RID: 173504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C0")]
		[Address(RVA = "0x25FD250", Offset = "0x25FBE50", VA = "0x1825FD250", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A5C1 RID: 173505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C1")]
		[Address(RVA = "0x25FD740", Offset = "0x25FC340", VA = "0x1825FD740")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A5C2 RID: 173506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C2")]
		[Address(RVA = "0x25FCD70", Offset = "0x25FB970", VA = "0x1825FCD70")]
		public void OnClickEatBtn()
		{
		}

		// Token: 0x0602A5C3 RID: 173507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C3")]
		[Address(RVA = "0x25FCC30", Offset = "0x25FB830", VA = "0x1825FCC30")]
		public void OnClickBattleTrapBtn()
		{
		}

		// Token: 0x0602A5C4 RID: 173508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C4")]
		[Address(RVA = "0x25FCF20", Offset = "0x25FBB20", VA = "0x1825FCF20")]
		public void OnClickMissionBtn()
		{
		}

		// Token: 0x0602A5C5 RID: 173509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C5")]
		[Address(RVA = "0x25FCE60", Offset = "0x25FBA60", VA = "0x1825FCE60")]
		public void OnClickGachaBtn()
		{
		}

		// Token: 0x0602A5C6 RID: 173510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C6")]
		[Address(RVA = "0x25FD120", Offset = "0x25FBD20", VA = "0x1825FD120")]
		public void OnClickQuest(string zoneId)
		{
		}

		// Token: 0x0602A5C7 RID: 173511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C7")]
		[Address(RVA = "0x25FD020", Offset = "0x25FBC20", VA = "0x1825FD020")]
		public void OnClickNoteBtn()
		{
		}

		// Token: 0x0602A5C8 RID: 173512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5C8")]
		[Address(RVA = "0x25FD7F0", Offset = "0x25FC3F0", VA = "0x1825FD7F0")]
		public Act24sideButtonGroupPlugin()
		{
		}

		// Token: 0x0403CEEE RID: 249582
		[Token(Token = "0x403CEEE")]
		[FieldOffset(Offset = "0x28")]
		private string m_actId;

		// Token: 0x0403CEEF RID: 249583
		[Token(Token = "0x403CEEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x0403CEF0 RID: 249584
		[Token(Token = "0x403CEF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _battleTrapTrackPoint;

		// Token: 0x0403CEF1 RID: 249585
		[Token(Token = "0x403CEF1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEatBuff;

		// Token: 0x0403CEF2 RID: 249586
		[Token(Token = "0x403CEF2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelEatActive;

		// Token: 0x0403CEF3 RID: 249587
		[Token(Token = "0x403CEF3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _panelEatNorm;

		// Token: 0x0403CEF4 RID: 249588
		[Token(Token = "0x403CEF4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelEatTimeOut;

		// Token: 0x0403CEF5 RID: 249589
		[Token(Token = "0x403CEF5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _eatBtn;

		// Token: 0x0403CEF6 RID: 249590
		[Token(Token = "0x403CEF6")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _eatBuffIcon;

		// Token: 0x0403CEF7 RID: 249591
		[Token(Token = "0x403CEF7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _panelBattleTrap;

		// Token: 0x0403CEF8 RID: 249592
		[Token(Token = "0x403CEF8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelBattleTrapTimeOut;

		// Token: 0x0403CEF9 RID: 249593
		[Token(Token = "0x403CEF9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _battleTrapBtn;

		// Token: 0x0403CEFA RID: 249594
		[Token(Token = "0x403CEFA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _noteTrackPoint;

		// Token: 0x0403CEFB RID: 249595
		[Token(Token = "0x403CEFB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _alphaTimeOutBtn;

		// Token: 0x0403CEFC RID: 249596
		[Token(Token = "0x403CEFC")]
		[FieldOffset(Offset = "0x94")]
		private bool m_isInited;

		// Token: 0x0403CEFD RID: 249597
		[Token(Token = "0x403CEFD")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403CEFE RID: 249598
		[Token(Token = "0x403CEFE")]
		[FieldOffset(Offset = "0xA8")]
		private TrackPointViewProperty m_trackPointMission;

		// Token: 0x0403CEFF RID: 249599
		[Token(Token = "0x403CEFF")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_trackPointBattleTrap;

		// Token: 0x0403CF00 RID: 249600
		[Token(Token = "0x403CF00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403CF01 RID: 249601
		[Token(Token = "0x403CF01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CF02 RID: 249602
		[Token(Token = "0x403CF02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickEatBtn;

		// Token: 0x0403CF03 RID: 249603
		[Token(Token = "0x403CF03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickBattleTrapBtn;

		// Token: 0x0403CF04 RID: 249604
		[Token(Token = "0x403CF04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickMissionBtn;

		// Token: 0x0403CF05 RID: 249605
		[Token(Token = "0x403CF05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickGachaBtn;

		// Token: 0x0403CF06 RID: 249606
		[Token(Token = "0x403CF06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickQuest;

		// Token: 0x0403CF07 RID: 249607
		[Token(Token = "0x403CF07")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnClickNoteBtn;

		// Token: 0x0403CF08 RID: 249608
		[Token(Token = "0x403CF08")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
