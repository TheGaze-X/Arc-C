using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D79 RID: 7545
	[Token(Token = "0x2001D79")]
	public class MeetingPeerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BA58 RID: 47704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA58")]
		[Address(RVA = "0x33809C0", Offset = "0x337F5C0", VA = "0x1833809C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BA59 RID: 47705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA59")]
		[Address(RVA = "0x33803E0", Offset = "0x337EFE0", VA = "0x1833803E0")]
		public void Setup(MeetingPeerSendClueView.MeetingPeerConfig config)
		{
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5A")]
		[Address(RVA = "0x3380A20", Offset = "0x337F620", VA = "0x183380A20")]
		private void _RenderAvatarView(MeetingPeerSendClueView.MeetingPeerConfig config)
		{
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5B")]
		[Address(RVA = "0x3380C30", Offset = "0x337F830", VA = "0x183380C30")]
		public MeetingPeerView()
		{
		}

		// Token: 0x0400B969 RID: 47465
		[Token(Token = "0x400B969")]
		private const string PLAYER_NUMBER_COLOR = "#898989";

		// Token: 0x0400B96A RID: 47466
		[Token(Token = "0x400B96A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _nameWithNumberLabel;

		// Token: 0x0400B96B RID: 47467
		[Token(Token = "0x400B96B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x0400B96C RID: 47468
		[Token(Token = "0x400B96C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _commentLabel;

		// Token: 0x0400B96D RID: 47469
		[Token(Token = "0x400B96D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _lastLoginLabel;

		// Token: 0x0400B96E RID: 47470
		[Token(Token = "0x400B96E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _onlineLabel;

		// Token: 0x0400B96F RID: 47471
		[Token(Token = "0x400B96F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _onlinePanel;

		// Token: 0x0400B970 RID: 47472
		[Token(Token = "0x400B970")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lastLoginPanel;

		// Token: 0x0400B971 RID: 47473
		[Token(Token = "0x400B971")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _avatarContainer;

		// Token: 0x0400B972 RID: 47474
		[Token(Token = "0x400B972")]
		[FieldOffset(Offset = "0x58")]
		private IPeer m_peer;

		// Token: 0x0400B973 RID: 47475
		[Token(Token = "0x400B973")]
		[FieldOffset(Offset = "0x60")]
		private IMeetingSession m_session;

		// Token: 0x0400B974 RID: 47476
		[Token(Token = "0x400B974")]
		[FieldOffset(Offset = "0x68")]
		private Sprite m_originIcon;

		// Token: 0x0400B975 RID: 47477
		[Token(Token = "0x400B975")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0400B976 RID: 47478
		[Token(Token = "0x400B976")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B977 RID: 47479
		[Token(Token = "0x400B977")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B978 RID: 47480
		[Token(Token = "0x400B978")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderAvatarView;

		// Token: 0x0400B979 RID: 47481
		[Token(Token = "0x400B979")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
