using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	public class AesEngine : IBlockCipher
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		private static uint Shift(uint r, int shift)
		{
			return 0U;
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x529BE50", Offset = "0x529AA50", VA = "0x18529BE50")]
		private static uint FFmulX(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x529BE20", Offset = "0x529AA20", VA = "0x18529BE20")]
		private static uint FFmulX2(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x529CEA0", Offset = "0x529BAA0", VA = "0x18529CEA0")]
		private static uint Inv_Mcol(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x529D170", Offset = "0x529BD70", VA = "0x18529D170")]
		private static uint SubWord(uint x)
		{
			return 0U;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x529BE70", Offset = "0x529AA70", VA = "0x18529BE70")]
		private uint[][] GenerateWorkingKey(byte[] key, bool forEncryption)
		{
			return null;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AesEngine()
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x529CD50", Offset = "0x529B950", VA = "0x18529CD50", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C0")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B08")]
			[Address(RVA = "0x529D4B0", Offset = "0x529C0B0", VA = "0x18529D4B0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x170003C1")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B09")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x6001B0B")]
		[Address(RVA = "0x529CFC0", Offset = "0x529BBC0", VA = "0x18529CFC0", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x529D230", Offset = "0x529BE30", VA = "0x18529D230")]
		private void UnPackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x529CF50", Offset = "0x529BB50", VA = "0x18529CF50")]
		private void PackBlock(byte[] bytes, int off)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x529B2F0", Offset = "0x5299EF0", VA = "0x18529B2F0")]
		private void EncryptBlock(uint[][] KW)
		{
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x529A7D0", Offset = "0x52993D0", VA = "0x18529A7D0")]
		private void DecryptBlock(uint[][] KW)
		{
		}

		// Token: 0x04000E55 RID: 3669
		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x0")]
		private static readonly byte[] S;

		// Token: 0x04000E56 RID: 3670
		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] Si;

		// Token: 0x04000E57 RID: 3671
		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] rcon;

		// Token: 0x04000E58 RID: 3672
		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] T0;

		// Token: 0x04000E59 RID: 3673
		[Token(Token = "0x4000E59")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] Tinv0;

		// Token: 0x04000E5A RID: 3674
		[Token(Token = "0x4000E5A")]
		private const uint m1 = 2155905152U;

		// Token: 0x04000E5B RID: 3675
		[Token(Token = "0x4000E5B")]
		private const uint m2 = 2139062143U;

		// Token: 0x04000E5C RID: 3676
		[Token(Token = "0x4000E5C")]
		private const uint m3 = 27U;

		// Token: 0x04000E5D RID: 3677
		[Token(Token = "0x4000E5D")]
		private const uint m4 = 3233857728U;

		// Token: 0x04000E5E RID: 3678
		[Token(Token = "0x4000E5E")]
		private const uint m5 = 1061109567U;

		// Token: 0x04000E5F RID: 3679
		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x10")]
		private int ROUNDS;

		// Token: 0x04000E60 RID: 3680
		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x18")]
		private uint[][] WorkingKey;

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x20")]
		private uint C0;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x24")]
		private uint C1;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x28")]
		private uint C2;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x2C")]
		private uint C3;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x30")]
		private bool forEncryption;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		private const int BLOCK_SIZE = 16;
	}
}
