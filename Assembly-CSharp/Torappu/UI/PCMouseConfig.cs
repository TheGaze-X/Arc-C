using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003747 RID: 14151
	[Token(Token = "0x2003747")]
	[Serializable]
	public class PCMouseConfig : IHotfixable
	{
		// Token: 0x060167C4 RID: 92100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167C4")]
		[Address(RVA = "0xEDBEB0", Offset = "0xEDAAB0", VA = "0x180EDBEB0")]
		public PCMouseConfig()
		{
		}

		// Token: 0x0401B148 RID: 110920
		[Token(Token = "0x401B148")]
		[FieldOffset(Offset = "0x10")]
		public PCMouseHandlerBase mouseHandler;

		// Token: 0x0401B149 RID: 110921
		[Token(Token = "0x401B149")]
		[FieldOffset(Offset = "0x18")]
		public PCMouseHandlerBase mouseHandlerInBattle;

		// Token: 0x0401B14A RID: 110922
		[Token(Token = "0x401B14A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
