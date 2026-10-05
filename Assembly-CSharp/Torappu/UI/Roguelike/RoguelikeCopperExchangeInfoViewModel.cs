using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051DE RID: 20958
	[Token(Token = "0x20051DE")]
	public class RoguelikeCopperExchangeInfoViewModel : IHotfixable
	{
		// Token: 0x0601EF3E RID: 126782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF3E")]
		[Address(RVA = "0x18B0C70", Offset = "0x18AF870", VA = "0x1818B0C70")]
		public RoguelikeCopperExchangeInfoViewModel()
		{
		}

		// Token: 0x0402989C RID: 170140
		[Token(Token = "0x402989C")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402989D RID: 170141
		[Token(Token = "0x402989D")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeGameCopperItemViewModel oldCopper;

		// Token: 0x0402989E RID: 170142
		[Token(Token = "0x402989E")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeGameCopperItemViewModel newCopper;

		// Token: 0x0402989F RID: 170143
		[Token(Token = "0x402989F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
