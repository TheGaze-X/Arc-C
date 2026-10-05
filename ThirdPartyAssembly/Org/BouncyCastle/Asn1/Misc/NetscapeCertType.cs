using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.Misc
{
	// Token: 0x02000464 RID: 1124
	[Token(Token = "0x2000464")]
	public class NetscapeCertType : DerBitString
	{
		// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x536A000", Offset = "0x5368C00", VA = "0x18536A000")]
		public NetscapeCertType(int usage)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x536A060", Offset = "0x5368C60", VA = "0x18536A060")]
		public NetscapeCertType(DerBitString usage)
		{
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x5369F50", Offset = "0x5368B50", VA = "0x185369F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		public const int SslClient = 128;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		public const int SslServer = 64;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		public const int Smime = 32;

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		public const int ObjectSigning = 16;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		public const int Reserved = 8;

		// Token: 0x0400144C RID: 5196
		[Token(Token = "0x400144C")]
		public const int SslCA = 4;

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x400144D")]
		public const int SmimeCA = 2;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		public const int ObjectSigningCA = 1;
	}
}
