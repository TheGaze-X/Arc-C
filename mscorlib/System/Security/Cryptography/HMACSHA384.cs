using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000304 RID: 772
	[Token(Token = "0x2000304")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class HMACSHA384 : HMAC
	{
		// Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x4B2BEF0", Offset = "0x4B2AAF0", VA = "0x184B2BEF0")]
		public HMACSHA384()
		{
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x4B2C070", Offset = "0x4B2AC70", VA = "0x184B2C070")]
		public HMACSHA384(byte[] key)
		{
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x170002AD")]
		private int BlockSize
		{
			[Token(Token = "0x600195A")]
			[Address(RVA = "0x4B2C1B0", Offset = "0x4B2ADB0", VA = "0x184B2C1B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		public bool ProduceLegacyHmacValues
		{
			[Token(Token = "0x600195B")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x4B2C1D0", Offset = "0x4B2ADD0", VA = "0x184B2C1D0")]
			set
			{
			}
		}

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_useLegacyBlockSize;
	}
}
