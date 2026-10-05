using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200039D RID: 925
	[Token(Token = "0x200039D")]
	public class Asn1StreamParser
	{
		// Token: 0x06001F7C RID: 8060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x5314F80", Offset = "0x5313B80", VA = "0x185314F80")]
		public Asn1StreamParser(Stream inStream)
		{
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x5314FC0", Offset = "0x5313BC0", VA = "0x185314FC0")]
		public Asn1StreamParser(Stream inStream, int limit)
		{
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x53150E0", Offset = "0x5313CE0", VA = "0x1853150E0")]
		public Asn1StreamParser(byte[] encoding)
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x5314010", Offset = "0x5312C10", VA = "0x185314010")]
		internal IAsn1Convertible ReadIndef(int tagValue)
		{
			return null;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x5313CE0", Offset = "0x53128E0", VA = "0x185313CE0")]
		internal IAsn1Convertible ReadImplicit(bool constructed, int tag)
		{
			return null;
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x5314810", Offset = "0x5313410", VA = "0x185314810")]
		internal Asn1Object ReadTaggedObject(bool constructed, int tag)
		{
			return null;
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x5314160", Offset = "0x5312D60", VA = "0x185314160", Slot = "4")]
		public virtual IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x5314DE0", Offset = "0x53139E0", VA = "0x185314DE0")]
		private void Set00Check(bool enabled)
		{
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x5314BF0", Offset = "0x53137F0", VA = "0x185314BF0")]
		internal Asn1EncodableVector ReadVector()
		{
			return null;
		}

		// Token: 0x040010EC RID: 4332
		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x10")]
		private readonly Stream _in;

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _limit;

		// Token: 0x040010EE RID: 4334
		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x20")]
		private readonly byte[][] tmpBuffers;
	}
}
