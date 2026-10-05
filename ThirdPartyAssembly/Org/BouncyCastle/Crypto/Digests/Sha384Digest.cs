using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000382 RID: 898
	[Token(Token = "0x2000382")]
	public class Sha384Digest : LongDigest
	{
		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x5323BF0", Offset = "0x53227F0", VA = "0x185323BF0")]
		public Sha384Digest()
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x5323C40", Offset = "0x5322840", VA = "0x185323C40")]
		public Sha384Digest(Sha384Digest t)
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040E")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x5323CA0", Offset = "0x53228A0", VA = "0x185323CA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x3D287C0", Offset = "0x3D273C0", VA = "0x183D287C0", Slot = "15")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x0000EBC8 File Offset: 0x0000CDC8
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x53239E0", Offset = "0x53225E0", VA = "0x1853239E0", Slot = "16")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x5323AB0", Offset = "0x53226B0", VA = "0x185323AB0", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x5323950", Offset = "0x5322550", VA = "0x185323950", Slot = "17")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x5323B40", Offset = "0x5322740", VA = "0x185323B40", Slot = "18")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		private const int DigestLength = 48;
	}
}
