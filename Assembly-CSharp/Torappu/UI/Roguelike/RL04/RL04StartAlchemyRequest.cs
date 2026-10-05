using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200570C RID: 22284
	[Token(Token = "0x200570C")]
	public class RL04StartAlchemyRequest
	{
		// Token: 0x06020AC7 RID: 133831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AC7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL04StartAlchemyRequest()
		{
		}

		// Token: 0x0402C578 RID: 181624
		[Token(Token = "0x402C578")]
		[FieldOffset(Offset = "0x10")]
		public List<string> fragmentIndex;

		// Token: 0x0402C579 RID: 181625
		[Token(Token = "0x402C579")]
		[FieldOffset(Offset = "0x18")]
		public bool leave;
	}
}
