using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Racing
{
	// Token: 0x02002978 RID: 10616
	[Token(Token = "0x2002978")]
	public class RacingOutput : IHotfixable
	{
		// Token: 0x06011908 RID: 71944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011908")]
		[Address(RVA = "0x95E2B0", Offset = "0x95CEB0", VA = "0x18095E2B0")]
		public RacingOutput()
		{
		}

		// Token: 0x04013A15 RID: 80405
		[Token(Token = "0x4013A15")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RacingFinishRecord> record;

		// Token: 0x04013A16 RID: 80406
		[Token(Token = "0x4013A16")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
