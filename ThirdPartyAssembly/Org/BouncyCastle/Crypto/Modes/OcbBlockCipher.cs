using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200030A RID: 778
	[Token(Token = "0x200030A")]
	public class OcbBlockCipher : IAeadBlockCipher
	{
		// Token: 0x06001A08 RID: 6664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A08")]
		[Address(RVA = "0x52916E0", Offset = "0x52902E0", VA = "0x1852916E0")]
		public OcbBlockCipher(IBlockCipher hashCipher, IBlockCipher mainCipher)
		{
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A09")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "17")]
		public virtual IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AE")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x5291A60", Offset = "0x5290660", VA = "0x185291A60", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x52900D0", Offset = "0x528ECD0", VA = "0x1852900D0", Slot = "19")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x52910C0", Offset = "0x528FCC0", VA = "0x1852910C0", Slot = "20")]
		protected virtual int ProcessNonce(byte[] N)
		{
			return 0;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x3D286D0", Offset = "0x3D272D0", VA = "0x183D286D0", Slot = "21")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x5290060", Offset = "0x528EC60", VA = "0x185290060", Slot = "22")]
		public virtual byte[] GetMac()
		{
			return null;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x5290070", Offset = "0x528EC70", VA = "0x185290070", Slot = "23")]
		public virtual int GetOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x52900A0", Offset = "0x528ECA0", VA = "0x1852900A0", Slot = "24")]
		public virtual int GetUpdateOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x5290A90", Offset = "0x528F690", VA = "0x185290A90", Slot = "25")]
		public virtual void ProcessAadByte(byte input)
		{
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x5290B10", Offset = "0x528F710", VA = "0x185290B10", Slot = "26")]
		public virtual void ProcessAadBytes(byte[] input, int off, int len)
		{
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x5290BC0", Offset = "0x528F7C0", VA = "0x185290BC0", Slot = "27")]
		public virtual int ProcessByte(byte input, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6001A14")]
		[Address(RVA = "0x5290C70", Offset = "0x528F870", VA = "0x185290C70", Slot = "28")]
		public virtual int ProcessBytes(byte[] input, int inOff, int len, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6001A15")]
		[Address(RVA = "0x528F620", Offset = "0x528E220", VA = "0x18528F620", Slot = "29")]
		public virtual int DoFinal(byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A16")]
		[Address(RVA = "0x5291290", Offset = "0x528FE90", VA = "0x185291290", Slot = "30")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A17")]
		[Address(RVA = "0x528F600", Offset = "0x528E200", VA = "0x18528F600", Slot = "31")]
		protected virtual void Clear(byte[] bs)
		{
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A18")]
		[Address(RVA = "0x528FC30", Offset = "0x528E830", VA = "0x18528FC30", Slot = "32")]
		protected virtual byte[] GetLSub(int n)
		{
			return null;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A19")]
		[Address(RVA = "0x5290D40", Offset = "0x528F940", VA = "0x185290D40", Slot = "33")]
		protected virtual void ProcessHashBlock()
		{
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1A")]
		[Address(RVA = "0x5290DE0", Offset = "0x528F9E0", VA = "0x185290DE0", Slot = "34")]
		protected virtual void ProcessMainBlock(byte[] output, int outOff)
		{
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1B")]
		[Address(RVA = "0x52912D0", Offset = "0x528FED0", VA = "0x1852912D0", Slot = "35")]
		protected virtual void Reset(bool clearMac)
		{
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1C")]
		[Address(RVA = "0x5291540", Offset = "0x5290140", VA = "0x185291540", Slot = "36")]
		protected virtual void UpdateHASH(byte[] LSub)
		{
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A1D")]
		[Address(RVA = "0x5290950", Offset = "0x528F550", VA = "0x185290950")]
		protected static byte[] OCB_double(byte[] block)
		{
			return null;
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1E")]
		[Address(RVA = "0x5290A10", Offset = "0x528F610", VA = "0x185290A10")]
		protected static void OCB_extend(byte[] block, int pos)
		{
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x5290A60", Offset = "0x528F660", VA = "0x185290A60")]
		protected static int OCB_ntz(long x)
		{
			return 0;
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x52914D0", Offset = "0x52900D0", VA = "0x1852914D0")]
		protected static int ShiftLeft(byte[] block, byte[] output)
		{
			return 0;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x5291690", Offset = "0x5290290", VA = "0x185291690")]
		protected static void Xor(byte[] block, byte[] val)
		{
		}

		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		private const int BLOCK_SIZE = 16;

		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher hashCipher;

		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		[FieldOffset(Offset = "0x18")]
		private readonly IBlockCipher mainCipher;

		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;

		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		[FieldOffset(Offset = "0x24")]
		private int macSize;

		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		[FieldOffset(Offset = "0x28")]
		private byte[] initialAssociatedText;

		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		[FieldOffset(Offset = "0x30")]
		private IList L;

		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		[FieldOffset(Offset = "0x38")]
		private byte[] L_Asterisk;

		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		[FieldOffset(Offset = "0x40")]
		private byte[] L_Dollar;

		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		[FieldOffset(Offset = "0x48")]
		private byte[] KtopInput;

		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		[FieldOffset(Offset = "0x50")]
		private byte[] Stretch;

		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		[FieldOffset(Offset = "0x58")]
		private byte[] OffsetMAIN_0;

		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		[FieldOffset(Offset = "0x60")]
		private byte[] hashBlock;

		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		[FieldOffset(Offset = "0x68")]
		private byte[] mainBlock;

		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		[FieldOffset(Offset = "0x70")]
		private int hashBlockPos;

		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		[FieldOffset(Offset = "0x74")]
		private int mainBlockPos;

		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		[FieldOffset(Offset = "0x78")]
		private long hashBlockCount;

		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		[FieldOffset(Offset = "0x80")]
		private long mainBlockCount;

		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		[FieldOffset(Offset = "0x88")]
		private byte[] OffsetHASH;

		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		[FieldOffset(Offset = "0x90")]
		private byte[] Sum;

		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		[FieldOffset(Offset = "0x98")]
		private byte[] OffsetMAIN;

		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		[FieldOffset(Offset = "0xA0")]
		private byte[] Checksum;

		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0xA8")]
		private byte[] macBlock;
	}
}
