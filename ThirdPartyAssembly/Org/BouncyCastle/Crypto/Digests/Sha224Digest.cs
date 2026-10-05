using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000380 RID: 896
	[Token(Token = "0x2000380")]
	public class Sha224Digest : GeneralDigest
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x53229C0", Offset = "0x53215C0", VA = "0x1853229C0")]
		public Sha224Digest()
		{
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x53228D0", Offset = "0x53214D0", VA = "0x1853228D0")]
		public Sha224Digest(Sha224Digest t)
		{
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x53080B0", Offset = "0x5306CB0", VA = "0x1853080B0")]
		private void CopyIn(Sha224Digest t)
		{
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040C")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E8E")]
			[Address(RVA = "0x5322A40", Offset = "0x5321640", VA = "0x185322A40", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x3D28720", Offset = "0x3D27320", VA = "0x183D28720", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x5322570", Offset = "0x5321170", VA = "0x185322570", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x53224F0", Offset = "0x53210F0", VA = "0x1853224F0", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x5321C20", Offset = "0x5320820", VA = "0x185321C20", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x5322740", Offset = "0x5321340", VA = "0x185322740", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x5321D00", Offset = "0x5320900", VA = "0x185321D00", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x4B4A4F0", Offset = "0x4B490F0", VA = "0x184B4A4F0")]
		private static uint Ch(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x4B4A660", Offset = "0x4B49260", VA = "0x184B4A660")]
		private static uint Maj(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x53227C0", Offset = "0x53213C0", VA = "0x1853227C0")]
		private static uint Sum0(uint x)
		{
			return 0U;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x5322800", Offset = "0x5321400", VA = "0x185322800")]
		private static uint Sum1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x52BE9D0", Offset = "0x52BD5D0", VA = "0x1852BE9D0")]
		private static uint Theta0(uint x)
		{
			return 0U;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x52BEA00", Offset = "0x52BD600", VA = "0x1852BEA00")]
		private static uint Theta1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x5321B00", Offset = "0x5320700", VA = "0x185321B00", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x5322600", Offset = "0x5321200", VA = "0x185322600", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001090 RID: 4240
		[Token(Token = "0x4001090")]
		private const int DigestLength = 28;

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4001091")]
		[FieldOffset(Offset = "0x28")]
		private uint H1;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4001092")]
		[FieldOffset(Offset = "0x2C")]
		private uint H2;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4001093")]
		[FieldOffset(Offset = "0x30")]
		private uint H3;

		// Token: 0x04001094 RID: 4244
		[Token(Token = "0x4001094")]
		[FieldOffset(Offset = "0x34")]
		private uint H4;

		// Token: 0x04001095 RID: 4245
		[Token(Token = "0x4001095")]
		[FieldOffset(Offset = "0x38")]
		private uint H5;

		// Token: 0x04001096 RID: 4246
		[Token(Token = "0x4001096")]
		[FieldOffset(Offset = "0x3C")]
		private uint H6;

		// Token: 0x04001097 RID: 4247
		[Token(Token = "0x4001097")]
		[FieldOffset(Offset = "0x40")]
		private uint H7;

		// Token: 0x04001098 RID: 4248
		[Token(Token = "0x4001098")]
		[FieldOffset(Offset = "0x44")]
		private uint H8;

		// Token: 0x04001099 RID: 4249
		[Token(Token = "0x4001099")]
		[FieldOffset(Offset = "0x48")]
		private uint[] X;

		// Token: 0x0400109A RID: 4250
		[Token(Token = "0x400109A")]
		[FieldOffset(Offset = "0x50")]
		private int xOff;

		// Token: 0x0400109B RID: 4251
		[Token(Token = "0x400109B")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly uint[] K;
	}
}
