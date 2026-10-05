using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x0200037C RID: 892
	[Token(Token = "0x200037C")]
	public class RipeMD160Digest : GeneralDigest
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x5307F20", Offset = "0x5306B20", VA = "0x185307F20")]
		public RipeMD160Digest()
		{
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x5307FA0", Offset = "0x5306BA0", VA = "0x185307FA0")]
		public RipeMD160Digest(RipeMD160Digest t)
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x5305000", Offset = "0x5303C00", VA = "0x185305000")]
		private void CopyIn(RipeMD160Digest t)
		{
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000408")]
		public override string AlgorithmName
		{
			[Token(Token = "0x6001E3F")]
			[Address(RVA = "0x5308080", Offset = "0x5306C80", VA = "0x185308080", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000E700 File Offset: 0x0000C900
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x3D286E0", Offset = "0x3D272E0", VA = "0x183D286E0", Slot = "18")]
		public override int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x5307CA0", Offset = "0x53068A0", VA = "0x185307CA0", Slot = "14")]
		internal override void ProcessWord(byte[] input, int inOff)
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x5307C20", Offset = "0x5306820", VA = "0x185307C20", Slot = "15")]
		internal override void ProcessLength(long bitLength)
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x52E35A0", Offset = "0x52E21A0", VA = "0x1852E35A0")]
		private void UnpackWord(int word, byte[] outBytes, int outOff)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x0000E718 File Offset: 0x0000C918
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x5305190", Offset = "0x5303D90", VA = "0x185305190", Slot = "19")]
		public override int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x5307D70", Offset = "0x5306970", VA = "0x185307D70", Slot = "13")]
		public override void Reset()
		{
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x0000E730 File Offset: 0x0000C930
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private int RL(int x, int n)
		{
			return 0;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0000E748 File Offset: 0x0000C948
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x4A9C240", Offset = "0x4A9AE40", VA = "0x184A9C240")]
		private int F1(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x0000E760 File Offset: 0x0000C960
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x4A9C180", Offset = "0x4A9AD80", VA = "0x184A9C180")]
		private int F2(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x0000E778 File Offset: 0x0000C978
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x5303420", Offset = "0x5302020", VA = "0x185303420")]
		private int F3(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x53034B0", Offset = "0x53020B0", VA = "0x1853034B0")]
		private int F4(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x53053A0", Offset = "0x5303FA0", VA = "0x1853053A0")]
		private int F5(int x, int y, int z)
		{
			return 0;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x53053B0", Offset = "0x5303FB0", VA = "0x1853053B0", Slot = "16")]
		internal override void ProcessBlock()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x5305080", Offset = "0x5303C80", VA = "0x185305080", Slot = "20")]
		public override IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x5307E00", Offset = "0x5306A00", VA = "0x185307E00", Slot = "21")]
		public override void Reset(IMemoable other)
		{
		}

		// Token: 0x04001064 RID: 4196
		[Token(Token = "0x4001064")]
		private const int DigestLength = 20;

		// Token: 0x04001065 RID: 4197
		[Token(Token = "0x4001065")]
		[FieldOffset(Offset = "0x28")]
		private int H0;

		// Token: 0x04001066 RID: 4198
		[Token(Token = "0x4001066")]
		[FieldOffset(Offset = "0x2C")]
		private int H1;

		// Token: 0x04001067 RID: 4199
		[Token(Token = "0x4001067")]
		[FieldOffset(Offset = "0x30")]
		private int H2;

		// Token: 0x04001068 RID: 4200
		[Token(Token = "0x4001068")]
		[FieldOffset(Offset = "0x34")]
		private int H3;

		// Token: 0x04001069 RID: 4201
		[Token(Token = "0x4001069")]
		[FieldOffset(Offset = "0x38")]
		private int H4;

		// Token: 0x0400106A RID: 4202
		[Token(Token = "0x400106A")]
		[FieldOffset(Offset = "0x40")]
		private int[] X;

		// Token: 0x0400106B RID: 4203
		[Token(Token = "0x400106B")]
		[FieldOffset(Offset = "0x48")]
		private int xOff;
	}
}
