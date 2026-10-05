using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058B5 RID: 22709
	[Token(Token = "0x20058B5")]
	public abstract class ChatSimpleViewBase : RoguelikeChatSimpleComp.VirtualView
	{
		// Token: 0x0602125D RID: 135773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602125D")]
		[Address(RVA = "0x1B70AE0", Offset = "0x1B6F6E0", VA = "0x181B70AE0")]
		public ChatSimpleViewBase(RoguelikeChatSimpleComp prefab)
		{
		}

		// Token: 0x0602125E RID: 135774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602125E")]
		[Address(RVA = "0x1B70A80", Offset = "0x1B6F680", VA = "0x181B70A80", Slot = "27")]
		protected sealed override RoguelikeChatSimpleComp SimplePrefab()
		{
			return null;
		}

		// Token: 0x0402D247 RID: 184903
		[Token(Token = "0x402D247")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeChatSimpleComp m_prefab;

		// Token: 0x0402D248 RID: 184904
		[Token(Token = "0x402D248")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D249 RID: 184905
		[Token(Token = "0x402D249")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SimplePrefab;
	}
}
