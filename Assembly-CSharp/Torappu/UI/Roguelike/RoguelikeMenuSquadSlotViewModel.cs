using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005350 RID: 21328
	[Token(Token = "0x2005350")]
	public class RoguelikeMenuSquadSlotViewModel : IHotfixable
	{
		// Token: 0x0601F72A RID: 128810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F72A")]
		[Address(RVA = "0x192A4F0", Offset = "0x19290F0", VA = "0x18192A4F0")]
		public RoguelikeMenuSquadSlotViewModel()
		{
		}

		// Token: 0x0402A4EB RID: 173291
		[Token(Token = "0x402A4EB")]
		[FieldOffset(Offset = "0x10")]
		public bool isLocked;

		// Token: 0x0402A4EC RID: 173292
		[Token(Token = "0x402A4EC")]
		[FieldOffset(Offset = "0x11")]
		public bool isEmpty;

		// Token: 0x0402A4ED RID: 173293
		[Token(Token = "0x402A4ED")]
		[FieldOffset(Offset = "0x12")]
		public bool isUpgraded;

		// Token: 0x0402A4EE RID: 173294
		[Token(Token = "0x402A4EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
