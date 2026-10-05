using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F9D RID: 20381
	[Token(Token = "0x2004F9D")]
	public class EnemyDuelEntryView : DataBinder<EnemyDuelEntryProperty>, IHotfixable
	{
		// Token: 0x0601E4B9 RID: 124089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4B9")]
		[Address(RVA = "0x1804050", Offset = "0x1802C50", VA = "0x181804050")]
		private void _InitIfNecessary(EnemyDuelEntryViewModel viewModel)
		{
		}

		// Token: 0x0601E4BA RID: 124090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BA")]
		[Address(RVA = "0x1803AC0", Offset = "0x18026C0", VA = "0x181803AC0", Slot = "7")]
		public override void OnValueChanged(EnemyDuelEntryProperty property)
		{
		}

		// Token: 0x0601E4BB RID: 124091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BB")]
		[Address(RVA = "0x1803350", Offset = "0x1801F50", VA = "0x181803350")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601E4BC RID: 124092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BC")]
		[Address(RVA = "0x18033F0", Offset = "0x1801FF0", VA = "0x1818033F0")]
		public void OnHomeClick()
		{
		}

		// Token: 0x0601E4BD RID: 124093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BD")]
		[Address(RVA = "0x1803540", Offset = "0x1802140", VA = "0x181803540")]
		public void OnMainBtnClick()
		{
		}

		// Token: 0x0601E4BE RID: 124094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BE")]
		[Address(RVA = "0x18035F0", Offset = "0x18021F0", VA = "0x1818035F0")]
		public void OnMainCloseClick()
		{
		}

		// Token: 0x0601E4BF RID: 124095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4BF")]
		[Address(RVA = "0x1803800", Offset = "0x1802400", VA = "0x181803800")]
		public void OnMusicBtnClick()
		{
		}

		// Token: 0x0601E4C0 RID: 124096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C0")]
		[Address(RVA = "0x18038B0", Offset = "0x18024B0", VA = "0x1818038B0")]
		public void OnMusicCloseClick()
		{
		}

		// Token: 0x0601E4C1 RID: 124097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C1")]
		[Address(RVA = "0x1803490", Offset = "0x1802090", VA = "0x181803490")]
		public void OnJoinRoomClick()
		{
		}

		// Token: 0x0601E4C2 RID: 124098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C2")]
		[Address(RVA = "0x1803A10", Offset = "0x1802610", VA = "0x181803A10")]
		public void OnRoomClick()
		{
		}

		// Token: 0x0601E4C3 RID: 124099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C3")]
		[Address(RVA = "0x18036A0", Offset = "0x18022A0", VA = "0x1818036A0")]
		public void OnMatchClick()
		{
		}

		// Token: 0x0601E4C4 RID: 124100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C4")]
		[Address(RVA = "0x1803750", Offset = "0x1802350", VA = "0x181803750")]
		public void OnMedalClick()
		{
		}

		// Token: 0x0601E4C5 RID: 124101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C5")]
		[Address(RVA = "0x1803960", Offset = "0x1802560", VA = "0x181803960")]
		public void OnRewardClick()
		{
		}

		// Token: 0x0601E4C6 RID: 124102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E4C6")]
		[Address(RVA = "0x1804230", Offset = "0x1802E30", VA = "0x181804230")]
		public EnemyDuelEntryView()
		{
		}

		// Token: 0x04028709 RID: 165641
		[Token(Token = "0x4028709")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelEntryView.EntryWindow _mainWnd;

		// Token: 0x0402870A RID: 165642
		[Token(Token = "0x402870A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyDuelEntryView.EntryWindow _musicWnd;

		// Token: 0x0402870B RID: 165643
		[Token(Token = "0x402870B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _titleMainWnd;

		// Token: 0x0402870C RID: 165644
		[Token(Token = "0x402870C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _musicName;

		// Token: 0x0402870D RID: 165645
		[Token(Token = "0x402870D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EnemyDuelEntryActButtonView[] _actBtns;

		// Token: 0x0402870E RID: 165646
		[Token(Token = "0x402870E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private EnemyDuelEntryMatchButtonView _matchBtnView;

		// Token: 0x0402870F RID: 165647
		[Token(Token = "0x402870F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private EnemyDuelEntryAnnounceView _announceView;

		// Token: 0x04028710 RID: 165648
		[Token(Token = "0x4028710")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private EnemyDuelEntryDailyButtonView _dailyBtnView;

		// Token: 0x04028711 RID: 165649
		[Token(Token = "0x4028711")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private EnemyDuelEntryVideoHolder _videoHolder;

		// Token: 0x04028712 RID: 165650
		[Token(Token = "0x4028712")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _playerName;

		// Token: 0x04028713 RID: 165651
		[Token(Token = "0x4028713")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _playerAvatar;

		// Token: 0x04028714 RID: 165652
		[Token(Token = "0x4028714")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isBasicInited;

		// Token: 0x04028715 RID: 165653
		[Token(Token = "0x4028715")]
		[FieldOffset(Offset = "0x7C")]
		private int m_enterSeq;

		// Token: 0x04028716 RID: 165654
		[Token(Token = "0x4028716")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028717 RID: 165655
		[Token(Token = "0x4028717")]
		[FieldOffset(Offset = "0x90")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028718 RID: 165656
		[Token(Token = "0x4028718")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNecessary;

		// Token: 0x04028719 RID: 165657
		[Token(Token = "0x4028719")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402871A RID: 165658
		[Token(Token = "0x402871A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402871B RID: 165659
		[Token(Token = "0x402871B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnHomeClick;

		// Token: 0x0402871C RID: 165660
		[Token(Token = "0x402871C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMainBtnClick;

		// Token: 0x0402871D RID: 165661
		[Token(Token = "0x402871D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMainCloseClick;

		// Token: 0x0402871E RID: 165662
		[Token(Token = "0x402871E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMusicBtnClick;

		// Token: 0x0402871F RID: 165663
		[Token(Token = "0x402871F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnMusicCloseClick;

		// Token: 0x04028720 RID: 165664
		[Token(Token = "0x4028720")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnJoinRoomClick;

		// Token: 0x04028721 RID: 165665
		[Token(Token = "0x4028721")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRoomClick;

		// Token: 0x04028722 RID: 165666
		[Token(Token = "0x4028722")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMatchClick;

		// Token: 0x04028723 RID: 165667
		[Token(Token = "0x4028723")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnMedalClick;

		// Token: 0x04028724 RID: 165668
		[Token(Token = "0x4028724")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnRewardClick;

		// Token: 0x04028725 RID: 165669
		[Token(Token = "0x4028725")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F9E RID: 20382
		[Token(Token = "0x2004F9E")]
		[Serializable]
		public class EntryWindow : IHotfixable
		{
			// Token: 0x0601E4C7 RID: 124103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4C7")]
			[Address(RVA = "0x180A790", Offset = "0x1809390", VA = "0x18180A790")]
			private void _InitIfNot()
			{
			}

			// Token: 0x170046EB RID: 18155
			// (get) Token: 0x0601E4C8 RID: 124104 RVA: 0x000AE1B0 File Offset: 0x000AC3B0
			[Token(Token = "0x170046EB")]
			public bool isTweening
			{
				[Token(Token = "0x601E4C8")]
				[Address(RVA = "0x180AA60", Offset = "0x1809660", VA = "0x18180AA60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0601E4C9 RID: 124105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4C9")]
			[Address(RVA = "0x180A5F0", Offset = "0x18091F0", VA = "0x18180A5F0")]
			public void Set(bool isShow, bool isFastMode, string audioEvent)
			{
			}

			// Token: 0x0601E4CA RID: 124106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E4CA")]
			[Address(RVA = "0x180AA00", Offset = "0x1809600", VA = "0x18180AA00")]
			public EntryWindow()
			{
			}

			// Token: 0x04028726 RID: 165670
			[Token(Token = "0x4028726")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private UIAnimationLocation _wndShow;

			// Token: 0x04028727 RID: 165671
			[Token(Token = "0x4028727")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAnimationLocation _wndClose;

			// Token: 0x04028728 RID: 165672
			[Token(Token = "0x4028728")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private CanvasGroup _wndCg;

			// Token: 0x04028729 RID: 165673
			[Token(Token = "0x4028729")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private CanvasGroup _btnEnableCg;

			// Token: 0x0402872A RID: 165674
			[Token(Token = "0x402872A")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private CanvasGroup _btnDisableCg;

			// Token: 0x0402872B RID: 165675
			[Token(Token = "0x402872B")]
			[FieldOffset(Offset = "0x48")]
			private bool m_isInited;

			// Token: 0x0402872C RID: 165676
			[Token(Token = "0x402872C")]
			[FieldOffset(Offset = "0x50")]
			private FadeSwitchTween m_btnEnableFade;

			// Token: 0x0402872D RID: 165677
			[Token(Token = "0x402872D")]
			[FieldOffset(Offset = "0x58")]
			private FadeSwitchTween m_btnDisableFade;

			// Token: 0x0402872E RID: 165678
			[Token(Token = "0x402872E")]
			[FieldOffset(Offset = "0x60")]
			private UIBiAnimClipSwitchTween m_wndTween;

			// Token: 0x0402872F RID: 165679
			[Token(Token = "0x402872F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x04028730 RID: 165680
			[Token(Token = "0x4028730")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isTweening;

			// Token: 0x04028731 RID: 165681
			[Token(Token = "0x4028731")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Set;

			// Token: 0x04028732 RID: 165682
			[Token(Token = "0x4028732")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
