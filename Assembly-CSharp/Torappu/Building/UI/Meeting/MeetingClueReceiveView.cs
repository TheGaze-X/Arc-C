using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D6B RID: 7531
	[Token(Token = "0x2001D6B")]
	public class MeetingClueReceiveView : MonoBehaviour
	{
		// Token: 0x17001697 RID: 5783
		// (set) Token: 0x0600BA09 RID: 47625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001697")]
		private bool receiveAllAvailable
		{
			[Token(Token = "0x600BA09")]
			[Address(RVA = "0x337B510", Offset = "0x337A110", VA = "0x18337B510")]
			set
			{
			}
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0A")]
		[Address(RVA = "0x337B100", Offset = "0x3379D00", VA = "0x18337B100")]
		public void Setup(IMeetingSession session, [Optional] Action<IMeetingClue, MeetingClueItemView> clickCallback, [Optional] Action receiveAllCallback)
		{
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0B")]
		[Address(RVA = "0x337B0F0", Offset = "0x3379CF0", VA = "0x18337B0F0")]
		public void RefreshClueList()
		{
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0C")]
		[Address(RVA = "0x337B250", Offset = "0x3379E50", VA = "0x18337B250")]
		private void _SetupClueList()
		{
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0D")]
		[Address(RVA = "0x337B230", Offset = "0x3379E30", VA = "0x18337B230")]
		private void _OnCluePressed(IMeetingClue clue, MeetingClueItemView view)
		{
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0E")]
		[Address(RVA = "0x337B0C0", Offset = "0x3379CC0", VA = "0x18337B0C0")]
		public void OnReceiveAllPressed()
		{
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0F")]
		[Address(RVA = "0x1A14800", Offset = "0x1A13400", VA = "0x181A14800")]
		public void OnInfoButtonPressed()
		{
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA10")]
		[Address(RVA = "0x337B0E0", Offset = "0x3379CE0", VA = "0x18337B0E0")]
		public void OnRuleHintPressed()
		{
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA11")]
		[Address(RVA = "0x337B470", Offset = "0x337A070", VA = "0x18337B470")]
		public MeetingClueReceiveView()
		{
		}

		// Token: 0x0400B8E8 RID: 47336
		[Token(Token = "0x400B8E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeetingClueAdapter _clueAdapter;

		// Token: 0x0400B8E9 RID: 47337
		[Token(Token = "0x400B8E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _receiveAllButton;

		// Token: 0x0400B8EA RID: 47338
		[Token(Token = "0x400B8EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _receiveAllButtonCanvasGroup;

		// Token: 0x0400B8EB RID: 47339
		[Token(Token = "0x400B8EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _receiveBonusHint;

		// Token: 0x0400B8EC RID: 47340
		[Token(Token = "0x400B8EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _receiveNoBonusHint;

		// Token: 0x0400B8ED RID: 47341
		[Token(Token = "0x400B8ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _ruleHint;

		// Token: 0x0400B8EE RID: 47342
		[Token(Token = "0x400B8EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _emptyHint;

		// Token: 0x0400B8EF RID: 47343
		[Token(Token = "0x400B8EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IMeetingSession m_session;

		// Token: 0x0400B8F0 RID: 47344
		[Token(Token = "0x400B8F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action<IMeetingClue, MeetingClueItemView> m_clickCallback;

		// Token: 0x0400B8F1 RID: 47345
		[Token(Token = "0x400B8F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action m_receiveAllCallback;

		// Token: 0x0400B8F2 RID: 47346
		[Token(Token = "0x400B8F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform m_rect;

		// Token: 0x0400B8F3 RID: 47347
		[Token(Token = "0x400B8F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector2 m_tweenBase;

		// Token: 0x0400B8F4 RID: 47348
		[Token(Token = "0x400B8F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_tweenTarget;
	}
}
