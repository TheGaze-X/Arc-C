using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	public class LazyAsn1InputStream : Asn1InputStream
	{
		// Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x5340450", Offset = "0x533F050", VA = "0x185340450")]
		public LazyAsn1InputStream(byte[] input)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x5340460", Offset = "0x533F060", VA = "0x185340460")]
		public LazyAsn1InputStream(Stream inputStream)
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x53402D0", Offset = "0x533EED0", VA = "0x1853402D0", Slot = "39")]
		internal override DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x5340390", Offset = "0x533EF90", VA = "0x185340390", Slot = "40")]
		internal override DerSet CreateDerSet(DefiniteLengthInputStream dIn)
		{
			return null;
		}
	}
}
