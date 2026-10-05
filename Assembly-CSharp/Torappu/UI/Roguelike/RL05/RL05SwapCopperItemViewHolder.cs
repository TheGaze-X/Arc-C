using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055B7 RID: 21943
	[Token(Token = "0x20055B7")]
	public class RL05SwapCopperItemViewHolder : IHotfixable
	{
		// Token: 0x06020378 RID: 131960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020378")]
		[Address(RVA = "0x1A5BD60", Offset = "0x1A5A960", VA = "0x181A5BD60")]
		public RL05SwapCopperItemViewHolder()
		{
		}

		// Token: 0x0402B939 RID: 178489
		[Token(Token = "0x402B939")]
		[FieldOffset(Offset = "0x10")]
		public RL05SwapCopperItemView view;

		// Token: 0x0402B93A RID: 178490
		[Token(Token = "0x402B93A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
