using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D57 RID: 7511
	[Token(Token = "0x2001D57")]
	public class BuildingClueSendHomeState : State
	{
		// Token: 0x0600B95A RID: 47450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B95A")]
		[Address(RVA = "0x3351880", Offset = "0x3350480", VA = "0x183351880", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x00045990 File Offset: 0x00043B90
		[Token(Token = "0x17001690")]
		private int peerPageSize
		{
			[Token(Token = "0x600B95B")]
			[Address(RVA = "0x3353EF0", Offset = "0x3352AF0", VA = "0x183353EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95C")]
		[Address(RVA = "0x3352D10", Offset = "0x3351910", VA = "0x183352D10")]
		private void _InitPeerViewListIfNot()
		{
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95D")]
		[Address(RVA = "0x3351BC0", Offset = "0x33507C0", VA = "0x183351BC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95E")]
		[Address(RVA = "0x3353D40", Offset = "0x3352940", VA = "0x183353D40")]
		private void _SetupSendOptionView()
		{
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B95F")]
		[Address(RVA = "0x3353C50", Offset = "0x3352850", VA = "0x183353C50")]
		private void _SetupSendClueFilterView()
		{
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B960")]
		[Address(RVA = "0x33534C0", Offset = "0x33520C0", VA = "0x1833534C0")]
		private void _SetPeerPage(int page)
		{
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B961")]
		[Address(RVA = "0x33536E0", Offset = "0x33522E0", VA = "0x1833536E0")]
		private void _SetupPeerView()
		{
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x000459A8 File Offset: 0x00043BA8
		[Token(Token = "0x600B962")]
		[Address(RVA = "0x3352C00", Offset = "0x3351800", VA = "0x183352C00")]
		private bool _Filter(IPeer peer)
		{
			return default(bool);
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B963")]
		[Address(RVA = "0x3351F00", Offset = "0x3350B00", VA = "0x183351F00")]
		private void SetupView()
		{
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x000459C0 File Offset: 0x00043BC0
		[Token(Token = "0x600B964")]
		[Address(RVA = "0x3352450", Offset = "0x3351050", VA = "0x183352450")]
		private bool _CheckAbleToAutoSend()
		{
			return default(bool);
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B965")]
		[Address(RVA = "0x3353200", Offset = "0x3351E00", VA = "0x183353200")]
		private void _RefreshPeerPage()
		{
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B966")]
		[Address(RVA = "0x3352F20", Offset = "0x3351B20", VA = "0x183352F20")]
		private void _OnPeerSendPressed(IPeer peer)
		{
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B967")]
		[Address(RVA = "0x3353140", Offset = "0x3351D40", VA = "0x183353140")]
		private void _RefreshClueList(bool reset)
		{
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B968")]
		[Address(RVA = "0x33535E0", Offset = "0x33521E0", VA = "0x1833535E0")]
		private void _SetupAutoSendBtn()
		{
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x000459D8 File Offset: 0x00043BD8
		[Token(Token = "0x600B969")]
		[Address(RVA = "0x33525D0", Offset = "0x33511D0", VA = "0x1833525D0")]
		private bool _CheckHasClueToAutoSend(out ListSet<int> clueAbleToSend)
		{
			return default(bool);
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x000459F0 File Offset: 0x00043BF0
		[Token(Token = "0x600B96A")]
		[Address(RVA = "0x3352980", Offset = "0x3351580", VA = "0x183352980")]
		private bool _CheckHasPeerToAutoSendTo(ListSet<int> clueAbleToSend)
		{
			return default(bool);
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96B")]
		[Address(RVA = "0x3351E90", Offset = "0x3350A90", VA = "0x183351E90")]
		public void OnPrevPeerPageButtonPressed()
		{
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96C")]
		[Address(RVA = "0x3351E20", Offset = "0x3350A20", VA = "0x183351E20")]
		public void OnNextPeerPageButtonPressed()
		{
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96D")]
		[Address(RVA = "0x3351B40", Offset = "0x3350740", VA = "0x183351B40")]
		public void OnCloseButtonPressed()
		{
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96E")]
		[Address(RVA = "0x3351D60", Offset = "0x3350960", VA = "0x183351D60")]
		public void OnLackFilterClicked()
		{
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B96F")]
		[Address(RVA = "0x33518E0", Offset = "0x33504E0", VA = "0x1833518E0")]
		public void OnAutoSendClueClicked()
		{
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B970")]
		[Address(RVA = "0x3351A60", Offset = "0x3350660", VA = "0x183351A60")]
		public void OnAutoSendClueInactiveClicked()
		{
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B971")]
		[Address(RVA = "0x3353E80", Offset = "0x3352A80", VA = "0x183353E80")]
		public BuildingClueSendHomeState()
		{
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B975")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400B7CF RID: 47055
		[Token(Token = "0x400B7CF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIRenderTextureImage _blueBackground;

		// Token: 0x0400B7D0 RID: 47056
		[Token(Token = "0x400B7D0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MeetingClueSendOptionView _sendOptionView;

		// Token: 0x0400B7D1 RID: 47057
		[Token(Token = "0x400B7D1")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _prevPeerPageButton;

		// Token: 0x0400B7D2 RID: 47058
		[Token(Token = "0x400B7D2")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button _nextPeerPageButton;

		// Token: 0x0400B7D3 RID: 47059
		[Token(Token = "0x400B7D3")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _peerPageSize;

		// Token: 0x0400B7D4 RID: 47060
		[Token(Token = "0x400B7D4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeetingPeerSendClueView _peerViewPrefab;

		// Token: 0x0400B7D5 RID: 47061
		[Token(Token = "0x400B7D5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _peerViewContainer;

		// Token: 0x0400B7D6 RID: 47062
		[Token(Token = "0x400B7D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _noFriendHint;

		// Token: 0x0400B7D7 RID: 47063
		[Token(Token = "0x400B7D7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BuildingTwoContentNotify _notify;

		// Token: 0x0400B7D8 RID: 47064
		[Token(Token = "0x400B7D8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _avatarViewScale;

		// Token: 0x0400B7D9 RID: 47065
		[Token(Token = "0x400B7D9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MeetingSendClueFilterSwitchView _lackFilter;

		// Token: 0x0400B7DA RID: 47066
		[Token(Token = "0x400B7DA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _btnAutoSend;

		// Token: 0x0400B7DB RID: 47067
		[Token(Token = "0x400B7DB")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _btnAutoSendActive;

		// Token: 0x0400B7DC RID: 47068
		[Token(Token = "0x400B7DC")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _btnAutoSendInactive;

		// Token: 0x0400B7DD RID: 47069
		[Token(Token = "0x400B7DD")]
		[FieldOffset(Offset = "0xC0")]
		private IMeetingSession m_currentSession;

		// Token: 0x0400B7DE RID: 47070
		[Token(Token = "0x400B7DE")]
		[FieldOffset(Offset = "0xC8")]
		private IMeetingClue m_selectClue;

		// Token: 0x0400B7DF RID: 47071
		[Token(Token = "0x400B7DF")]
		[FieldOffset(Offset = "0xD0")]
		private int m_peerPage;

		// Token: 0x0400B7E0 RID: 47072
		[Token(Token = "0x400B7E0")]
		[FieldOffset(Offset = "0xD4")]
		private int m_pageCount;

		// Token: 0x0400B7E1 RID: 47073
		[Token(Token = "0x400B7E1")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_lackFilterIsOn;

		// Token: 0x0400B7E2 RID: 47074
		[Token(Token = "0x400B7E2")]
		[FieldOffset(Offset = "0xE0")]
		private List<MeetingPeerSendClueView> m_peerViewList;

		// Token: 0x0400B7E3 RID: 47075
		[Token(Token = "0x400B7E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400B7E4 RID: 47076
		[Token(Token = "0x400B7E4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_peerPageSize;

		// Token: 0x0400B7E5 RID: 47077
		[Token(Token = "0x400B7E5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitPeerViewListIfNot;

		// Token: 0x0400B7E6 RID: 47078
		[Token(Token = "0x400B7E6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400B7E7 RID: 47079
		[Token(Token = "0x400B7E7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetupSendOptionView;

		// Token: 0x0400B7E8 RID: 47080
		[Token(Token = "0x400B7E8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetupSendClueFilterView;

		// Token: 0x0400B7E9 RID: 47081
		[Token(Token = "0x400B7E9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetPeerPage;

		// Token: 0x0400B7EA RID: 47082
		[Token(Token = "0x400B7EA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupPeerView;

		// Token: 0x0400B7EB RID: 47083
		[Token(Token = "0x400B7EB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__Filter;

		// Token: 0x0400B7EC RID: 47084
		[Token(Token = "0x400B7EC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetupView;

		// Token: 0x0400B7ED RID: 47085
		[Token(Token = "0x400B7ED")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckAbleToAutoSend;

		// Token: 0x0400B7EE RID: 47086
		[Token(Token = "0x400B7EE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshPeerPage;

		// Token: 0x0400B7EF RID: 47087
		[Token(Token = "0x400B7EF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnPeerSendPressed;

		// Token: 0x0400B7F0 RID: 47088
		[Token(Token = "0x400B7F0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RefreshClueList;

		// Token: 0x0400B7F1 RID: 47089
		[Token(Token = "0x400B7F1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetupAutoSendBtn;

		// Token: 0x0400B7F2 RID: 47090
		[Token(Token = "0x400B7F2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckHasClueToAutoSend;

		// Token: 0x0400B7F3 RID: 47091
		[Token(Token = "0x400B7F3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CheckHasPeerToAutoSendTo;

		// Token: 0x0400B7F4 RID: 47092
		[Token(Token = "0x400B7F4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnPrevPeerPageButtonPressed;

		// Token: 0x0400B7F5 RID: 47093
		[Token(Token = "0x400B7F5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnNextPeerPageButtonPressed;

		// Token: 0x0400B7F6 RID: 47094
		[Token(Token = "0x400B7F6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnCloseButtonPressed;

		// Token: 0x0400B7F7 RID: 47095
		[Token(Token = "0x400B7F7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnLackFilterClicked;

		// Token: 0x0400B7F8 RID: 47096
		[Token(Token = "0x400B7F8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnAutoSendClueClicked;

		// Token: 0x0400B7F9 RID: 47097
		[Token(Token = "0x400B7F9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnAutoSendClueInactiveClicked;

		// Token: 0x0400B7FA RID: 47098
		[Token(Token = "0x400B7FA")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
