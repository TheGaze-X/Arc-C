using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000378 RID: 888
	[Token(Token = "0x2000378")]
	public class MD4Digest : GeneralDigest
	{
		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x52E3610", Offset = "0x52E2210", VA = "0x1852E3610")]
		public MD4Digest()
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x52E36D0", Offset = "0x52E22D0", VA = "0x1852E36D0")]
		public MD4Digest(MD4Digest t)
		{
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x52E2610", Offset = "0x52E1210", VA = "0x1852E2610")]
		private void CopyIn(MD4Digest t)
		{
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000404")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x52E3750", Offset = "0x52E2350", VA = "0x1852E3750", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x0000E418 File Offset: 0x0000C618
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x52E32F0", Offset = "0x52E1EF0", VA = "0x1852E32F0", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x52E3270", Offset = "0x52E1E70", VA = "0x1852E3270", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x52E35A0", Offset = "0x52E21A0", VA = "0x1852E35A0")]
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0000E430 File Offset: 0x0000C630
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x52E2770", Offset = "0x52E1370", VA = "0x1852E2770", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x52E3500", Offset = "0x52E2100", VA = "0x1852E3500", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0000E448 File Offset: 0x0000C648
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private int RotateLeft(int x, int n)
		{
			return 0;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0000E460 File Offset: 0x0000C660
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private int F(int u, int v, int w)
		{
			return 0;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0000E478 File Offset: 0x0000C678
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x4A9C1E0", Offset = "0x4A9ADE0", VA = "0x184A9C1E0")]
		private int G(int u, int v, int w)
		{
			return 0;
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0000E490 File Offset: 0x0000C690
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private int H(int u, int v, int w)
		{
			return 0;
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x52E2930", Offset = "0x52E1530", VA = "0x1852E2930", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x52E26C0", Offset = "0x52E12C0", VA = "0x1852E26C0", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x52E33C0", Offset = "0x52E1FC0", VA = "0x1852E33C0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		private const int DigestLength = 16;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x28")]
		private int H1;

		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		[FieldOffset(Offset = "0x2C")]
		private int H2;

		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		[FieldOffset(Offset = "0x30")]
		private int H3;

		// Token: 0x04001036 RID: 4150
		[Token(Token = "0x4001036")]
		[FieldOffset(Offset = "0x34")]
		private int H4;

		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		[FieldOffset(Offset = "0x38")]
		private int[] X;

		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		[FieldOffset(Offset = "0x40")]
		private int xOff;

		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		private const int S11 = 3;

		// Token: 0x0400103A RID: 4154
		[Token(Token = "0x400103A")]
		private const int S12 = 7;

		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		private const int S13 = 11;

		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		private const int S14 = 19;

		// Token: 0x0400103D RID: 4157
		[Token(Token = "0x400103D")]
		private const int S21 = 3;

		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		private const int S22 = 5;

		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		private const int S23 = 9;

		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		private const int S24 = 13;

		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		private const int S31 = 3;

		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		private const int S32 = 9;

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		private const int S33 = 11;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		private const int S34 = 15;
	}
}
