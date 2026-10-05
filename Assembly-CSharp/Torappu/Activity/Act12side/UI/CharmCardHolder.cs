using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A7D RID: 31357
	[Token(Token = "0x2007A7D")]
	public class CharmCardHolder : IHotfixable
	{
		// Token: 0x0602BEBD RID: 179901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEBD")]
		[Address(RVA = "0x27D1C30", Offset = "0x27D0830", VA = "0x1827D1C30")]
		public CharmCardHolder()
		{
		}

		// Token: 0x0403F9DB RID: 260571
		[Token(Token = "0x403F9DB")]
		[FieldOffset(Offset = "0x10")]
		public CharmCard card;

		// Token: 0x0403F9DC RID: 260572
		[Token(Token = "0x403F9DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
