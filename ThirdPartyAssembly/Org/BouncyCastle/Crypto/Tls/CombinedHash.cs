using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	internal class CombinedHash : TlsHandshakeHash, IDigest
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x52463F0", Offset = "0x5244FF0", VA = "0x1852463F0")]
		internal CombinedHash()
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x5246470", Offset = "0x5245070", VA = "0x185246470")]
		internal CombinedHash(CombinedHash t)
		{
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "18")]
		public virtual void Init(TlsContext context)
		{
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146E")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "19")]
		public virtual TlsHandshakeHash NotifyPrfDetermined()
		{
			return null;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x5246310", Offset = "0x5244F10", VA = "0x185246310", Slot = "20")]
		public virtual void TrackHashAlgorithm(byte hashAlgorithm)
		{
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public virtual void SealHashAlgorithms()
		{
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x52462B0", Offset = "0x5244EB0", VA = "0x1852462B0", Slot = "22")]
		public virtual TlsHandshakeHash StopTracking()
		{
			return null;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x5245ED0", Offset = "0x5244AD0", VA = "0x185245ED0", Slot = "23")]
		public virtual IDigest ForkPrfHash()
		{
			return null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x5246050", Offset = "0x5244C50", VA = "0x185246050", Slot = "24")]
		public virtual byte[] GetFinalHash(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DA")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001474")]
			[Address(RVA = "0x5246530", Offset = "0x5245130", VA = "0x185246530", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x5245F30", Offset = "0x5244B30", VA = "0x185245F30", Slot = "26")]
		public virtual int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001476 RID: 5238 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x5245FD0", Offset = "0x5244BD0", VA = "0x185245FD0", Slot = "27")]
		public virtual int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x5246370", Offset = "0x5244F70", VA = "0x185246370", Slot = "28")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x5245CB0", Offset = "0x52448B0", VA = "0x185245CB0", Slot = "29")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x5245D60", Offset = "0x5244960", VA = "0x185245D60", Slot = "30")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x52460B0", Offset = "0x5244CB0", VA = "0x1852460B0", Slot = "31")]
		public virtual void Reset()
		{
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x5246120", Offset = "0x5244D20", VA = "0x185246120", Slot = "32")]
		protected virtual void Ssl3Complete(IDigest d, byte[] ipad, byte[] opad, int padLength)
		{
		}

		// Token: 0x04000AE0 RID: 2784
		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x10")]
		protected TlsContext mContext;

		// Token: 0x04000AE1 RID: 2785
		[Token(Token = "0x4000AE1")]
		[FieldOffset(Offset = "0x18")]
		protected IDigest mMd5;

		// Token: 0x04000AE2 RID: 2786
		[Token(Token = "0x4000AE2")]
		[FieldOffset(Offset = "0x20")]
		protected IDigest mSha1;
	}
}
