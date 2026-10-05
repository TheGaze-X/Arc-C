using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000257 RID: 599
	[Token(Token = "0x2000257")]
	public class DigitallySigned
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x5249F20", Offset = "0x5248B20", VA = "0x185249F20")]
		public DigitallySigned(SignatureAndHashAlgorithm algorithm, byte[] signature)
		{
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DC")]
		public virtual SignatureAndHashAlgorithm Algorithm
		{
			[Token(Token = "0x60014BE")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002DD")]
		public virtual byte[] Signature
		{
			[Token(Token = "0x60014BF")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x5249CC0", Offset = "0x52488C0", VA = "0x185249CC0", Slot = "6")]
		public virtual void Encode(Stream output)
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x5249D60", Offset = "0x5248960", VA = "0x185249D60")]
		public static DigitallySigned Parse(TlsContext context, Stream input)
		{
			return null;
		}

		// Token: 0x04000AF2 RID: 2802
		[Token(Token = "0x4000AF2")]
		[FieldOffset(Offset = "0x10")]
		protected readonly SignatureAndHashAlgorithm mAlgorithm;

		// Token: 0x04000AF3 RID: 2803
		[Token(Token = "0x4000AF3")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] mSignature;
	}
}
