using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public class RipeMD128Digest : GeneralDigest
	{
		// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x5304F50", Offset = "0x5303B50", VA = "0x185304F50")]
		public RipeMD128Digest()
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x5304E80", Offset = "0x5303A80", VA = "0x185304E80")]
		public RipeMD128Digest(RipeMD128Digest t)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x5303220", Offset = "0x5301E20", VA = "0x185303220")]
		private void CopyIn(RipeMD128Digest t)
		{
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000407")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x5304FD0", Offset = "0x5303BD0", VA = "0x185304FD0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0000E598 File Offset: 0x0000C798
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x52E32F0", Offset = "0x52E1EF0", VA = "0x1852E32F0", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x52E3270", Offset = "0x52E1E70", VA = "0x1852E3270", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x52E35A0", Offset = "0x52E21A0", VA = "0x1852E35A0")]
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x52E2770", Offset = "0x52E1370", VA = "0x1852E2770", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x5304E00", Offset = "0x5303A00", VA = "0x185304E00", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private int RL(int x, int n)
		{
			return 0;
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private int F1(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0000E5F8 File Offset: 0x0000C7F8
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private int F2(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0000E610 File Offset: 0x0000C810
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x5303420", Offset = "0x5302020", VA = "0x185303420")]
		private int F3(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0000E628 File Offset: 0x0000C828
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x53034B0", Offset = "0x53020B0", VA = "0x1853034B0")]
		private int F4(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0000E640 File Offset: 0x0000C840
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x53033B0", Offset = "0x5301FB0", VA = "0x1853033B0")]
		private int F1(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0000E658 File Offset: 0x0000C858
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x53033E0", Offset = "0x5301FE0", VA = "0x1853033E0")]
		private int F2(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0000E670 File Offset: 0x0000C870
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x5303430", Offset = "0x5302030", VA = "0x185303430")]
		private int F3(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0000E688 File Offset: 0x0000C888
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x5303470", Offset = "0x5302070", VA = "0x185303470")]
		private int F4(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x53033B0", Offset = "0x5301FB0", VA = "0x1853033B0")]
		private int FF1(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x53034C0", Offset = "0x53020C0", VA = "0x1853034C0")]
		private int FF2(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0000E6D0 File Offset: 0x0000C8D0
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x5303500", Offset = "0x5302100", VA = "0x185303500")]
		private int FF3(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0000E6E8 File Offset: 0x0000C8E8
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x5303540", Offset = "0x5302140", VA = "0x185303540")]
		private int FF4(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x5303580", Offset = "0x5302180", VA = "0x185303580", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x53032A0", Offset = "0x5301EA0", VA = "0x1853032A0", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x5304CE0", Offset = "0x53038E0", VA = "0x185304CE0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		private const int DigestLength = 16;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x28")]
		private int H0;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x2C")]
		private int H1;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x30")]
		private int H2;

		// Token: 0x04001061 RID: 4193
		[Token(Token = "0x4001061")]
		[FieldOffset(Offset = "0x34")]
		private int H3;

		// Token: 0x04001062 RID: 4194
		[Token(Token = "0x4001062")]
		[FieldOffset(Offset = "0x38")]
		private int[] X;

		// Token: 0x04001063 RID: 4195
		[Token(Token = "0x4001063")]
		[FieldOffset(Offset = "0x40")]
		private int xOff;
	}
}
