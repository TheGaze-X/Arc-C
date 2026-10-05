using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	public class AesFastEngine : IBlockCipher
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static uint Shift(uint r, int shift)
		{
			return 0U;
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x529BE50", Offset = "0x529AA50", VA = "0x18529BE50")]
		private static uint FFmulX(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x529BE20", Offset = "0x529AA20", VA = "0x18529BE20")]
		private static uint FFmulX2(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x529F9B0", Offset = "0x529E5B0", VA = "0x18529F9B0")]
		private static uint Inv_Mcol(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x529FC10", Offset = "0x529E810", VA = "0x18529FC10")]
		private static uint SubWord(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x529E980", Offset = "0x529D580", VA = "0x18529E980")]
		private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
		{
			return null;
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AesFastEngine()
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x529F860", Offset = "0x529E460", VA = "0x18529F860", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C2")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B1A")]
			[Address(RVA = "0x52A0120", Offset = "0x529ED20", VA = "0x1852A0120", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x170003C3")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B1B")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0000D158 File Offset: 0x0000B358
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0000D170 File Offset: 0x0000B370
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x529FA60", Offset = "0x529E660", VA = "0x18529FA60", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x529D230", Offset = "0x529BE30", VA = "0x18529D230")]
		private void UnPackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x529CF50", Offset = "0x529BB50", VA = "0x18529CF50")]
		private void PackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x529DF30", Offset = "0x529CB30", VA = "0x18529DF30")]
		private void EncryptBlock(uint[][] KW)
		{
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x529D4E0", Offset = "0x529C0E0", VA = "0x18529D4E0")]
		private void DecryptBlock(uint[][] KW)
		{
		}

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] S;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] Si;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] rcon;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] T0;

		// Token: 0x04000E6B RID: 3691
		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] T1;

		// Token: 0x04000E6C RID: 3692
		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x28")]
		private static readonly uint[] T2;

		// Token: 0x04000E6D RID: 3693
		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x30")]
		private static readonly uint[] T3;

		// Token: 0x04000E6E RID: 3694
		[Token(Token = "0x4000E6E")]
		[FieldOffset(Offset = "0x38")]
		private static readonly uint[] Tinv0;

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		[FieldOffset(Offset = "0x40")]
		private static readonly uint[] Tinv1;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		[FieldOffset(Offset = "0x48")]
		private static readonly uint[] Tinv2;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		[FieldOffset(Offset = "0x50")]
		private static readonly uint[] Tinv3;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		private const uint m1 = 2155905152U;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		private const uint m2 = 2139062143U;

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		private const uint m3 = 27U;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		private const uint m4 = 3233857728U;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		private const uint m5 = 1061109567U;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x10")]
		private int ROUNDS;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x18")]
		private uint[][] WorkingKey;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x20")]
		private uint C0;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x24")]
		private uint C1;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x28")]
		private uint C2;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x2C")]
		private uint C3;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x30")]
		private bool forEncryption;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		private const int BLOCK_SIZE = 16;
	}
}
