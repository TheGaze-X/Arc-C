using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x0200030D RID: 781
	[Token(Token = "0x200030D")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public class PKCS1MaskGenerationMethod : MaskGenerationMethod
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x4B2F7A0", Offset = "0x4B2E3A0", VA = "0x184B2F7A0")]
		public PKCS1MaskGenerationMethod()
		{
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		public string HashName
		{
			[Token(Token = "0x60019A1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60019A2")]
			[Address(RVA = "0x4B2F7F0", Offset = "0x4B2E3F0", VA = "0x184B2F7F0")]
			set
			{
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x4B2F720", Offset = "0x4B2E320", VA = "0x184B2F720", Slot = "4")]
		public override byte[] GenerateMask(byte[] rgbSeed, int cbReturn)
		{
			return null;
		}

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string HashNameValue;
	}
}
