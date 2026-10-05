using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A30 RID: 18992
	[Token(Token = "0x2004A30")]
	public class InformantSelectChoiceDialogInput : IHotfixable
	{
		// Token: 0x0601C905 RID: 116997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C905")]
		[Address(RVA = "0x1615590", Offset = "0x1614190", VA = "0x181615590")]
		public InformantSelectChoiceDialogInput()
		{
		}

		// Token: 0x04025798 RID: 153496
		[Token(Token = "0x4025798")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04025799 RID: 153497
		[Token(Token = "0x4025799")]
		[FieldOffset(Offset = "0x18")]
		public bool useSimpleEnterAnim;

		// Token: 0x0402579A RID: 153498
		[Token(Token = "0x402579A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
