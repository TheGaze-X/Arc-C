using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x02004465 RID: 17509
	[Token(Token = "0x2004465")]
	public class RoguelikeEntryState : State, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601AC4C RID: 109644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601AC4C")]
		[Address(RVA = "0x13D85F0", Offset = "0x13D71F0", VA = "0x1813D85F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601AC4D RID: 109645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC4D")]
		[Address(RVA = "0x13D8650", Offset = "0x13D7250", VA = "0x1813D8650", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601AC4E RID: 109646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC4E")]
		[Address(RVA = "0x13D8920", Offset = "0x13D7520", VA = "0x1813D8920", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601AC4F RID: 109647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC4F")]
		[Address(RVA = "0x13D87D0", Offset = "0x13D73D0", VA = "0x1813D87D0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601AC50 RID: 109648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC50")]
		[Address(RVA = "0x13D9530", Offset = "0x13D8130", VA = "0x1813D9530")]
		private void _OnItemClicked(string topicId)
		{
		}

		// Token: 0x0601AC51 RID: 109649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC51")]
		[Address(RVA = "0x13D9320", Offset = "0x13D7F20", VA = "0x1813D9320")]
		private void _OnEntryClicked(string topicId)
		{
		}

		// Token: 0x0601AC52 RID: 109650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC52")]
		[Address(RVA = "0x13D9690", Offset = "0x13D8290", VA = "0x1813D9690")]
		private void _OnPinBtnClicked()
		{
		}

		// Token: 0x0601AC53 RID: 109651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC53")]
		[Address(RVA = "0x13D8F80", Offset = "0x13D7B80", VA = "0x1813D8F80")]
		private void _OnArchiveBtnClicked()
		{
		}

		// Token: 0x0601AC54 RID: 109652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC54")]
		[Address(RVA = "0x13D8D10", Offset = "0x13D7910", VA = "0x1813D8D10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AC55 RID: 109653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC55")]
		[Address(RVA = "0x13D9220", Offset = "0x13D7E20", VA = "0x1813D9220")]
		private void _OnBackClicked()
		{
		}

		// Token: 0x0601AC56 RID: 109654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC56")]
		[Address(RVA = "0x13D8A70", Offset = "0x13D7670", VA = "0x1813D8A70")]
		private void _HandleTopicPinnedRequest(string topicId, Action onComplete)
		{
		}

		// Token: 0x0601AC57 RID: 109655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC57")]
		[Address(RVA = "0x13D9CD0", Offset = "0x13D88D0", VA = "0x1813D9CD0")]
		private void _ShowPinToast(string topicId, bool isPinned)
		{
		}

		// Token: 0x0601AC58 RID: 109656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC58")]
		[Address(RVA = "0x13D9AE0", Offset = "0x13D86E0", VA = "0x1813D9AE0")]
		private void _ShowJudgeDialog(string prevTopic, string nextTopic, Action onPositive)
		{
		}

		// Token: 0x0601AC59 RID: 109657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC59")]
		[Address(RVA = "0x13D9DD0", Offset = "0x13D89D0", VA = "0x1813D9DD0")]
		public RoguelikeEntryState()
		{
		}

		// Token: 0x0601AC5A RID: 109658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC5A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601AC5B RID: 109659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC5B")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04022372 RID: 140146
		[Token(Token = "0x4022372")]
		[NonSerialized]
		public const int ON_ITEM_CLICKED = 0;

		// Token: 0x04022373 RID: 140147
		[Token(Token = "0x4022373")]
		[NonSerialized]
		public const int ON_ENTRY_CLICKED = 1;

		// Token: 0x04022374 RID: 140148
		[Token(Token = "0x4022374")]
		[NonSerialized]
		public const int ON_PIN_BTN_CLICKED = 2;

		// Token: 0x04022375 RID: 140149
		[Token(Token = "0x4022375")]
		[NonSerialized]
		public const int ON_ARCHIVE_BTN_CLICKED = 3;

		// Token: 0x04022376 RID: 140150
		[Token(Token = "0x4022376")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeEntryBottomView _bottomView;

		// Token: 0x04022377 RID: 140151
		[Token(Token = "0x4022377")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeEntryMainView _mainView;

		// Token: 0x04022378 RID: 140152
		[Token(Token = "0x4022378")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _panelBack;

		// Token: 0x04022379 RID: 140153
		[Token(Token = "0x4022379")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeEntryStateBean m_stateBean;

		// Token: 0x0402237A RID: 140154
		[Token(Token = "0x402237A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0402237B RID: 140155
		[Token(Token = "0x402237B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402237C RID: 140156
		[Token(Token = "0x402237C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402237D RID: 140157
		[Token(Token = "0x402237D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402237E RID: 140158
		[Token(Token = "0x402237E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402237F RID: 140159
		[Token(Token = "0x402237F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04022380 RID: 140160
		[Token(Token = "0x4022380")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnEntryClicked;

		// Token: 0x04022381 RID: 140161
		[Token(Token = "0x4022381")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPinBtnClicked;

		// Token: 0x04022382 RID: 140162
		[Token(Token = "0x4022382")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnArchiveBtnClicked;

		// Token: 0x04022383 RID: 140163
		[Token(Token = "0x4022383")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022384 RID: 140164
		[Token(Token = "0x4022384")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBackClicked;

		// Token: 0x04022385 RID: 140165
		[Token(Token = "0x4022385")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleTopicPinnedRequest;

		// Token: 0x04022386 RID: 140166
		[Token(Token = "0x4022386")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowPinToast;

		// Token: 0x04022387 RID: 140167
		[Token(Token = "0x4022387")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowJudgeDialog;

		// Token: 0x04022388 RID: 140168
		[Token(Token = "0x4022388")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
