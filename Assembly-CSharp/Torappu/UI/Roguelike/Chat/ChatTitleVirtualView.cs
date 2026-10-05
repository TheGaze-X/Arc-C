using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058B7 RID: 22711
	[Token(Token = "0x20058B7")]
	public class ChatTitleVirtualView : ChatSimpleViewBase
	{
		// Token: 0x06021261 RID: 135777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021261")]
		[Address(RVA = "0x1B70C50", Offset = "0x1B6F850", VA = "0x181B70C50")]
		public ChatTitleVirtualView(RoguelikeChatSimpleComp prefab)
		{
		}

		// Token: 0x06021262 RID: 135778 RVA: 0x000B8BD8 File Offset: 0x000B6DD8
		[Token(Token = "0x6021262")]
		[Address(RVA = "0x1B70BB0", Offset = "0x1B6F7B0", VA = "0x181B70BB0", Slot = "28")]
		protected override RoguelikeChatSimpleComp.DisplayControl UpdateContent()
		{
			return default(RoguelikeChatSimpleComp.DisplayControl);
		}

		// Token: 0x0402D24C RID: 184908
		[Token(Token = "0x402D24C")]
		[FieldOffset(Offset = "0x40")]
		public string title;

		// Token: 0x0402D24D RID: 184909
		[Token(Token = "0x402D24D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D24E RID: 184910
		[Token(Token = "0x402D24E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateContent;
	}
}
