using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000384 RID: 900
	[Token(Token = "0x2000384")]
	public class Sha512Digest : LongDigest
	{
		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x5324500", Offset = "0x5323100", VA = "0x185324500")]
		public Sha512Digest()
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x5324550", Offset = "0x5323150", VA = "0x185324550")]
		public Sha512Digest(Sha512Digest t)
		{
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000410")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001EC2")]
			[Address(RVA = "0x53245B0", Offset = "0x53231B0", VA = "0x1853245B0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x3D28710", Offset = "0x3D27310", VA = "0x183D28710", Slot = "15")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x53242D0", Offset = "0x5322ED0", VA = "0x1853242D0", Slot = "16")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x5324470", Offset = "0x5323070", VA = "0x185324470", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x5324240", Offset = "0x5322E40", VA = "0x185324240", Slot = "17")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x53243C0", Offset = "0x5322FC0", VA = "0x1853243C0", Slot = "18")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		private const int DigestLength = 64;
	}
}
