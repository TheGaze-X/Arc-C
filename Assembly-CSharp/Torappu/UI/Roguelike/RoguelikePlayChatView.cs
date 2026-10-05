using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Chat;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200519E RID: 20894
	[Token(Token = "0x200519E")]
	public class RoguelikePlayChatView : RoguelikeTransitionView.SubTransitionBase<RoguelikePlayChatView.Param>
	{
		// Token: 0x0601EDDD RID: 126429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDDD")]
		[Address(RVA = "0x18AACA0", Offset = "0x18A98A0", VA = "0x1818AACA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EDDE RID: 126430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDDE")]
		[Address(RVA = "0x18AADD0", Offset = "0x18A99D0", VA = "0x1818AADD0")]
		private RoguelikePlayChatView.Param _PrepareBeforeChatTrans(RoguelikeTransitionView.TransOptions options)
		{
			return null;
		}

		// Token: 0x0601EDDF RID: 126431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDDF")]
		[Address(RVA = "0x18AA840", Offset = "0x18A9440", VA = "0x1818AA840", Slot = "9")]
		protected override RoguelikePlayChatView.Param GetParam(RoguelikeTransitionView.TransOptions transOptions)
		{
			return null;
		}

		// Token: 0x0601EDE0 RID: 126432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE0")]
		[Address(RVA = "0x18AAA80", Offset = "0x18A9680", VA = "0x1818AAA80", Slot = "10")]
		protected override void SetParam(RoguelikePlayChatView.Param param)
		{
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x000AFFE0 File Offset: 0x000AE1E0
		[Token(Token = "0x601EDE1")]
		[Address(RVA = "0x18AA910", Offset = "0x18A9510", VA = "0x1818AA910", Slot = "11")]
		public override RoguelikeTransitionView.SubTransType GetTransType()
		{
			return RoguelikeTransitionView.SubTransType.NONE;
		}

		// Token: 0x0601EDE2 RID: 126434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE2")]
		[Address(RVA = "0x18AA970", Offset = "0x18A9570", VA = "0x1818AA970", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x0601EDE3 RID: 126435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDE3")]
		[Address(RVA = "0x18AAB00", Offset = "0x18A9700", VA = "0x1818AAB00", Slot = "12")]
		public override IEnumerator TransCoroutine()
		{
			return null;
		}

		// Token: 0x0601EDE4 RID: 126436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE4")]
		[Address(RVA = "0x18AA5D0", Offset = "0x18A91D0", VA = "0x1818AA5D0")]
		public void EventOnSkipClicked()
		{
		}

		// Token: 0x0601EDE5 RID: 126437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE5")]
		[Address(RVA = "0x18AA460", Offset = "0x18A9060", VA = "0x1818AA460")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x0601EDE6 RID: 126438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE6")]
		[Address(RVA = "0x18AA500", Offset = "0x18A9100", VA = "0x1818AA500")]
		public void EventOnExitRogueClicked()
		{
		}

		// Token: 0x0601EDE7 RID: 126439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE7")]
		[Address(RVA = "0x18AAD70", Offset = "0x18A9970", VA = "0x1818AAD70")]
		private void _NotifyWaitQuitTransition()
		{
		}

		// Token: 0x0601EDE8 RID: 126440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EDE8")]
		[Address(RVA = "0x18AB150", Offset = "0x18A9D50", VA = "0x1818AB150")]
		private IEnumerator _WaitForQuitTransition()
		{
			return null;
		}

		// Token: 0x0601EDE9 RID: 126441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDE9")]
		[Address(RVA = "0x18AABE0", Offset = "0x18A97E0", VA = "0x1818AABE0")]
		private void _ForceQuit()
		{
		}

		// Token: 0x0601EDEA RID: 126442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDEA")]
		[Address(RVA = "0x18AB060", Offset = "0x18A9C60", VA = "0x1818AB060")]
		private void _UpdateUI(RoguelikePlayChatView.PlayStatus status)
		{
		}

		// Token: 0x0601EDEB RID: 126443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDEB")]
		[Address(RVA = "0x18AB200", Offset = "0x18A9E00", VA = "0x1818AB200")]
		public RoguelikePlayChatView()
		{
		}

		// Token: 0x0402968B RID: 169611
		[Token(Token = "0x402968B")]
		private const float PLAY_DELAY = 0.3f;

		// Token: 0x0402968C RID: 169612
		[Token(Token = "0x402968C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeChatController _chatPrefab;

		// Token: 0x0402968D RID: 169613
		[Token(Token = "0x402968D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _chatContainer;

		// Token: 0x0402968E RID: 169614
		[Token(Token = "0x402968E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelPlaying;

		// Token: 0x0402968F RID: 169615
		[Token(Token = "0x402968F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPlayed;

		// Token: 0x04029690 RID: 169616
		[Token(Token = "0x4029690")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x04029691 RID: 169617
		[Token(Token = "0x4029691")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04029692 RID: 169618
		[Token(Token = "0x4029692")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikePlayChatView.Param m_param;

		// Token: 0x04029693 RID: 169619
		[Token(Token = "0x4029693")]
		[FieldOffset(Offset = "0x58")]
		private bool m_waitForQuitTransition;

		// Token: 0x04029694 RID: 169620
		[Token(Token = "0x4029694")]
		[FieldOffset(Offset = "0x59")]
		private bool m_forceQuit;

		// Token: 0x04029695 RID: 169621
		[Token(Token = "0x4029695")]
		[FieldOffset(Offset = "0x5A")]
		private bool m_isInited;

		// Token: 0x04029696 RID: 169622
		[Token(Token = "0x4029696")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeChatController m_chatInst;

		// Token: 0x04029697 RID: 169623
		[Token(Token = "0x4029697")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029698 RID: 169624
		[Token(Token = "0x4029698")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PrepareBeforeChatTrans;

		// Token: 0x04029699 RID: 169625
		[Token(Token = "0x4029699")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0402969A RID: 169626
		[Token(Token = "0x402969A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetParam;

		// Token: 0x0402969B RID: 169627
		[Token(Token = "0x402969B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetTransType;

		// Token: 0x0402969C RID: 169628
		[Token(Token = "0x402969C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0402969D RID: 169629
		[Token(Token = "0x402969D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TransCoroutine;

		// Token: 0x0402969E RID: 169630
		[Token(Token = "0x402969E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnSkipClicked;

		// Token: 0x0402969F RID: 169631
		[Token(Token = "0x402969F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x040296A0 RID: 169632
		[Token(Token = "0x40296A0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnExitRogueClicked;

		// Token: 0x040296A1 RID: 169633
		[Token(Token = "0x40296A1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__NotifyWaitQuitTransition;

		// Token: 0x040296A2 RID: 169634
		[Token(Token = "0x40296A2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WaitForQuitTransition;

		// Token: 0x040296A3 RID: 169635
		[Token(Token = "0x40296A3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ForceQuit;

		// Token: 0x040296A4 RID: 169636
		[Token(Token = "0x40296A4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateUI;

		// Token: 0x040296A5 RID: 169637
		[Token(Token = "0x40296A5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200519F RID: 20895
		[Token(Token = "0x200519F")]
		private enum PlayStatus
		{
			// Token: 0x040296A7 RID: 169639
			[Token(Token = "0x40296A7")]
			NONE,
			// Token: 0x040296A8 RID: 169640
			[Token(Token = "0x40296A8")]
			PLAYING,
			// Token: 0x040296A9 RID: 169641
			[Token(Token = "0x40296A9")]
			PLAYED
		}

		// Token: 0x020051A0 RID: 20896
		[Token(Token = "0x20051A0")]
		public class Param
		{
			// Token: 0x0601EDED RID: 126445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EDED")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040296AA RID: 169642
			[Token(Token = "0x40296AA")]
			[FieldOffset(Offset = "0x10")]
			public bool isLastChat;

			// Token: 0x040296AB RID: 169643
			[Token(Token = "0x40296AB")]
			[FieldOffset(Offset = "0x18")]
			public ActArchiveChatItemData chatData;
		}
	}
}
