using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	public sealed class BlowfishEngine : IBlockCipher
	{
		// Token: 0x06001B25 RID: 6949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x52A1200", Offset = "0x529FE00", VA = "0x1852A1200")]
		public BlowfishEngine()
		{
		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x52A0710", Offset = "0x529F310", VA = "0x1852A0710", Slot = "5")]
		public void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C4")]
		public string AlgorithmName
		{
			[Token(Token = "0x6001B27")]
			[Address(RVA = "0x52A1340", Offset = "0x529FF40", VA = "0x1852A1340", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x170003C5")]
		public bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B28")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x52A0940", Offset = "0x529F540", VA = "0x1852A0940", Slot = "8")]
		public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void Reset()
		{
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "6")]
		public int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x52A0680", Offset = "0x529F280", VA = "0x1852A0680")]
		private uint F(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x52A0A70", Offset = "0x529F670", VA = "0x1852A0A70")]
		private void ProcessTable(uint xl, uint xr, uint[] table)
		{
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x52A0C30", Offset = "0x529F830", VA = "0x1852A0C30")]
		private void SetKey(byte[] key)
		{
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x52A0410", Offset = "0x529F010", VA = "0x1852A0410")]
		private void EncryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x52A01C0", Offset = "0x529EDC0", VA = "0x1852A01C0")]
		private void DecryptBlock(byte[] src, int srcIndex, byte[] dst, int dstIndex)
		{
		}

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] KP;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] KS0;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint[] KS1;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] KS2;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] KS3;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int ROUNDS;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		private const int BLOCK_SIZE = 8;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int SBOX_SK;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int P_SZ;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x10")]
		private readonly uint[] S0;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x18")]
		private readonly uint[] S1;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x20")]
		private readonly uint[] S2;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x28")]
		private readonly uint[] S3;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x30")]
		private readonly uint[] P;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x38")]
		private bool encrypting;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x40")]
		private byte[] workingKey;
	}
}
