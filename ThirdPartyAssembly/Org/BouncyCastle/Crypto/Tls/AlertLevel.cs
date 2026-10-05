using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	public abstract class AlertLevel
	{
		// Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x52415D0", Offset = "0x52401D0", VA = "0x1852415D0")]
		public static string GetName(byte alertDescription)
		{
			return null;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x5241640", Offset = "0x5240240", VA = "0x185241640")]
		public static string GetText(byte alertDescription)
		{
			return null;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AlertLevel()
		{
		}

		// Token: 0x040009AB RID: 2475
		[Token(Token = "0x40009AB")]
		public const byte warning = 1;

		// Token: 0x040009AC RID: 2476
		[Token(Token = "0x40009AC")]
		public const byte fatal = 2;
	}
}
