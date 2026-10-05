using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Friend;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D77 RID: 7543
	[Token(Token = "0x2001D77")]
	public class MeetingPeerSendClueView : UIStylerApplier<NameCardV2SkinStyle>, IHotfixable
	{
		// Token: 0x14000063 RID: 99
		// (add) Token: 0x0600BA4D RID: 47693 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600BA4E RID: 47694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000063")]
		public event Action<IPeer> onSendCluePressed
		{
			[Token(Token = "0x600BA4D")]
			[Address(RVA = "0x33801E0", Offset = "0x337EDE0", VA = "0x1833801E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600BA4E")]
			[Address(RVA = "0x33802E0", Offset = "0x337EEE0", VA = "0x1833802E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4F")]
		[Address(RVA = "0x337F880", Offset = "0x337E480", VA = "0x18337F880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA50")]
		[Address(RVA = "0x337ED30", Offset = "0x337D930", VA = "0x18337ED30")]
		public void Setup(MeetingPeerSendClueView.MeetingPeerConfig config)
		{
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA51")]
		[Address(RVA = "0x337FB70", Offset = "0x337E770", VA = "0x18337FB70")]
		private void _RenderNameCardSkin(PlayerNameCardSkin nameCardSkin)
		{
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA52")]
		[Address(RVA = "0x337FCE0", Offset = "0x337E8E0", VA = "0x18337FCE0")]
		private void _UpdateOwningPanel(int selectedClueCategory)
		{
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA53")]
		[Address(RVA = "0x337F950", Offset = "0x337E550", VA = "0x18337F950")]
		private void _RenderAvatarView(MeetingPeerSendClueView.MeetingPeerConfig config)
		{
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA54")]
		[Address(RVA = "0x337ECB0", Offset = "0x337D8B0", VA = "0x18337ECB0")]
		public void OnSendCluePressed()
		{
		}

		// Token: 0x0600BA55 RID: 47701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA55")]
		[Address(RVA = "0x337EBD0", Offset = "0x337D7D0", VA = "0x18337EBD0", Slot = "18")]
		protected override void OnApplyStyle(NameCardV2SkinStyle style)
		{
		}

		// Token: 0x0600BA56 RID: 47702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA56")]
		[Address(RVA = "0x3380170", Offset = "0x337ED70", VA = "0x183380170")]
		public MeetingPeerSendClueView()
		{
		}

		// Token: 0x0400B942 RID: 47426
		[Token(Token = "0x400B942")]
		private const string PLAYER_NUMBER_COLOR = "#FFFFFF";

		// Token: 0x0400B943 RID: 47427
		[Token(Token = "0x400B943")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Nullable")]
		[Obsolete("Legacy")]
		private Text _nickNameLabel;

		// Token: 0x0400B944 RID: 47428
		[Token(Token = "0x400B944")]
		[FieldOffset(Offset = "0x28")]
		[Obsolete("Legacy")]
		[SerializeField]
		[Tooltip("Nullable")]
		private Text _numberLabel;

		// Token: 0x0400B945 RID: 47429
		[Token(Token = "0x400B945")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nameWithNumberLabel;

		// Token: 0x0400B946 RID: 47430
		[Token(Token = "0x400B946")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x0400B947 RID: 47431
		[Token(Token = "0x400B947")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _commentLabel;

		// Token: 0x0400B948 RID: 47432
		[Token(Token = "0x400B948")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _lastLoginLabel;

		// Token: 0x0400B949 RID: 47433
		[Token(Token = "0x400B949")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _onlineLabel;

		// Token: 0x0400B94A RID: 47434
		[Token(Token = "0x400B94A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _onlinePanel;

		// Token: 0x0400B94B RID: 47435
		[Token(Token = "0x400B94B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _lastLoginPanel;

		// Token: 0x0400B94C RID: 47436
		[Token(Token = "0x400B94C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _socialCreditValueLabel;

		// Token: 0x0400B94D RID: 47437
		[Token(Token = "0x400B94D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0400B94E RID: 47438
		[Token(Token = "0x400B94E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private MeetingPeerClueOwnView[] _owningPanels;

		// Token: 0x0400B94F RID: 47439
		[Token(Token = "0x400B94F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0400B950 RID: 47440
		[Token(Token = "0x400B950")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _starFriendIconGO;

		// Token: 0x0400B951 RID: 47441
		[Token(Token = "0x400B951")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textReceivedTips;

		// Token: 0x0400B952 RID: 47442
		[Token(Token = "0x400B952")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TwoStateToggle _nameCardBgToggle;

		// Token: 0x0400B953 RID: 47443
		[Token(Token = "0x400B953")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _imageBG;

		// Token: 0x0400B954 RID: 47444
		[Token(Token = "0x400B954")]
		[FieldOffset(Offset = "0xA8")]
		private IPeer m_peer;

		// Token: 0x0400B955 RID: 47445
		[Token(Token = "0x400B955")]
		[FieldOffset(Offset = "0xB0")]
		private IMeetingSession m_session;

		// Token: 0x0400B956 RID: 47446
		[Token(Token = "0x400B956")]
		[FieldOffset(Offset = "0xB8")]
		private Sprite m_originIcon;

		// Token: 0x0400B957 RID: 47447
		[Token(Token = "0x400B957")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0400B959 RID: 47449
		[Token(Token = "0x400B959")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_isInited;

		// Token: 0x0400B95A RID: 47450
		[Token(Token = "0x400B95A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_add_onSendCluePressed;

		// Token: 0x0400B95B RID: 47451
		[Token(Token = "0x400B95B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_remove_onSendCluePressed;

		// Token: 0x0400B95C RID: 47452
		[Token(Token = "0x400B95C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B95D RID: 47453
		[Token(Token = "0x400B95D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B95E RID: 47454
		[Token(Token = "0x400B95E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderNameCardSkin;

		// Token: 0x0400B95F RID: 47455
		[Token(Token = "0x400B95F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateOwningPanel;

		// Token: 0x0400B960 RID: 47456
		[Token(Token = "0x400B960")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderAvatarView;

		// Token: 0x0400B961 RID: 47457
		[Token(Token = "0x400B961")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnSendCluePressed;

		// Token: 0x0400B962 RID: 47458
		[Token(Token = "0x400B962")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnApplyStyle;

		// Token: 0x0400B963 RID: 47459
		[Token(Token = "0x400B963")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D78 RID: 7544
		[Token(Token = "0x2001D78")]
		public class MeetingPeerConfig
		{
			// Token: 0x0600BA57 RID: 47703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BA57")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MeetingPeerConfig()
			{
			}

			// Token: 0x0400B964 RID: 47460
			[Token(Token = "0x400B964")]
			[FieldOffset(Offset = "0x10")]
			public IPeer peer;

			// Token: 0x0400B965 RID: 47461
			[Token(Token = "0x400B965")]
			[FieldOffset(Offset = "0x18")]
			public bool isStar;

			// Token: 0x0400B966 RID: 47462
			[Token(Token = "0x400B966")]
			[FieldOffset(Offset = "0x20")]
			public IMeetingSession session;

			// Token: 0x0400B967 RID: 47463
			[Token(Token = "0x400B967")]
			[FieldOffset(Offset = "0x28")]
			public int selectedClueCategory;

			// Token: 0x0400B968 RID: 47464
			[Token(Token = "0x400B968")]
			[FieldOffset(Offset = "0x2C")]
			public float avatarScale;
		}
	}
}
