using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Crypto.Modes.Gcm;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000307 RID: 775
	[Token(Token = "0x2000307")]
	public class GcmBlockCipher : IAeadBlockCipher
	{
		// Token: 0x060019D9 RID: 6617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019D9")]
		[Address(RVA = "0x528D5C0", Offset = "0x528C1C0", VA = "0x18528D5C0")]
		public GcmBlockCipher(IBlockCipher c)
		{
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DA")]
		[Address(RVA = "0x528D710", Offset = "0x528C310", VA = "0x18528D710")]
		public GcmBlockCipher(IBlockCipher c, IGcmMultiplier m)
		{
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AA")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x528DCA0", Offset = "0x528C8A0", VA = "0x18528DCA0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DC")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x60019DD")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "18")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019DE")]
		[Address(RVA = "0x528C770", Offset = "0x528B370", VA = "0x18528C770", Slot = "19")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019DF")]
		[Address(RVA = "0x528C4C0", Offset = "0x528B0C0", VA = "0x18528C4C0", Slot = "20")]
		public virtual byte[] GetMac()
		{
			return null;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x60019E0")]
		[Address(RVA = "0x528C650", Offset = "0x528B250", VA = "0x18528C650", Slot = "21")]
		public virtual int GetOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x60019E1")]
		[Address(RVA = "0x528C680", Offset = "0x528B280", VA = "0x18528C680", Slot = "22")]
		public virtual int GetUpdateOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E2")]
		[Address(RVA = "0x528D110", Offset = "0x528BD10", VA = "0x18528D110", Slot = "23")]
		public virtual void ProcessAadByte(byte input)
		{
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E3")]
		[Address(RVA = "0x528D190", Offset = "0x528BD90", VA = "0x18528D190", Slot = "24")]
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E4")]
		[Address(RVA = "0x528C6B0", Offset = "0x528B2B0", VA = "0x18528C6B0")]
		private void InitCipher()
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x60019E5")]
		[Address(RVA = "0x528D260", Offset = "0x528BE60", VA = "0x18528D260", Slot = "25")]
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x60019E6")]
		[Address(RVA = "0x528D2D0", Offset = "0x528BED0", VA = "0x18528D2D0", Slot = "26")]
		public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E7")]
		[Address(RVA = "0x528CFC0", Offset = "0x528BBC0", VA = "0x18528CFC0")]
		private void OutputBlock(byte[] output, int offset)
		{
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x60019E8")]
		[Address(RVA = "0x528BF10", Offset = "0x528AB10", VA = "0x18528BF10", Slot = "12")]
		public int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019E9")]
		[Address(RVA = "0x528D410", Offset = "0x528C010", VA = "0x18528D410", Slot = "27")]
		public virtual void Reset()
		{
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EA")]
		[Address(RVA = "0x528D420", Offset = "0x528C020", VA = "0x18528D420")]
		private void Reset(bool clearMac)
		{
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EB")]
		[Address(RVA = "0x528D860", Offset = "0x528C460", VA = "0x18528D860")]
		private void gCTRBlock(byte[] block, byte[] output, int outOff)
		{
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EC")]
		[Address(RVA = "0x528D930", Offset = "0x528C530", VA = "0x18528D930")]
		private void gCTRPartial(byte[] buf, int off, int len, byte[] output, int outOff)
		{
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019ED")]
		[Address(RVA = "0x528DB70", Offset = "0x528C770", VA = "0x18528DB70")]
		private void gHASH(byte[] Y, byte[] b, int len)
		{
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EE")]
		[Address(RVA = "0x528DA20", Offset = "0x528C620", VA = "0x18528DA20")]
		private void gHASHBlock(byte[] Y, byte[] b)
		{
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019EF")]
		[Address(RVA = "0x528DAC0", Offset = "0x528C6C0", VA = "0x18528DAC0")]
		private void gHASHPartial(byte[] Y, byte[] b, int off, int len)
		{
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019F0")]
		[Address(RVA = "0x528C4D0", Offset = "0x528B0D0", VA = "0x18528C4D0")]
		private byte[] GetNextCounterBlock()
		{
			return null;
		}

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		private const int BlockSize = 16;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x18")]
		private readonly IGcmMultiplier multiplier;

		// Token: 0x04000D91 RID: 3473
		[Token(Token = "0x4000D91")]
		[FieldOffset(Offset = "0x20")]
		private IGcmExponentiator exp;

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x28")]
		private bool forEncryption;

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x2C")]
		private int macSize;

		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x30")]
		private byte[] nonce;

		// Token: 0x04000D95 RID: 3477
		[Token(Token = "0x4000D95")]
		[FieldOffset(Offset = "0x38")]
		private byte[] initialAssociatedText;

		// Token: 0x04000D96 RID: 3478
		[Token(Token = "0x4000D96")]
		[FieldOffset(Offset = "0x40")]
		private byte[] H;

		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x48")]
		private byte[] J0;

		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x50")]
		private byte[] bufBlock;

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x58")]
		private byte[] macBlock;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x60")]
		private byte[] S;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x68")]
		private byte[] S_at;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x70")]
		private byte[] S_atPre;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x78")]
		private byte[] counter;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x80")]
		private uint blocksRemaining;

		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x84")]
		private int bufOff;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x88")]
		private ulong totalLength;

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x90")]
		private byte[] atBlock;

		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		[FieldOffset(Offset = "0x98")]
		private int atBlockPos;

		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		[FieldOffset(Offset = "0xA0")]
		private ulong atLength;

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0xA8")]
		private ulong atLengthPre;
	}
}
