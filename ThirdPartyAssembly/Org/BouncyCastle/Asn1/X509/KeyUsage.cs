using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	public class KeyUsage : DerBitString
	{
		// Token: 0x0600224B RID: 8779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224B")]
		[Address(RVA = "0x533FE00", Offset = "0x533EA00", VA = "0x18533FE00")]
		public new static KeyUsage GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224C")]
		[Address(RVA = "0x5340270", Offset = "0x533EE70", VA = "0x185340270")]
		public KeyUsage(int usage)
		{
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600224D")]
		[Address(RVA = "0x53401A0", Offset = "0x533EDA0", VA = "0x1853401A0")]
		private KeyUsage(DerBitString usage)
		{
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x53400E0", Offset = "0x533ECE0", VA = "0x1853400E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		public const int DigitalSignature = 128;

		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		public const int NonRepudiation = 64;

		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		public const int KeyEncipherment = 32;

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		public const int DataEncipherment = 16;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		public const int KeyAgreement = 8;

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		public const int KeyCertSign = 4;

		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		public const int CrlSign = 2;

		// Token: 0x04001208 RID: 4616
		[Token(Token = "0x4001208")]
		public const int EncipherOnly = 1;

		// Token: 0x04001209 RID: 4617
		[Token(Token = "0x4001209")]
		public const int DecipherOnly = 32768;
	}
}
