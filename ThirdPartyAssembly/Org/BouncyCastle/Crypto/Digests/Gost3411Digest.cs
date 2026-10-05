using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public class Gost3411Digest : IDigest, IMemoable
	{
		// Token: 0x06001D94 RID: 7572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x52DB640", Offset = "0x52DA240", VA = "0x1852DB640")]
		private static byte[][] MakeC()
		{
			return null;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x52DC3C0", Offset = "0x52DAFC0", VA = "0x1852DC3C0")]
		public Gost3411Digest()
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x52DBE10", Offset = "0x52DAA10", VA = "0x1852DBE10")]
		public Gost3411Digest(byte[] sBoxParam)
		{
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x52DC130", Offset = "0x52DAD30", VA = "0x1852DC130")]
		public Gost3411Digest(Gost3411Digest t)
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000400")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001D98")]
			[Address(RVA = "0x52DCA70", Offset = "0x52DB670", VA = "0x1852DCA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0000E280 File Offset: 0x0000C480
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "5")]
		public int GetDigestSize()
		{
			return 0;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9A")]
		[Address(RVA = "0x52DBCB0", Offset = "0x52DA8B0", VA = "0x1852DBCB0", Slot = "7")]
		public void Update(byte input)
		{
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9B")]
		[Address(RVA = "0x52DB240", Offset = "0x52D9E40", VA = "0x1852DB240", Slot = "8")]
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9C")]
		[Address(RVA = "0x52DB720", Offset = "0x52DA320", VA = "0x1852DB720")]
		private byte[] P(byte[] input)
		{
			return null;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D9D")]
		[Address(RVA = "0x52DB180", Offset = "0x52D9D80", VA = "0x1852DB180")]
		private byte[] A(byte[] input)
		{
			return null;
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9E")]
		[Address(RVA = "0x52DB4D0", Offset = "0x52DA0D0", VA = "0x1852DB4D0")]
		private void E(byte[] key, byte[] s, int sOff, byte[] input, int inOff)
		{
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D9F")]
		[Address(RVA = "0x52DC880", Offset = "0x52DB480", VA = "0x1852DC880")]
		private void fw(byte[] input)
		{
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA0")]
		[Address(RVA = "0x52DCAA0", Offset = "0x52DB6A0", VA = "0x1852DCAA0")]
		private void processBlock(byte[] input, int inOff)
		{
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA1")]
		[Address(RVA = "0x52DC820", Offset = "0x52DB420", VA = "0x1852DC820")]
		private void finish()
		{
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x0000E298 File Offset: 0x0000C498
		[Token(Token = "0x6001DA2")]
		[Address(RVA = "0x52DB420", Offset = "0x52DA020", VA = "0x1852DB420", Slot = "9")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA3")]
		[Address(RVA = "0x52DB810", Offset = "0x52DA410", VA = "0x1852DB810", Slot = "10")]
		public void Reset()
		{
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA4")]
		[Address(RVA = "0x52DD0F0", Offset = "0x52DBCF0", VA = "0x1852DD0F0")]
		private void sumByteArray(byte[] input)
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA5")]
		[Address(RVA = "0x52DC700", Offset = "0x52DB300", VA = "0x1852DC700")]
		private static void cpyBytesToShort(byte[] S, short[] wS)
		{
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA6")]
		[Address(RVA = "0x52DC790", Offset = "0x52DB390", VA = "0x1852DC790")]
		private static void cpyShortToBytes(short[] wS, byte[] S)
		{
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[Token(Token = "0x6001DA7")]
		[Address(RVA = "0x3D28750", Offset = "0x3D27350", VA = "0x183D28750", Slot = "6")]
		public int GetByteLength()
		{
			return 0;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DA8")]
		[Address(RVA = "0x52DB3C0", Offset = "0x52D9FC0", VA = "0x1852DB3C0", Slot = "11")]
		public IMemoable Copy()
		{
			return null;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DA9")]
		[Address(RVA = "0x52DB990", Offset = "0x52DA590", VA = "0x1852DB990", Slot = "12")]
		public void Reset(IMemoable other)
		{
		}

		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		private const int DIGEST_LENGTH = 32;

		// Token: 0x04000FF8 RID: 4088
		[Token(Token = "0x4000FF8")]
		[FieldOffset(Offset = "0x10")]
		private byte[] H;

		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		[FieldOffset(Offset = "0x18")]
		private byte[] L;

		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		[FieldOffset(Offset = "0x20")]
		private byte[] M;

		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		[FieldOffset(Offset = "0x28")]
		private byte[] Sum;

		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		[FieldOffset(Offset = "0x30")]
		private byte[][] C;

		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		[FieldOffset(Offset = "0x38")]
		private byte[] xBuf;

		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		[FieldOffset(Offset = "0x40")]
		private int xBufOff;

		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		[FieldOffset(Offset = "0x48")]
		private ulong byteCount;

		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		[FieldOffset(Offset = "0x50")]
		private readonly IBlockCipher cipher;

		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		[FieldOffset(Offset = "0x58")]
		private byte[] sBox;

		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		[FieldOffset(Offset = "0x60")]
		private byte[] K;

		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		[FieldOffset(Offset = "0x68")]
		private byte[] a;

		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		[FieldOffset(Offset = "0x70")]
		internal short[] wS;

		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		[FieldOffset(Offset = "0x78")]
		internal short[] w_S;

		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		[FieldOffset(Offset = "0x80")]
		internal byte[] S;

		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		[FieldOffset(Offset = "0x88")]
		internal byte[] U;

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x90")]
		internal byte[] V;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x98")]
		internal byte[] W;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] C2;
	}
}
