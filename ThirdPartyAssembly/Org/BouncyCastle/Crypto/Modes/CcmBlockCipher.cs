using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000302 RID: 770
	[Token(Token = "0x2000302")]
	public class CcmBlockCipher : IAeadBlockCipher
	{
		// Token: 0x060019A2 RID: 6562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x52812A0", Offset = "0x527FEA0", VA = "0x1852812A0")]
		public CcmBlockCipher(IBlockCipher cipher)
		{
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "17")]
		public virtual IBlockCipher GetUnderlyingCipher()
		{
			return null;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x5280250", Offset = "0x527EE50", VA = "0x185280250", Slot = "18")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060019A5 RID: 6565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x60019A5")]
			[Address(RVA = "0x52814B0", Offset = "0x52800B0", VA = "0x1852814B0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x52800D0", Offset = "0x527ECD0", VA = "0x1852800D0", Slot = "20")]
		public virtual int GetBlockSize()
		{
			return 0;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x5280630", Offset = "0x527F230", VA = "0x185280630", Slot = "21")]
		public virtual void ProcessAadByte(byte input)
		{
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x51B53A0", Offset = "0x51B3FA0", VA = "0x1851B53A0", Slot = "22")]
		public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
		{
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x5280680", Offset = "0x527F280", VA = "0x185280680", Slot = "23")]
		public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x52806E0", Offset = "0x527F2E0", VA = "0x1852806E0", Slot = "24")]
		public virtual int ProcessBytes(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x527FF40", Offset = "0x527EB40", VA = "0x18527FF40", Slot = "25")]
		public virtual int DoFinal(byte[] outBytes, int outOff)
		{
			return 0;
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x52811A0", Offset = "0x527FDA0", VA = "0x1852811A0", Slot = "26")]
		public virtual void Reset()
		{
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x5280120", Offset = "0x527ED20", VA = "0x185280120", Slot = "27")]
		public virtual byte[] GetMac()
		{
			return null;
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "28")]
		public virtual int GetUpdateOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x5280140", Offset = "0x527ED40", VA = "0x185280140", Slot = "29")]
		public virtual int GetOutputSize(int len)
		{
			return 0;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x5281080", Offset = "0x527FC80", VA = "0x185281080", Slot = "30")]
		public virtual byte[] ProcessPacket(byte[] input, int inOff, int inLen)
		{
			return null;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x52807A0", Offset = "0x527F3A0", VA = "0x1852807A0", Slot = "31")]
		public virtual int ProcessPacket(byte[] input, int inOff, int inLen, byte[] output, int outOff)
		{
			return 0;
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x527F9E0", Offset = "0x527E5E0", VA = "0x18527F9E0")]
		private int CalculateMac(byte[] data, int dataOff, int dataLen, byte[] macBlock)
		{
			return 0;
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x5280060", Offset = "0x527EC60", VA = "0x185280060")]
		private int GetAssociatedTextLength()
		{
			return 0;
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x52801D0", Offset = "0x527EDD0", VA = "0x1852801D0")]
		private bool HasAssociatedText()
		{
			return default(bool);
		}

		// Token: 0x04000D6D RID: 3437
		[Token(Token = "0x4000D6D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int BlockSize;

		// Token: 0x04000D6E RID: 3438
		[Token(Token = "0x4000D6E")]
		[FieldOffset(Offset = "0x10")]
		private readonly IBlockCipher cipher;

		// Token: 0x04000D6F RID: 3439
		[Token(Token = "0x4000D6F")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] macBlock;

		// Token: 0x04000D70 RID: 3440
		[Token(Token = "0x4000D70")]
		[FieldOffset(Offset = "0x20")]
		private bool forEncryption;

		// Token: 0x04000D71 RID: 3441
		[Token(Token = "0x4000D71")]
		[FieldOffset(Offset = "0x28")]
		private byte[] nonce;

		// Token: 0x04000D72 RID: 3442
		[Token(Token = "0x4000D72")]
		[FieldOffset(Offset = "0x30")]
		private byte[] initialAssociatedText;

		// Token: 0x04000D73 RID: 3443
		[Token(Token = "0x4000D73")]
		[FieldOffset(Offset = "0x38")]
		private int macSize;

		// Token: 0x04000D74 RID: 3444
		[Token(Token = "0x4000D74")]
		[FieldOffset(Offset = "0x40")]
		private ICipherParameters keyParam;

		// Token: 0x04000D75 RID: 3445
		[Token(Token = "0x4000D75")]
		[FieldOffset(Offset = "0x48")]
		private readonly MemoryStream associatedText;

		// Token: 0x04000D76 RID: 3446
		[Token(Token = "0x4000D76")]
		[FieldOffset(Offset = "0x50")]
		private readonly MemoryStream data;
	}
}
