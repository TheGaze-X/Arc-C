using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	public class Sha256Digest : GeneralDigest
	{
		// Token: 0x06001E9E RID: 7838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x5323760", Offset = "0x5322360", VA = "0x185323760")]
		public Sha256Digest()
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x53237F0", Offset = "0x53223F0", VA = "0x1853237F0")]
		public Sha256Digest(Sha256Digest t)
		{
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x53080B0", Offset = "0x5306CB0", VA = "0x1853080B0")]
		private void CopyIn(Sha256Digest t)
		{
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x53238E0", Offset = "0x53224E0", VA = "0x1853238E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0000EB20 File Offset: 0x0000CD20
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x5322570", Offset = "0x5321170", VA = "0x185322570", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x53224F0", Offset = "0x53210F0", VA = "0x1853224F0", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x5322B90", Offset = "0x5321790", VA = "0x185322B90", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x5323470", Offset = "0x5322070", VA = "0x185323470", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x5323910", Offset = "0x5322510", VA = "0x185323910")]
		private void initHs()
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x5322C80", Offset = "0x5321880", VA = "0x185322C80", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x5323680", Offset = "0x5322280", VA = "0x185323680")]
		private static uint Sum1Ch(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x5323630", Offset = "0x5322230", VA = "0x185323630")]
		private static uint Sum0Maj(uint x, uint y, uint z)
		{
			return 0U;
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x52BE9D0", Offset = "0x52BD5D0", VA = "0x1852BE9D0")]
		private static uint Theta0(uint x)
		{
			return 0U;
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x52BEA00", Offset = "0x52BD600", VA = "0x1852BEA00")]
		private static uint Theta1(uint x)
		{
			return 0U;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x5322A70", Offset = "0x5321670", VA = "0x185322A70", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x53234F0", Offset = "0x53220F0", VA = "0x1853234F0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x0400109C RID: 4252
		[Token(Token = "0x400109C")]
		private const int DigestLength = 32;

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x28")]
		private uint H1;

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x2C")]
		private uint H2;

		// Token: 0x0400109F RID: 4255
		[Token(Token = "0x400109F")]
		[FieldOffset(Offset = "0x30")]
		private uint H3;

		// Token: 0x040010A0 RID: 4256
		[Token(Token = "0x40010A0")]
		[FieldOffset(Offset = "0x34")]
		private uint H4;

		// Token: 0x040010A1 RID: 4257
		[Token(Token = "0x40010A1")]
		[FieldOffset(Offset = "0x38")]
		private uint H5;

		// Token: 0x040010A2 RID: 4258
		[Token(Token = "0x40010A2")]
		[FieldOffset(Offset = "0x3C")]
		private uint H6;

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0x40")]
		private uint H7;

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x44")]
		private uint H8;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x48")]
		private uint[] X;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x50")]
		private int xOff;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] K;
	}
}
