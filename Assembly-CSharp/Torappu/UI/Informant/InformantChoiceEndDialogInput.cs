using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F2 RID: 18930
	[Token(Token = "0x20049F2")]
	public class InformantChoiceEndDialogInput : IHotfixable
	{
		// Token: 0x0601C804 RID: 116740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C804")]
		[Address(RVA = "0x15F3310", Offset = "0x15F1F10", VA = "0x1815F3310")]
		public InformantChoiceEndDialogInput()
		{
		}

		// Token: 0x04025569 RID: 152937
		[Token(Token = "0x4025569")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0402556A RID: 152938
		[Token(Token = "0x402556A")]
		[FieldOffset(Offset = "0x18")]
		public bool useSimpleEnterAnim;

		// Token: 0x0402556B RID: 152939
		[Token(Token = "0x402556B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
