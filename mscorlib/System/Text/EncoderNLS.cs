using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	internal class EncoderNLS : Encoder
	{
		// Token: 0x060015C9 RID: 5577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0x4AF77B0", Offset = "0x4AF63B0", VA = "0x184AF77B0")]
		internal EncoderNLS(Encoding encoding)
		{
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x4AF7760", Offset = "0x4AF6360", VA = "0x184AF7760", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0x4AF6FA0", Offset = "0x4AF5BA0", VA = "0x184AF6FA0", Slot = "5")]
		public override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x4AF71B0", Offset = "0x4AF5DB0", VA = "0x184AF71B0", Slot = "6")]
		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0x4AF72D0", Offset = "0x4AF5ED0", VA = "0x184AF72D0", Slot = "7")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			return 0;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x4AF7600", Offset = "0x4AF6200", VA = "0x184AF7600", Slot = "8")]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			return 0;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0x4AF6BB0", Offset = "0x4AF57B0", VA = "0x184AF6BB0", Slot = "9")]
		public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x4AF69D0", Offset = "0x4AF55D0", VA = "0x184AF69D0", Slot = "10")]
		public unsafe override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700022F")]
		public Encoding Encoding
		{
			[Token(Token = "0x60015D1")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x17000230")]
		public bool MustFlush
		{
			[Token(Token = "0x60015D2")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0000FF48 File Offset: 0x0000E148
		[Token(Token = "0x17000231")]
		internal virtual bool HasState
		{
			[Token(Token = "0x60015D3")]
			[Address(RVA = "0x4AF7830", Offset = "0x4AF6430", VA = "0x184AF7830", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015D4")]
		[Address(RVA = "0x1B023D0", Offset = "0x1B00FD0", VA = "0x181B023D0")]
		internal void ClearMustFlush()
		{
		}

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x20")]
		internal char _charLeftOver;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x28")]
		private Encoding _encoding;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x30")]
		private bool _mustFlush;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x31")]
		internal bool _throwOnOverflow;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x34")]
		internal int _charsUsed;
	}
}
