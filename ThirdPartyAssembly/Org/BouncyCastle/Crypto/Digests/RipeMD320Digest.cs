using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037E RID: 894
	[Token(Token = "0x200037E")]
	public class RipeMD320Digest : GeneralDigest
	{
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040A")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E69")]
			[Address(RVA = "0x530D4C0", Offset = "0x530C0C0", VA = "0x18530D4C0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0000E928 File Offset: 0x0000CB28
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x5000370", Offset = "0x4FFEF70", VA = "0x185000370", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x530D340", Offset = "0x530BF40", VA = "0x18530D340")]
		public RipeMD320Digest()
		{
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x530D3C0", Offset = "0x530BFC0", VA = "0x18530D3C0")]
		public RipeMD320Digest(RipeMD320Digest t)
		{
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x530A1C0", Offset = "0x5308DC0", VA = "0x18530A1C0")]
		private void CopyIn(RipeMD320Digest t)
		{
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x530D080", Offset = "0x530BC80", VA = "0x18530D080", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x530D000", Offset = "0x530BC00", VA = "0x18530D000", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x52E35A0", Offset = "0x52E21A0", VA = "0x1852E35A0")]
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0000E940 File Offset: 0x0000CB40
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x530A390", Offset = "0x5308F90", VA = "0x18530A390", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x530D150", Offset = "0x530BD50", VA = "0x18530D150", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0000E958 File Offset: 0x0000CB58
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private int RL(int x, int n)
		{
			return 0;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0000E970 File Offset: 0x0000CB70
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private int F1(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0000E988 File Offset: 0x0000CB88
		[Token(Token = "0x6001E75")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private int F2(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x5303420", Offset = "0x5302020", VA = "0x185303420")]
		private int F3(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x53034B0", Offset = "0x53020B0", VA = "0x1853034B0")]
		private int F4(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x53053A0", Offset = "0x5303FA0", VA = "0x1853053A0")]
		private int F5(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E79")]
		[Address(RVA = "0x530A760", Offset = "0x5309360", VA = "0x18530A760", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E7A")]
		[Address(RVA = "0x530A260", Offset = "0x5308E60", VA = "0x18530A260", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E7B")]
		[Address(RVA = "0x530D200", Offset = "0x530BE00", VA = "0x18530D200", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		private const int DigestLength = 40;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0x28")]
		private int H0;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0x2C")]
		private int H1;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0x30")]
		private int H2;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x400107B")]
		[FieldOffset(Offset = "0x34")]
		private int H3;

		// Token: 0x0400107C RID: 4220
		[Token(Token = "0x400107C")]
		[FieldOffset(Offset = "0x38")]
		private int H4;

		// Token: 0x0400107D RID: 4221
		[Token(Token = "0x400107D")]
		[FieldOffset(Offset = "0x3C")]
		private int H5;

		// Token: 0x0400107E RID: 4222
		[Token(Token = "0x400107E")]
		[FieldOffset(Offset = "0x40")]
		private int H6;

		// Token: 0x0400107F RID: 4223
		[Token(Token = "0x400107F")]
		[FieldOffset(Offset = "0x44")]
		private int H7;

		// Token: 0x04001080 RID: 4224
		[Token(Token = "0x4001080")]
		[FieldOffset(Offset = "0x48")]
		private int H8;

		// Token: 0x04001081 RID: 4225
		[Token(Token = "0x4001081")]
		[FieldOffset(Offset = "0x4C")]
		private int H9;

		// Token: 0x04001082 RID: 4226
		[Token(Token = "0x4001082")]
		[FieldOffset(Offset = "0x50")]
		private int[] X;

		// Token: 0x04001083 RID: 4227
		[Token(Token = "0x4001083")]
		[FieldOffset(Offset = "0x58")]
		private int xOff;
	}
}
