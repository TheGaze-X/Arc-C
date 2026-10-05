using System;
using System.Collections;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D20 RID: 7456
	[Token(Token = "0x2001D20")]
	public class BuildingMessageLeaveBoardVisitorInfoDialog : UICompDialog<BuildingMessageLeaveBoardVisitorInfoDialog.Input>, IHotfixable
	{
		// Token: 0x0600B813 RID: 47123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B813")]
		[Address(RVA = "0x333D870", Offset = "0x333C470", VA = "0x18333D870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B814")]
		[Address(RVA = "0x333D400", Offset = "0x333C000", VA = "0x18333D400", Slot = "18")]
		protected override void OnRender(BuildingMessageLeaveBoardVisitorInfoDialog.Input input)
		{
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B815")]
		[Address(RVA = "0x333DAD0", Offset = "0x333C6D0", VA = "0x18333DAD0")]
		private IEnumerator _PlayFadeInOut(bool isIn, [Optional] Action callback)
		{
			return null;
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B816")]
		[Address(RVA = "0x333D800", Offset = "0x333C400", VA = "0x18333D800")]
		private void _HideView()
		{
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B817")]
		[Address(RVA = "0x333CE40", Offset = "0x333BA40", VA = "0x18333CE40")]
		public void EventOnClickBG()
		{
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B818")]
		[Address(RVA = "0x333CF10", Offset = "0x333BB10", VA = "0x18333CF10")]
		public void EventOnClickDetailInfo()
		{
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B819")]
		[Address(RVA = "0x333D9A0", Offset = "0x333C5A0", VA = "0x18333D9A0")]
		private void _OpenFriendNameCard(GetOtherPlayerNameCardResponse response)
		{
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B81A")]
		[Address(RVA = "0x333D1D0", Offset = "0x333BDD0", VA = "0x18333D1D0")]
		public void EventOnClickVisitMessageBoard()
		{
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B81B")]
		[Address(RVA = "0x333DBC0", Offset = "0x333C7C0", VA = "0x18333DBC0")]
		private void _RenderTimeShow(BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor visitorData)
		{
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B81C")]
		[Address(RVA = "0x333DE40", Offset = "0x333CA40", VA = "0x18333DE40")]
		public BuildingMessageLeaveBoardVisitorInfoDialog()
		{
		}

		// Token: 0x0400B603 RID: 46595
		[Token(Token = "0x400B603")]
		private const string NAMECARD_REQUEST_SRC = "MESSAGE_BOARD";

		// Token: 0x0400B604 RID: 46596
		[Token(Token = "0x400B604")]
		private const float FADE_DURATION = 0.25f;

		// Token: 0x0400B605 RID: 46597
		[Token(Token = "0x400B605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400B606 RID: 46598
		[Token(Token = "0x400B606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BuildingNameCardView _nameCardItemView;

		// Token: 0x0400B607 RID: 46599
		[Token(Token = "0x400B607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelTimeToday;

		// Token: 0x0400B608 RID: 46600
		[Token(Token = "0x400B608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelTimeYesterday;

		// Token: 0x0400B609 RID: 46601
		[Token(Token = "0x400B609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelTimePref;

		// Token: 0x0400B60A RID: 46602
		[Token(Token = "0x400B60A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textDate;

		// Token: 0x0400B60B RID: 46603
		[Token(Token = "0x400B60B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _panelInfoShare;

		// Token: 0x0400B60C RID: 46604
		[Token(Token = "0x400B60C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _shareProgress;

		// Token: 0x0400B60D RID: 46605
		[Token(Token = "0x400B60D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelRecentVisit;

		// Token: 0x0400B60E RID: 46606
		[Token(Token = "0x400B60E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _visitCount;

		// Token: 0x0400B60F RID: 46607
		[Token(Token = "0x400B60F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor m_visitorData;

		// Token: 0x0400B610 RID: 46608
		[Token(Token = "0x400B610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private string m_cachedUid;

		// Token: 0x0400B611 RID: 46609
		[Token(Token = "0x400B611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GetOtherPlayerNameCardResponse m_cachedResponse;

		// Token: 0x0400B612 RID: 46610
		[Token(Token = "0x400B612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_enalbeClick;

		// Token: 0x0400B613 RID: 46611
		[Token(Token = "0x400B613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Tween m_fadeTween;

		// Token: 0x0400B614 RID: 46612
		[Token(Token = "0x400B614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool m_isInited;

		// Token: 0x0400B615 RID: 46613
		[Token(Token = "0x400B615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B616 RID: 46614
		[Token(Token = "0x400B616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0400B617 RID: 46615
		[Token(Token = "0x400B617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayFadeInOut;

		// Token: 0x0400B618 RID: 46616
		[Token(Token = "0x400B618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HideView;

		// Token: 0x0400B619 RID: 46617
		[Token(Token = "0x400B619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClickBG;

		// Token: 0x0400B61A RID: 46618
		[Token(Token = "0x400B61A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickDetailInfo;

		// Token: 0x0400B61B RID: 46619
		[Token(Token = "0x400B61B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OpenFriendNameCard;

		// Token: 0x0400B61C RID: 46620
		[Token(Token = "0x400B61C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClickVisitMessageBoard;

		// Token: 0x0400B61D RID: 46621
		[Token(Token = "0x400B61D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderTimeShow;

		// Token: 0x0400B61E RID: 46622
		[Token(Token = "0x400B61E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001D21 RID: 7457
		[Token(Token = "0x2001D21")]
		public class Input
		{
			// Token: 0x0600B81F RID: 47135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B81F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0400B61F RID: 46623
			[Token(Token = "0x400B61F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BuildingPayloadGetMessageBoardContentResponse.PayloadMessageBoardThisWeekVisitor visitorData;
		}
	}
}
