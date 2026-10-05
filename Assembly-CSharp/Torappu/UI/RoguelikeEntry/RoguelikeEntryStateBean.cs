using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeEntry
{
	// Token: 0x02004468 RID: 17512
	[Token(Token = "0x2004468")]
	public class RoguelikeEntryStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601AC63 RID: 109667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AC63")]
		[Address(RVA = "0x13D8550", Offset = "0x13D7150", VA = "0x1813D8550")]
		public RoguelikeEntryStateBean()
		{
		}

		// Token: 0x0402238F RID: 140175
		[Token(Token = "0x402238F")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeEntryProperty property;

		// Token: 0x04022390 RID: 140176
		[Token(Token = "0x4022390")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
