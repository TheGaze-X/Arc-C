using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000254 RID: 596
	[Token(Token = "0x2000254")]
	internal class DeferredHash : TlsHandshakeHash, IDigest
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x52498A0", Offset = "0x52484A0", VA = "0x1852498A0")]
		internal DeferredHash()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x5249950", Offset = "0x5248550", VA = "0x185249950")]
		private DeferredHash(byte prfHashAlgorithm, IDigest prfHash)
		{
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "18")]
		public virtual void Init(TlsContext context)
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x5248CF0", Offset = "0x52478F0", VA = "0x185248CF0", Slot = "19")]
		public virtual TlsHandshakeHash NotifyPrfDetermined()
		{
			return null;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x52494A0", Offset = "0x52480A0", VA = "0x1852494A0", Slot = "20")]
		public virtual void TrackHashAlgorithm(byte hashAlgorithm)
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x5249230", Offset = "0x5247E30", VA = "0x185249230", Slot = "21")]
		public virtual void SealHashAlgorithms()
		{
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x5249270", Offset = "0x5247E70", VA = "0x185249270", Slot = "22")]
		public virtual TlsHandshakeHash StopTracking()
		{
			return null;
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x52488F0", Offset = "0x52474F0", VA = "0x1852488F0", Slot = "23")]
		public virtual IDigest ForkPrfHash()
		{
			return null;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x5248B30", Offset = "0x5247730", VA = "0x185248B30", Slot = "24")]
		public virtual byte[] GetFinalHash(byte hashAlgorithm)
		{
			return null;
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DB")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60014AF")]
			[Address(RVA = "0x5249A50", Offset = "0x5248650", VA = "0x185249A50", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x5248A70", Offset = "0x5247670", VA = "0x185248A70", Slot = "26")]
		public virtual int GetByteLength()
		{
			return 0;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x5248AD0", Offset = "0x52476D0", VA = "0x185248AD0", Slot = "27")]
		public virtual int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x5249540", Offset = "0x5248140", VA = "0x185249540", Slot = "28")]
		public virtual void Update(byte input)
		{
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x52480B0", Offset = "0x5246CB0", VA = "0x1852480B0", Slot = "29")]
		public virtual void BlockUpdate(byte[] input, int inOff, int len)
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x5248890", Offset = "0x5247490", VA = "0x185248890", Slot = "30")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x5248EF0", Offset = "0x5247AF0", VA = "0x185248EF0", Slot = "31")]
		public virtual void Reset()
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x5248410", Offset = "0x5247010", VA = "0x185248410", Slot = "32")]
		protected virtual void CheckStopBuffering()
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x52486F0", Offset = "0x52472F0", VA = "0x1852486F0", Slot = "33")]
		protected virtual void CheckTrackingHash(byte hashAlgorithm)
		{
		}

		// Token: 0x04000AEC RID: 2796
		[Token(Token = "0x4000AEC")]
		protected const int BUFFERING_HASH_LIMIT = 4;

		// Token: 0x04000AED RID: 2797
		[Token(Token = "0x4000AED")]
		[FieldOffset(Offset = "0x10")]
		protected TlsContext mContext;

		// Token: 0x04000AEE RID: 2798
		[Token(Token = "0x4000AEE")]
		[FieldOffset(Offset = "0x18")]
		private DigestInputBuffer mBuf;

		// Token: 0x04000AEF RID: 2799
		[Token(Token = "0x4000AEF")]
		[FieldOffset(Offset = "0x20")]
		private IDictionary mHashes;

		// Token: 0x04000AF0 RID: 2800
		[Token(Token = "0x4000AF0")]
		[FieldOffset(Offset = "0x28")]
		private int mPrfHashAlgorithm;
	}
}
