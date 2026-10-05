using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058B6 RID: 22710
	[Token(Token = "0x20058B6")]
	public class ChatEmptyVirtualView : ChatSimpleViewBase
	{
		// Token: 0x0602125F RID: 135775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602125F")]
		[Address(RVA = "0x1B707E0", Offset = "0x1B6F3E0", VA = "0x181B707E0")]
		public ChatEmptyVirtualView(RoguelikeChatSimpleComp prefab)
		{
		}

		// Token: 0x06021260 RID: 135776 RVA: 0x000B8BC0 File Offset: 0x000B6DC0
		[Token(Token = "0x6021260")]
		[Address(RVA = "0x1B70750", Offset = "0x1B6F350", VA = "0x181B70750", Slot = "28")]
		protected override RoguelikeChatSimpleComp.DisplayControl UpdateContent()
		{
			return default(RoguelikeChatSimpleComp.DisplayControl);
		}

		// Token: 0x0402D24A RID: 184906
		[Token(Token = "0x402D24A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D24B RID: 184907
		[Token(Token = "0x402D24B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateContent;
	}
}
