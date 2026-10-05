using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200535B RID: 21339
	[Token(Token = "0x200535B")]
	public class RoguelikeMenuCompViewModel : IHotfixable
	{
		// Token: 0x0601F74A RID: 128842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F74A")]
		[Address(RVA = "0x1927C30", Offset = "0x1926830", VA = "0x181927C30", Slot = "4")]
		public virtual void LoadData(string topicId)
		{
		}

		// Token: 0x0601F74B RID: 128843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F74B")]
		[Address(RVA = "0x1927D30", Offset = "0x1926930", VA = "0x181927D30")]
		public RoguelikeMenuCompViewModel()
		{
		}

		// Token: 0x0402A535 RID: 173365
		[Token(Token = "0x402A535")]
		[FieldOffset(Offset = "0x10")]
		public bool isInit;

		// Token: 0x0402A536 RID: 173366
		[Token(Token = "0x402A536")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A537 RID: 173367
		[Token(Token = "0x402A537")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
