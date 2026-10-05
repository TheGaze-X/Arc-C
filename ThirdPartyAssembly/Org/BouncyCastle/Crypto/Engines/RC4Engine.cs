using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200033C RID: 828
	[Token(Token = "0x200033C")]
	public class RC4Engine : IStreamCipher
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x52C6720", Offset = "0x52C5320", VA = "0x1852C6720", Slot = "9")]
		public virtual void Init(bool forEncryption, ICipherParameters parameters)
		{
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DE")]
		public virtual string AlgorithmName
		{
			[Token(Token = "0x6001BFC")]
			[Address(RVA = "0x52C6E00", Offset = "0x52C5A00", VA = "0x1852C6E00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0000D878 File Offset: 0x0000BA78
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x52C6B20", Offset = "0x52C5720", VA = "0x1852C6B20", Slot = "11")]
		public virtual byte ReturnByte(byte input)
		{
			return 0;
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x52C6950", Offset = "0x52C5550", VA = "0x1852C6950", Slot = "12")]
		public virtual void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x52C6B10", Offset = "0x52C5710", VA = "0x1852C6B10", Slot = "13")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x52C6BF0", Offset = "0x52C57F0", VA = "0x1852C6BF0")]
		private void SetKey(byte[] keyBytes)
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RC4Engine()
		{
		}

		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int STATE_LENGTH;

		// Token: 0x04000F11 RID: 3857
		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x10")]
		private byte[] engineState;

		// Token: 0x04000F12 RID: 3858
		[Token(Token = "0x4000F12")]
		[FieldOffset(Offset = "0x18")]
		private int x;

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		[FieldOffset(Offset = "0x1C")]
		private int y;

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x20")]
		private byte[] workingKey;
	}
}
