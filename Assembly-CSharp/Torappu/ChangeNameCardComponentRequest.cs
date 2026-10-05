using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	public class ChangeNameCardComponentRequest
	{
		// Token: 0x0600639F RID: 25503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeNameCardComponentRequest()
		{
		}

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x10")]
		public List<string> component;
	}
}
