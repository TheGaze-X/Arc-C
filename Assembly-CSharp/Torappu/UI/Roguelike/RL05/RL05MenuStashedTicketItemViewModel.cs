using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055F8 RID: 22008
	[Token(Token = "0x20055F8")]
	public class RL05MenuStashedTicketItemViewModel : IHotfixable
	{
		// Token: 0x060204DC RID: 132316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60204DC")]
		[Address(RVA = "0x1A66280", Offset = "0x1A64E80", VA = "0x181A66280")]
		public RL05MenuStashedTicketItemViewModel()
		{
		}

		// Token: 0x0402BB86 RID: 179078
		[Token(Token = "0x402BB86")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0402BB87 RID: 179079
		[Token(Token = "0x402BB87")]
		[FieldOffset(Offset = "0x18")]
		public int sordId;

		// Token: 0x0402BB88 RID: 179080
		[Token(Token = "0x402BB88")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x0402BB89 RID: 179081
		[Token(Token = "0x402BB89")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0402BB8A RID: 179082
		[Token(Token = "0x402BB8A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
