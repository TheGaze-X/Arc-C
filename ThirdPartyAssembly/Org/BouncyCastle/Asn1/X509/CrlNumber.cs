using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	public class CrlNumber : DerInteger
	{
		// Token: 0x060021FC RID: 8700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x532F4F0", Offset = "0x532E0F0", VA = "0x18532F4F0")]
		public CrlNumber(BigInteger number)
		{
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000464")]
		public BigInteger Number
		{
			[Token(Token = "0x60021FD")]
			[Address(RVA = "0x532F580", Offset = "0x532E180", VA = "0x18532F580")]
			get
			{
				return null;
			}
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x532F430", Offset = "0x532E030", VA = "0x18532F430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
