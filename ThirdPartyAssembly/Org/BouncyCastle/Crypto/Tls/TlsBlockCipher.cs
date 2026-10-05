using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000281 RID: 641
	[Token(Token = "0x2000281")]
	public class TlsBlockCipher : TlsCipher
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000305")]
		public virtual TlsMac WriteMac
		{
			[Token(Token = "0x6001572")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000306")]
		public virtual TlsMac ReadMac
		{
			[Token(Token = "0x6001573")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x5252C20", Offset = "0x5251820", VA = "0x185252C20")]
		public TlsBlockCipher(TlsContext context, IBlockCipher clientWriteCipher, IBlockCipher serverWriteCipher, IDigest clientWriteDigest, IDigest serverWriteDigest, int cipherKeySize)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x5252B30", Offset = "0x5251730", VA = "0x185252B30", Slot = "9")]
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return 0;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x52525C0", Offset = "0x52511C0", VA = "0x1852525C0", Slot = "10")]
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			return null;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x5252050", Offset = "0x5250C50", VA = "0x185252050", Slot = "11")]
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			return null;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x5251E10", Offset = "0x5250A10", VA = "0x185251E10", Slot = "12")]
		protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
		{
			return 0;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x5251F80", Offset = "0x5250B80", VA = "0x185251F80", Slot = "13")]
		protected virtual int ChooseExtraPadBlocks(SecureRandom r, int max)
		{
			return 0;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x5252C00", Offset = "0x5251800", VA = "0x185252C00", Slot = "14")]
		protected virtual int LowestBitSet(int x)
		{
			return 0;
		}

		// Token: 0x04000C06 RID: 3078
		[Token(Token = "0x4000C06")]
		[FieldOffset(Offset = "0x10")]
		protected readonly TlsContext context;

		// Token: 0x04000C07 RID: 3079
		[Token(Token = "0x4000C07")]
		[FieldOffset(Offset = "0x18")]
		protected readonly byte[] randomData;

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x20")]
		protected readonly bool useExplicitIV;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x21")]
		protected readonly bool encryptThenMac;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x28")]
		protected readonly IBlockCipher encryptCipher;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x30")]
		protected readonly IBlockCipher decryptCipher;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x38")]
		protected readonly TlsMac mWriteMac;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x40")]
		protected readonly TlsMac mReadMac;
	}
}
