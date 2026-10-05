using System;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	public sealed class TlsException : Exception
	{
		// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4AA6330", Offset = "0x4AA4F30", VA = "0x184AA6330")]
		public TlsException(Alert alert)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4AA6160", Offset = "0x4AA4D60", VA = "0x184AA6160")]
		public TlsException(Alert alert, string message)
		{
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4AA6270", Offset = "0x4AA4E70", VA = "0x184AA6270")]
		public TlsException(AlertDescription description)
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4AA61E0", Offset = "0x4AA4DE0", VA = "0x184AA61E0")]
		public TlsException(AlertDescription description, string message)
		{
		}

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x90")]
		private Alert alert;
	}
}
