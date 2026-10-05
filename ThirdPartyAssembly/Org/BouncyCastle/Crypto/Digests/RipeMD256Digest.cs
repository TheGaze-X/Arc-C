using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037D RID: 893
	[Token(Token = "0x200037D")]
	public class RipeMD256Digest : GeneralDigest
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000409")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E4F")]
			[Address(RVA = "0x530A190", Offset = "0x5308D90", VA = "0x18530A190", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0000E7C0 File Offset: 0x0000C9C0
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x530A110", Offset = "0x5308D10", VA = "0x18530A110")]
		public RipeMD256Digest()
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x530A020", Offset = "0x5308C20", VA = "0x18530A020")]
		public RipeMD256Digest(RipeMD256Digest t)
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x53080B0", Offset = "0x5306CB0", VA = "0x1853080B0")]
		private void CopyIn(RipeMD256Digest t)
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x5309D70", Offset = "0x5308970", VA = "0x185309D70", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x5309CF0", Offset = "0x53088F0", VA = "0x185309CF0", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x52E35A0", Offset = "0x52E21A0", VA = "0x1852E35A0")]
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x5308260", Offset = "0x5306E60", VA = "0x185308260", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x5309E40", Offset = "0x5308A40", VA = "0x185309E40", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private int RL(int x, int n)
		{
			return 0;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0000E808 File Offset: 0x0000CA08
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private int F1(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private int F2(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x5303420", Offset = "0x5302020", VA = "0x185303420")]
		private int F3(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x53034B0", Offset = "0x53020B0", VA = "0x1853034B0")]
		private int F4(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x53033B0", Offset = "0x5301FB0", VA = "0x1853033B0")]
		private int F1(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x53033E0", Offset = "0x5301FE0", VA = "0x1853033E0")]
		private int F2(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x5303430", Offset = "0x5302030", VA = "0x185303430")]
		private int F3(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x5303470", Offset = "0x5302070", VA = "0x185303470")]
		private int F4(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x53033B0", Offset = "0x5301FB0", VA = "0x1853033B0")]
		private int FF1(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x53034C0", Offset = "0x53020C0", VA = "0x1853034C0")]
		private int FF2(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x5303500", Offset = "0x5302100", VA = "0x185303500")]
		private int FF3(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0000E910 File Offset: 0x0000CB10
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x5303540", Offset = "0x5302140", VA = "0x185303540")]
		private int FF4(int a, int b, int c, int d, int x, int s)
		{
			return 0;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x5308580", Offset = "0x5307180", VA = "0x185308580", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x5308140", Offset = "0x5306D40", VA = "0x185308140", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x5309EE0", Offset = "0x5308AE0", VA = "0x185309EE0", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x0400106C RID: 4204
		[Token(Token = "0x400106C")]
		private const int DigestLength = 32;

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x28")]
		private int H0;

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x2C")]
		private int H1;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x30")]
		private int H2;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x34")]
		private int H3;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x38")]
		private int H4;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x3C")]
		private int H5;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0x40")]
		private int H6;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x44")]
		private int H7;

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x48")]
		private int[] X;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x50")]
		private int xOff;
	}
}
