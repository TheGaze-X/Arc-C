using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058B8 RID: 22712
	[Token(Token = "0x20058B8")]
	public class ChatEndVirutalView : ChatSimpleViewBase
	{
		// Token: 0x06021263 RID: 135779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021263")]
		[Address(RVA = "0x1B70A10", Offset = "0x1B6F610", VA = "0x181B70A10")]
		public ChatEndVirutalView(RoguelikeChatSimpleComp prefab)
		{
		}

		// Token: 0x06021264 RID: 135780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021264")]
		[Address(RVA = "0x1B70850", Offset = "0x1B6F450", VA = "0x181B70850", Slot = "29")]
		protected override void OnViewClicked()
		{
		}

		// Token: 0x06021265 RID: 135781 RVA: 0x000B8BF0 File Offset: 0x000B6DF0
		[Token(Token = "0x6021265")]
		[Address(RVA = "0x1B70920", Offset = "0x1B6F520", VA = "0x181B70920", Slot = "28")]
		protected override RoguelikeChatSimpleComp.DisplayControl UpdateContent()
		{
			return default(RoguelikeChatSimpleComp.DisplayControl);
		}

		// Token: 0x06021266 RID: 135782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021266")]
		[Address(RVA = "0x1B708C0", Offset = "0x1B6F4C0", VA = "0x181B708C0")]
		private void <>xLuaBaseProxy_OnViewClicked()
		{
		}

		// Token: 0x0402D24F RID: 184911
		[Token(Token = "0x402D24F")]
		[FieldOffset(Offset = "0x40")]
		public bool isLastChat;

		// Token: 0x0402D250 RID: 184912
		[Token(Token = "0x402D250")]
		[FieldOffset(Offset = "0x48")]
		public Action onClicked;

		// Token: 0x0402D251 RID: 184913
		[Token(Token = "0x402D251")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D252 RID: 184914
		[Token(Token = "0x402D252")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewClicked;

		// Token: 0x0402D253 RID: 184915
		[Token(Token = "0x402D253")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateContent;
	}
}
