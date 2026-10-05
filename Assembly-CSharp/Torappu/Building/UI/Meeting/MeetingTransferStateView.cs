using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D7B RID: 7547
	[Token(Token = "0x2001D7B")]
	public class MeetingTransferStateView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BA5E RID: 47710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5E")]
		[Address(RVA = "0x3381540", Offset = "0x3380140", VA = "0x183381540")]
		private void _OnTimerExpiredUpdate()
		{
		}

		// Token: 0x0600BA5F RID: 47711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5F")]
		[Address(RVA = "0x3380F10", Offset = "0x337FB10", VA = "0x183380F10")]
		public void Setup(IMeetingSession session)
		{
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA60")]
		[Address(RVA = "0x3380DA0", Offset = "0x337F9A0", VA = "0x183380DA0")]
		public void OnClick()
		{
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA61")]
		[Address(RVA = "0x3380E40", Offset = "0x337FA40", VA = "0x183380E40")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA62")]
		[Address(RVA = "0x3381410", Offset = "0x3380010", VA = "0x183381410")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA63")]
		[Address(RVA = "0x3381290", Offset = "0x337FE90", VA = "0x183381290")]
		private void Update()
		{
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA64")]
		[Address(RVA = "0x33815B0", Offset = "0x33801B0", VA = "0x1833815B0")]
		public MeetingTransferStateView()
		{
		}

		// Token: 0x0400B97E RID: 47486
		[Token(Token = "0x400B97E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _visitNumber;

		// Token: 0x0400B97F RID: 47487
		[Token(Token = "0x400B97F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _socialPointBonus;

		// Token: 0x0400B980 RID: 47488
		[Token(Token = "0x400B980")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeetingClueRestTimeLabel _restTimeLabel;

		// Token: 0x0400B981 RID: 47489
		[Token(Token = "0x400B981")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0400B982 RID: 47490
		[Token(Token = "0x400B982")]
		[FieldOffset(Offset = "0x40")]
		private IMeetingSession m_session;

		// Token: 0x0400B983 RID: 47491
		[Token(Token = "0x400B983")]
		[FieldOffset(Offset = "0x48")]
		private bool m_querying;

		// Token: 0x0400B984 RID: 47492
		[Token(Token = "0x400B984")]
		[FieldOffset(Offset = "0x49")]
		private bool m_transferComplete;

		// Token: 0x0400B985 RID: 47493
		[Token(Token = "0x400B985")]
		[FieldOffset(Offset = "0x50")]
		private AnimationSwitchTween m_tween;

		// Token: 0x0400B986 RID: 47494
		[Token(Token = "0x400B986")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0400B987 RID: 47495
		[Token(Token = "0x400B987")]
		[FieldOffset(Offset = "0x5C")]
		private float m_hideTimer;

		// Token: 0x0400B988 RID: 47496
		[Token(Token = "0x400B988")]
		[FieldOffset(Offset = "0x60")]
		private float m_hideDuration;

		// Token: 0x0400B989 RID: 47497
		[Token(Token = "0x400B989")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnTimerExpiredUpdate;

		// Token: 0x0400B98A RID: 47498
		[Token(Token = "0x400B98A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400B98B RID: 47499
		[Token(Token = "0x400B98B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0400B98C RID: 47500
		[Token(Token = "0x400B98C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400B98D RID: 47501
		[Token(Token = "0x400B98D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B98E RID: 47502
		[Token(Token = "0x400B98E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400B98F RID: 47503
		[Token(Token = "0x400B98F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
