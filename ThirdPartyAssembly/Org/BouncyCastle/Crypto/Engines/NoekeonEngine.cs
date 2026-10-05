using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	public class NoekeonEngine : IBlockCipher
	{
		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x52C2FF0", Offset = "0x52C1BF0", VA = "0x1852C2FF0")]
		public NoekeonEngine()
		{
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D9")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x52C3DF0", Offset = "0x52C29F0", VA = "0x1852C3DF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0000D770 File Offset: 0x0000B970
		[Token(Token = "0x170003DA")]
		public virtual bool IsPartialBlockOkay
		{
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0000D788 File Offset: 0x0000B988
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "12")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x52C2B70", Offset = "0x52C1770", VA = "0x1852C2B70", Slot = "13")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x52C2DD0", Offset = "0x52C19D0", VA = "0x1852C2DD0", Slot = "14")]
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x52C3F00", Offset = "0x52C2B00", VA = "0x1852C3F00")]
		private void setKey(byte[] key)
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x52C3780", Offset = "0x52C2380", VA = "0x1852C3780")]
		private int encryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x52C3090", Offset = "0x52C1C90", VA = "0x1852C3090")]
		private int decryptBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x52C3D30", Offset = "0x52C2930", VA = "0x1852C3D30")]
		private void gamma(uint[] a)
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x52C3FC0", Offset = "0x52C2BC0", VA = "0x1852C3FC0")]
		private void theta(uint[] a, uint[] k)
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x52C3E20", Offset = "0x52C2A20", VA = "0x1852C3E20")]
		private void pi1(uint[] a)
		{
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x52C3E80", Offset = "0x52C2A80", VA = "0x1852C3E80")]
		private void pi2(uint[] a)
		{
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x52C3EE0", Offset = "0x52C2AE0", VA = "0x1852C3EE0")]
		private uint rotl(uint x, int y)
		{
			return 0U;
		}

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		private const int GenericSize = 16;

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly uint[] nullVector;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint[] roundConstants;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0x10")]
		private uint[] state;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0x18")]
		private uint[] subKeys;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x20")]
		private uint[] decryptKeys;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialised;

		// Token: 0x04000F02 RID: 3842
		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x29")]
		private bool _forEncryption;
	}
}
