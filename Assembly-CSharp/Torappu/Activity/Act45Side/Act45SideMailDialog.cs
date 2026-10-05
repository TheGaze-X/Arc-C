using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072DB RID: 29403
	[Token(Token = "0x20072DB")]
	public class Act45SideMailDialog : UICompDialog<Act45SideMailDialog.Input>
	{
		// Token: 0x060299C3 RID: 170435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C3")]
		[Address(RVA = "0x24F98F0", Offset = "0x24F84F0", VA = "0x1824F98F0", Slot = "18")]
		protected override void OnRender(Act45SideMailDialog.Input input)
		{
		}

		// Token: 0x060299C4 RID: 170436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C4")]
		[Address(RVA = "0x24F9750", Offset = "0x24F8350", VA = "0x1824F9750")]
		public void EventOnReceiveRewardClicked()
		{
		}

		// Token: 0x060299C5 RID: 170437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C5")]
		[Address(RVA = "0x24F9620", Offset = "0x24F8220", VA = "0x1824F9620")]
		public void EventOnLeftClicked()
		{
		}

		// Token: 0x060299C6 RID: 170438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C6")]
		[Address(RVA = "0x24F97B0", Offset = "0x24F83B0", VA = "0x1824F97B0")]
		public void EventOnRightClicked()
		{
		}

		// Token: 0x060299C7 RID: 170439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C7")]
		[Address(RVA = "0x24F9550", Offset = "0x24F8150", VA = "0x1824F9550")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x060299C8 RID: 170440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C8")]
		[Address(RVA = "0x24FA1C0", Offset = "0x24F8DC0", VA = "0x1824FA1C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060299C9 RID: 170441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299C9")]
		[Address(RVA = "0x24F9DC0", Offset = "0x24F89C0", VA = "0x1824F9DC0")]
		private void _ConfirmMails()
		{
		}

		// Token: 0x060299CA RID: 170442 RVA: 0x000D6080 File Offset: 0x000D4280
		[Token(Token = "0x60299CA")]
		[Address(RVA = "0x24FA040", Offset = "0x24F8C40", VA = "0x1824FA040")]
		private bool _EnsureHasNewMail()
		{
			return default(bool);
		}

		// Token: 0x060299CB RID: 170443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60299CB")]
		[Address(RVA = "0x24FA2C0", Offset = "0x24F8EC0", VA = "0x1824FA2C0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x060299CC RID: 170444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299CC")]
		[Address(RVA = "0x24FA3A0", Offset = "0x24F8FA0", VA = "0x1824FA3A0")]
		public Act45SideMailDialog()
		{
		}

		// Token: 0x0403B834 RID: 243764
		[Token(Token = "0x403B834")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act45SideMailView _view;

		// Token: 0x0403B835 RID: 243765
		[Token(Token = "0x403B835")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403B836 RID: 243766
		[Token(Token = "0x403B836")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedActId;

		// Token: 0x0403B837 RID: 243767
		[Token(Token = "0x403B837")]
		[FieldOffset(Offset = "0x88")]
		private Act45SideMailProperty m_prop;

		// Token: 0x0403B838 RID: 243768
		[Token(Token = "0x403B838")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403B839 RID: 243769
		[Token(Token = "0x403B839")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnReceiveRewardClicked;

		// Token: 0x0403B83A RID: 243770
		[Token(Token = "0x403B83A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnLeftClicked;

		// Token: 0x0403B83B RID: 243771
		[Token(Token = "0x403B83B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnRightClicked;

		// Token: 0x0403B83C RID: 243772
		[Token(Token = "0x403B83C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0403B83D RID: 243773
		[Token(Token = "0x403B83D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B83E RID: 243774
		[Token(Token = "0x403B83E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ConfirmMails;

		// Token: 0x0403B83F RID: 243775
		[Token(Token = "0x403B83F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EnsureHasNewMail;

		// Token: 0x0403B840 RID: 243776
		[Token(Token = "0x403B840")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403B841 RID: 243777
		[Token(Token = "0x403B841")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072DC RID: 29404
		[Token(Token = "0x20072DC")]
		public enum EntryType
		{
			// Token: 0x0403B843 RID: 243779
			[Token(Token = "0x403B843")]
			NEW,
			// Token: 0x0403B844 RID: 243780
			[Token(Token = "0x403B844")]
			REVIEW
		}

		// Token: 0x020072DD RID: 29405
		[Token(Token = "0x20072DD")]
		public class Input
		{
			// Token: 0x060299D1 RID: 170449 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60299D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403B845 RID: 243781
			[Token(Token = "0x403B845")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403B846 RID: 243782
			[Token(Token = "0x403B846")]
			[FieldOffset(Offset = "0x18")]
			public Act45SideMailDialog.EntryType entryType;
		}
	}
}
