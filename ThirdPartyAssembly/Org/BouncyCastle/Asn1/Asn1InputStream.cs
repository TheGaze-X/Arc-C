using System;
using System.IO;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public class Asn1InputStream : FilterStream
	{
		// Token: 0x06001F28 RID: 7976 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x6001F28")]
		[Address(RVA = "0x530EDE0", Offset = "0x530D9E0", VA = "0x18530EDE0")]
		internal static int FindLimit(Stream input)
		{
			return 0;
		}

		// Token: 0x06001F29 RID: 7977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F29")]
		[Address(RVA = "0x530FDF0", Offset = "0x530E9F0", VA = "0x18530FDF0")]
		public Asn1InputStream(Stream inputStream)
		{
		}

		// Token: 0x06001F2A RID: 7978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2A")]
		[Address(RVA = "0x530FE70", Offset = "0x530EA70", VA = "0x18530FE70")]
		public Asn1InputStream(Stream inputStream, int limit)
		{
		}

		// Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x530FD30", Offset = "0x530E930", VA = "0x18530FD30")]
		public Asn1InputStream(byte[] input)
		{
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2C")]
		[Address(RVA = "0x530E340", Offset = "0x530CF40", VA = "0x18530E340")]
		private Asn1Object BuildObject(int tag, int tagNo, int length)
		{
			return null;
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x530E210", Offset = "0x530CE10", VA = "0x18530E210")]
		internal Asn1EncodableVector BuildEncodableVector()
		{
			return null;
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x530E0A0", Offset = "0x530CCA0", VA = "0x18530E0A0", Slot = "38")]
		internal virtual Asn1EncodableVector BuildDerEncodableVector(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x530E640", Offset = "0x530D240", VA = "0x18530E640", Slot = "39")]
		internal virtual DerSequence CreateDerSequence(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x530E6D0", Offset = "0x530D2D0", VA = "0x18530E6D0", Slot = "40")]
		internal virtual DerSet CreateDerSet(DefiniteLengthInputStream dIn)
		{
			return null;
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x530F5D0", Offset = "0x530E1D0", VA = "0x18530F5D0")]
		public Asn1Object ReadObject()
		{
			return null;
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x530FBE0", Offset = "0x530E7E0", VA = "0x18530FBE0")]
		internal static int ReadTagNumber(Stream s, int tag)
		{
			return 0;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x530F320", Offset = "0x530DF20", VA = "0x18530F320")]
		internal static int ReadLength(Stream s, int limit)
		{
			return 0;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x530F0B0", Offset = "0x530DCB0", VA = "0x18530F0B0")]
		internal static byte[] GetBuffer(DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			return null;
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x530E760", Offset = "0x530D360", VA = "0x18530E760")]
		internal static Asn1Object CreatePrimitiveDerObject(int tagNo, DefiniteLengthInputStream defIn, byte[][] tmpBuffers)
		{
			return null;
		}

		// Token: 0x040010E1 RID: 4321
		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x30")]
		private readonly int limit;

		// Token: 0x040010E2 RID: 4322
		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x38")]
		private readonly byte[][] tmpBuffers;
	}
}
