using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	internal class MonoBtlsException : Exception
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x4F576F0", Offset = "0x4F562F0", VA = "0x184F576F0")]
		public MonoBtlsException()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x4F577C0", Offset = "0x4F563C0", VA = "0x184F577C0")]
		public MonoBtlsException(MonoBtlsSslError error)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x4F57690", Offset = "0x4F56290", VA = "0x184F57690")]
		public MonoBtlsException(string message)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4F57740", Offset = "0x4F56340", VA = "0x184F57740")]
		public MonoBtlsException(string format, params object[] args)
		{
		}
	}
}
