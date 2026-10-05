using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052D5 RID: 21205
	[Token(Token = "0x20052D5")]
	public class RoguelikeExpeditionCharCardView : RoguelikeExpeditionCharCardViewBase, IHotfixable
	{
		// Token: 0x0601F46F RID: 128111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F46F")]
		[Address(RVA = "0x18FB340", Offset = "0x18F9F40", VA = "0x1818FB340", Slot = "4")]
		protected override void RenderChar(RoguelikeExpeditionCharCardViewModel viewModel, string selectingCharId, bool fastMode)
		{
		}

		// Token: 0x0601F470 RID: 128112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F470")]
		[Address(RVA = "0x18FB3D0", Offset = "0x18F9FD0", VA = "0x1818FB3D0")]
		public RoguelikeExpeditionCharCardView()
		{
		}

		// Token: 0x0402A00C RID: 172044
		[Token(Token = "0x402A00C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderChar;

		// Token: 0x0402A00D RID: 172045
		[Token(Token = "0x402A00D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
