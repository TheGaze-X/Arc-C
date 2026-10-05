using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	public abstract class Asn1Object : Asn1Encodable
	{
		// Token: 0x06001F38 RID: 7992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x530FF20", Offset = "0x530EB20", VA = "0x18530FF20")]
		public static Asn1Object FromByteArray(byte[] data)
		{
			return null;
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x5310130", Offset = "0x530ED30", VA = "0x185310130")]
		public static Asn1Object FromStream(Stream inStr)
		{
			return null;
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "5")]
		public sealed override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x06001F3B RID: 7995
		[Token(Token = "0x6001F3B")]
		internal abstract void Encode(DerOutputStream derOut);

		// Token: 0x06001F3C RID: 7996
		[Token(Token = "0x6001F3C")]
		protected abstract bool Asn1Equals(Asn1Object asn1Object);

		// Token: 0x06001F3D RID: 7997
		[Token(Token = "0x6001F3D")]
		protected abstract int Asn1GetHashCode();

		// Token: 0x06001F3E RID: 7998 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x51F8F40", Offset = "0x51F7B40", VA = "0x1851F8F40")]
		internal bool CallAsn1Equals(Asn1Object obj)
		{
			return default(bool);
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x4D048D0", Offset = "0x4D034D0", VA = "0x184D048D0")]
		internal int CallAsn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Asn1Object()
		{
		}
	}
}
