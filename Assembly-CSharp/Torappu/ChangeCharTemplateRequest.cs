using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006C1 RID: 1729
	[Token(Token = "0x20006C1")]
	public class ChangeCharTemplateRequest
	{
		// Token: 0x0600630A RID: 25354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600630A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeCharTemplateRequest()
		{
		}

		// Token: 0x04002EB1 RID: 11953
		[Token(Token = "0x4002EB1")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002EB2 RID: 11954
		[Token(Token = "0x4002EB2")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;
	}
}
