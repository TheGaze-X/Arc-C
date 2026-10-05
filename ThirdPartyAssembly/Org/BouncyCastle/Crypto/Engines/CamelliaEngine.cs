using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200032A RID: 810
	[Token(Token = "0x200032A")]
	public class CamelliaEngine : IBlockCipher
	{
		// Token: 0x06001B32 RID: 6962 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x52B0580", Offset = "0x52AF180", VA = "0x1852B0580")]
		private static uint rightRotate(uint x, int s)
		{
			return 0U;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x52AFCD0", Offset = "0x52AE8D0", VA = "0x1852AFCD0")]
		private static uint leftRotate(uint x, int s)
		{
			return 0U;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x52B05A0", Offset = "0x52AF1A0", VA = "0x1852B05A0")]
		private static void roldq(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x52AF910", Offset = "0x52AE510", VA = "0x1852AF910")]
		private static void decroldq(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x52B0780", Offset = "0x52AF380", VA = "0x1852B0780")]
		private static void roldqo32(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x52AFAE0", Offset = "0x52AE6E0", VA = "0x1852AFAE0")]
		private static void decroldqo32(int rot, uint[] ki, int ioff, uint[] ko, int ooff)
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x52AF480", Offset = "0x52AE080", VA = "0x1852AF480")]
		private static uint bytes2uint(byte[] src, int offset)
		{
			return 0U;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x52B1FD0", Offset = "0x52B0BD0", VA = "0x1852B1FD0")]
		private static void uint2bytes(uint word, byte[] dst, int offset)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x52AF4D0", Offset = "0x52AE0D0", VA = "0x1852AF4D0")]
		private static void camelliaF2(uint[] s, uint[] skey, int keyoff)
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x52AF7F0", Offset = "0x52AE3F0", VA = "0x1852AF7F0")]
		private static void camelliaFLs(uint[] s, uint[] fkey, int keyoff)
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x52B0950", Offset = "0x52AF550", VA = "0x1852B0950")]
		private void setKey(bool forEncryption, byte[] key)
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x52AFCF0", Offset = "0x52AE8F0", VA = "0x1852AFCF0")]
		private int processBlock128(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x52B0110", Offset = "0x52AED10", VA = "0x1852B0110")]
		private int processBlock192or256(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x52AF3C0", Offset = "0x52ADFC0", VA = "0x1852AF3C0")]
		public CamelliaEngine()
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x52AEE90", Offset = "0x52ADA90", VA = "0x1852AEE90", Slot = "10")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003C6")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0x52AFCA0", Offset = "0x52AE8A0", VA = "0x1852AFCA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0000D260 File Offset: 0x0000B460
		[Token(Token = "0x170003C7")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001B42")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "13")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x52AF080", Offset = "0x52ADC80", VA = "0x1852AF080", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x10")]
		private bool initialised;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x11")]
		private bool _keyIs128;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		private const int BLOCK_SIZE = 16;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x18")]
		private uint[] subkey;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x20")]
		private uint[] kw;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x28")]
		private uint[] ke;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x30")]
		private uint[] state;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] SIGMA;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] SBOX1_1110;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x10")]
		private static readonly uint[] SBOX4_4404;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x18")]
		private static readonly uint[] SBOX2_0222;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x20")]
		private static readonly uint[] SBOX3_3033;
	}
}
