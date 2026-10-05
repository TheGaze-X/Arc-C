using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004922 RID: 18722
	[Token(Token = "0x2004922")]
	public class MedalDIYPreviewBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C3AE RID: 115630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C3AE")]
		[Address(RVA = "0x15AFC20", Offset = "0x15AE820", VA = "0x1815AFC20")]
		public MedalDIYPreviewBean()
		{
		}

		// Token: 0x04024EB5 RID: 151221
		[Token(Token = "0x4024EB5")]
		[FieldOffset(Offset = "0x10")]
		public IDictionary<string, HexPoint> tokens;

		// Token: 0x04024EB6 RID: 151222
		[Token(Token = "0x4024EB6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
