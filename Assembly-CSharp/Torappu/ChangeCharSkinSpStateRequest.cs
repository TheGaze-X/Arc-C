using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006BF RID: 1727
	[Token(Token = "0x20006BF")]
	public class ChangeCharSkinSpStateRequest
	{
		// Token: 0x06006308 RID: 25352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006308")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeCharSkinSpStateRequest()
		{
		}

		// Token: 0x04002EAF RID: 11951
		[Token(Token = "0x4002EAF")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x04002EB0 RID: 11952
		[Token(Token = "0x4002EB0")]
		[FieldOffset(Offset = "0x18")]
		public bool isSpecial;
	}
}
