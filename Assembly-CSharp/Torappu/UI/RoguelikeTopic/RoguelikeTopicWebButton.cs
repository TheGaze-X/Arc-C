using System;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic.Mode;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004585 RID: 17797
	[Token(Token = "0x2004585")]
	public class RoguelikeTopicWebButton : RoguelikeTopicSubView, IHotfixable
	{
		// Token: 0x0601B18A RID: 110986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B18A")]
		[Address(RVA = "0x1440A20", Offset = "0x143F620", VA = "0x181440A20")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601B18B RID: 110987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B18B")]
		[Address(RVA = "0x1440AB0", Offset = "0x143F6B0", VA = "0x181440AB0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601B18C RID: 110988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B18C")]
		[Address(RVA = "0x1440B30", Offset = "0x143F730", VA = "0x181440B30")]
		public RoguelikeTopicWebButton()
		{
		}

		// Token: 0x0601B18D RID: 110989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B18D")]
		[Address(RVA = "0x1414A70", Offset = "0x1413670", VA = "0x181414A70")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04022DCA RID: 142794
		[Token(Token = "0x4022DCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04022DCB RID: 142795
		[Token(Token = "0x4022DCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04022DCC RID: 142796
		[Token(Token = "0x4022DCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
