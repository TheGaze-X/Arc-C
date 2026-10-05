using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200034F RID: 847
	[Token(Token = "0x200034F")]
	public class XteaEngine : IBlockCipher
	{
		// Token: 0x06001CE6 RID: 7398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x52F07C0", Offset = "0x52EF3C0", VA = "0x1852F07C0")]
		public XteaEngine()
		{
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003F8")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001CE7")]
			[Address(RVA = "0x52F0A60", Offset = "0x52EF660", VA = "0x1852F0A60", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x170003F9")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001CE8")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x0000E130 File Offset: 0x0000C330
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x5586F0", Offset = "0x5572F0", VA = "0x1805586F0", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x52F02A0", Offset = "0x52EEEA0", VA = "0x1852F02A0", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x0000E148 File Offset: 0x0000C348
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x52F0530", Offset = "0x52EF130", VA = "0x1852F0530", Slot = "14")]
		public virtual int ProcessBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x52F0A90", Offset = "0x52EF690", VA = "0x1852F0A90")]
		private void setKey(byte[] key)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x0000E160 File Offset: 0x0000C360
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x52F0960", Offset = "0x52EF560", VA = "0x1852F0960")]
		private int encryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x0000E178 File Offset: 0x0000C378
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x52F0860", Offset = "0x52EF460", VA = "0x1852F0860")]
		private int decryptBlock(byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		private const int rounds = 32;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		private const int block_size = 8;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		private const int delta = -1640531527;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x10")]
		private uint[] _S;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x18")]
		private uint[] _sum0;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x20")]
		private uint[] _sum1;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialised;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x29")]
		private bool _forEncryption;
	}
}
