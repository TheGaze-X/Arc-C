using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003648 RID: 13896
	[Token(Token = "0x2003648")]
	public struct StateEngineRuntime
	{
		// Token: 0x060161D1 RID: 90577 RVA: 0x0008F7F0 File Offset: 0x0008D9F0
		[Token(Token = "0x60161D1")]
		[Address(RVA = "0xE98A90", Offset = "0xE97690", VA = "0x180E98A90")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0401A973 RID: 108915
		[Token(Token = "0x401A973")]
		[FieldOffset(Offset = "0x0")]
		public List<StateCache> stateRuntimes;
	}
}
