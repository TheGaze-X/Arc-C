using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public class LoginoutRequest
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public LoginoutRequest()
		{
		}

		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		[FieldOffset(Offset = "0x18")]
		public int type;
	}
}
