using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020043CD RID: 17357
	[Token(Token = "0x20043CD")]
	public class SandboxV2AlchemyRequest
	{
		// Token: 0x0601A978 RID: 108920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A978")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2AlchemyRequest()
		{
		}

		// Token: 0x04021E56 RID: 138838
		[Token(Token = "0x4021E56")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04021E57 RID: 138839
		[Token(Token = "0x4021E57")]
		[FieldOffset(Offset = "0x18")]
		public string recipeId;

		// Token: 0x04021E58 RID: 138840
		[Token(Token = "0x4021E58")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
