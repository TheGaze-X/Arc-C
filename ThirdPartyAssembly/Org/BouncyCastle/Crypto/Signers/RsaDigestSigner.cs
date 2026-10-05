using System;
using System.Collections;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020002BC RID: 700
	[Token(Token = "0x20002BC")]
	public class RsaDigestSigner : ISigner
	{
		// Token: 0x0600180B RID: 6155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180B")]
		[Address(RVA = "0x5295830", Offset = "0x5294430", VA = "0x185295830")]
		public RsaDigestSigner(IDigest digest)
		{
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180C")]
		[Address(RVA = "0x52956D0", Offset = "0x52942D0", VA = "0x1852956D0")]
		public RsaDigestSigner(IDigest digest, DerObjectIdentifier digestOid)
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180D")]
		[Address(RVA = "0x52955E0", Offset = "0x52941E0", VA = "0x1852955E0")]
		public RsaDigestSigner(IDigest digest, AlgorithmIdentifier algId)
		{
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033F")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x5295AA0", Offset = "0x52946A0", VA = "0x185295AA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x5294A50", Offset = "0x5293650", VA = "0x185294A50", Slot = "12")]
		public virtual void Init(bool forSigning, ICipherParameters parameters)
		{
		}

		// Token: 0x06001810 RID: 6160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001810")]
		[Address(RVA = "0x5294E10", Offset = "0x5293A10", VA = "0x185294E10", Slot = "13")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001811 RID: 6161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001811")]
		[Address(RVA = "0x52947F0", Offset = "0x52933F0", VA = "0x1852947F0", Slot = "14")]
		public virtual void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001812")]
		[Address(RVA = "0x5294900", Offset = "0x5293500", VA = "0x185294900", Slot = "15")]
		public virtual byte[] GenerateSignature()
		{
			return null;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x6001813")]
		[Address(RVA = "0x5294E70", Offset = "0x5293A70", VA = "0x185294E70", Slot = "16")]
		public virtual bool VerifySignature(byte[] signature)
		{
			return default(bool);
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x5294DC0", Offset = "0x52939C0", VA = "0x185294DC0", Slot = "17")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001815")]
		[Address(RVA = "0x5294870", Offset = "0x5293470", VA = "0x185294870")]
		private byte[] DerEncode(byte[] hash)
		{
			return null;
		}

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x10")]
		private readonly IAsymmetricBlockCipher rsaEngine;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x18")]
		private readonly AlgorithmIdentifier algId;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDigest digest;

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x28")]
		private bool forSigning;

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IDictionary oidMap;
	}
}
