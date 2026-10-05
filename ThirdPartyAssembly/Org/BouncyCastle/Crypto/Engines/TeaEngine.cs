using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034B RID: 843
	[Token(Token = "0x200034B")]
	public class TeaEngine : IBlockCipher
	{
		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x52ECAE0", Offset = "0x52EB6E0", VA = "0x1852ECAE0")]
		public TeaEngine()
		{
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F2")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x52ECCE0", Offset = "0x52EB8E0", VA = "0x1852ECCE0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0000DEF0 File Offset: 0x0000C0F0
		[Token(Token = "0x170003F3")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0000DF08 File Offset: 0x0000C108
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x52EC6A0", Offset = "0x52EB2A0", VA = "0x1852EC6A0", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0000DF20 File Offset: 0x0000C120
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x52EC890", Offset = "0x52EB490", VA = "0x1852EC890", Slot = "14")]
		public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x52ECD10", Offset = "0x52EB910", VA = "0x1852ECD10")]
		private void setKey(byte[] key)
		{
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x0000DF38 File Offset: 0x0000C138
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x52ECBF0", Offset = "0x52EB7F0", VA = "0x1852ECBF0")]
		private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x0000DF50 File Offset: 0x0000C150
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x52ECB00", Offset = "0x52EB700", VA = "0x1852ECB00")]
		private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		private const int rounds = 32;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		private const int block_size = 8;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		private const uint delta = 2654435769U;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		private const uint d_sum = 3337565984U;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0x10")]
		private uint _a;

		// Token: 0x04000F77 RID: 3959
		[Token(Token = "0x4000F77")]
		[FieldOffset(Offset = "0x14")]
		private uint _b;

		// Token: 0x04000F78 RID: 3960
		[Token(Token = "0x4000F78")]
		[FieldOffset(Offset = "0x18")]
		private uint _c;

		// Token: 0x04000F79 RID: 3961
		[Token(Token = "0x4000F79")]
		[FieldOffset(Offset = "0x1C")]
		private uint _d;

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		[FieldOffset(Offset = "0x20")]
		private bool _initialised;

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x21")]
		private bool _forEncryption;
	}
}
