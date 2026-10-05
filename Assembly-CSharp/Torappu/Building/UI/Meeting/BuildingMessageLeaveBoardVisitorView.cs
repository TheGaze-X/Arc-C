using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D29 RID: 7465
	[Token(Token = "0x2001D29")]
	public class BuildingMessageLeaveBoardVisitorView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B84A RID: 47178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84A")]
		[Address(RVA = "0x335FFD0", Offset = "0x335EBD0", VA = "0x18335FFD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B84B RID: 47179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84B")]
		[Address(RVA = "0x335FDD0", Offset = "0x335E9D0", VA = "0x18335FDD0")]
		public void Render(BuildingMessageLeaveBoardModel model)
		{
		}

		// Token: 0x0600B84C RID: 47180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84C")]
		[Address(RVA = "0x3360260", Offset = "0x335EE60", VA = "0x183360260")]
		private void _RendVisitorViewForPlayer(BuildingPayloadGetMessageBoardContentResponse response)
		{
		}

		// Token: 0x0600B84D RID: 47181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84D")]
		[Address(RVA = "0x33601D0", Offset = "0x335EDD0", VA = "0x1833601D0")]
		private void _PlayNewVisitorAudio()
		{
		}

		// Token: 0x0600B84E RID: 47182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84E")]
		[Address(RVA = "0x3360140", Offset = "0x335ED40", VA = "0x183360140")]
		private void _PlayEmojiAudio()
		{
		}

		// Token: 0x0600B84F RID: 47183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B84F")]
		[Address(RVA = "0x3360610", Offset = "0x335F210", VA = "0x183360610")]
		private void _RendVisitorViewForVisitor(BuildingPayloadGetOthersMessageBoardContentResponse response)
		{
		}

		// Token: 0x0600B850 RID: 47184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B850")]
		[Address(RVA = "0x3360A80", Offset = "0x335F680", VA = "0x183360A80")]
		public BuildingMessageLeaveBoardVisitorView()
		{
		}

		// Token: 0x0400B677 RID: 46711
		[Token(Token = "0x400B677")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingMessageLeaveBoardVisitorItemHolderView[] _thisWeekVisitorHolders;

		// Token: 0x0400B678 RID: 46712
		[Token(Token = "0x400B678")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingMessageLeaveBoardVisitorItemHolderView[] _lastWeekVisitorHolders;

		// Token: 0x0400B679 RID: 46713
		[Token(Token = "0x400B679")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelNoVisitor;

		// Token: 0x0400B67A RID: 46714
		[Token(Token = "0x400B67A")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<IMessageBoardVisitorData> onClickAvatar;

		// Token: 0x0400B67B RID: 46715
		[Token(Token = "0x400B67B")]
		[FieldOffset(Offset = "0x38")]
		private TickFunctionTimer m_emojiAudioTimer;

		// Token: 0x0400B67C RID: 46716
		[Token(Token = "0x400B67C")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0400B67D RID: 46717
		[Token(Token = "0x400B67D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B67E RID: 46718
		[Token(Token = "0x400B67E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B67F RID: 46719
		[Token(Token = "0x400B67F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RendVisitorViewForPlayer;

		// Token: 0x0400B680 RID: 46720
		[Token(Token = "0x400B680")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayNewVisitorAudio;

		// Token: 0x0400B681 RID: 46721
		[Token(Token = "0x400B681")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEmojiAudio;

		// Token: 0x0400B682 RID: 46722
		[Token(Token = "0x400B682")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RendVisitorViewForVisitor;

		// Token: 0x0400B683 RID: 46723
		[Token(Token = "0x400B683")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
