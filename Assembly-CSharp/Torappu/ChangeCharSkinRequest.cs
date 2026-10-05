using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006BD RID: 1725
	[Token(Token = "0x20006BD")]
	public class ChangeCharSkinRequest
	{
		// Token: 0x06006306 RID: 25350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006306")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeCharSkinRequest()
		{
		}

		// Token: 0x04002EAD RID: 11949
		[Token(Token = "0x4002EAD")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002EAE RID: 11950
		[Token(Token = "0x4002EAE")]
		[FieldOffset(Offset = "0x18")]
		public string skinId;
	}
}
