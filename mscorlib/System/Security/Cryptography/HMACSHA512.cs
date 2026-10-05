using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000305 RID: 773
	[Token(Token = "0x2000305")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class HMACSHA512 : HMAC
	{
		// Token: 0x0600195D RID: 6493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x4B2C330", Offset = "0x4B2AF30", VA = "0x184B2C330")]
		public HMACSHA512()
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x4B2C1F0", Offset = "0x4B2ADF0", VA = "0x184B2C1F0")]
		public HMACSHA512(byte[] key)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x170002AF")]
		private int BlockSize
		{
			[Token(Token = "0x600195F")]
			[Address(RVA = "0x4B2C1B0", Offset = "0x4B2ADB0", VA = "0x184B2C1B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B0")]
		public bool ProduceLegacyHmacValues
		{
			[Token(Token = "0x6001960")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001961")]
			[Address(RVA = "0x4B2C1D0", Offset = "0x4B2ADD0", VA = "0x184B2C1D0")]
			set
			{
			}
		}

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_useLegacyBlockSize;
	}
}
