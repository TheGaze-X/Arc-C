using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x02000287 RID: 647
	[Token(Token = "0x2000287")]
	[System.Serializable]
	public abstract class Decoder
	{
		// Token: 0x0600153D RID: 5437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600153D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected Decoder()
		{
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000212")]
		public DecoderFallback Fallback
		{
			[Token(Token = "0x600153E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000213")]
		public DecoderFallbackBuffer FallbackBuffer
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x4ADE710", Offset = "0x4ADD310", VA = "0x184ADE710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0000F948 File Offset: 0x0000DB48
		[Token(Token = "0x17000214")]
		internal bool InternalHasFallbackBuffer
		{
			[Token(Token = "0x6001540")]
			[Address(RVA = "0x142F770", Offset = "0x142E370", VA = "0x18142F770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001541 RID: 5441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001541")]
		[Address(RVA = "0x4ADE5B0", Offset = "0x4ADD1B0", VA = "0x184ADE5B0", Slot = "4")]
		public virtual void Reset()
		{
		}

		// Token: 0x06001542 RID: 5442
		[Token(Token = "0x6001542")]
		public abstract int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x06001543 RID: 5443 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x6001543")]
		[Address(RVA = "0x4ADE180", Offset = "0x4ADCD80", VA = "0x184ADE180", Slot = "6")]
		public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x6001544")]
		[Address(RVA = "0x4ADDFD0", Offset = "0x4ADCBD0", VA = "0x184ADDFD0", Slot = "7")]
		[System.CLSCompliant(false)]
		public unsafe virtual int GetCharCount(byte* bytes, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06001545 RID: 5445
		[Token(Token = "0x6001545")]
		public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x06001546 RID: 5446 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x6001546")]
		[Address(RVA = "0x4ADE1F0", Offset = "0x4ADCDF0", VA = "0x184ADE1F0", Slot = "9")]
		public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return 0;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x6001547")]
		[Address(RVA = "0x4ADE260", Offset = "0x4ADCE60", VA = "0x184ADE260", Slot = "10")]
		[System.CLSCompliant(false)]
		public unsafe virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			return 0;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		[Token(Token = "0x6001548")]
		[Address(RVA = "0x4ADE4D0", Offset = "0x4ADD0D0", VA = "0x184ADE4D0", Slot = "11")]
		public virtual int GetChars(System.ReadOnlySpan<byte> bytes, System.Span<char> chars, bool flush)
		{
			return 0;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001549")]
		[Address(RVA = "0x4ADD950", Offset = "0x4ADC550", VA = "0x184ADD950", Slot = "12")]
		public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154A")]
		[Address(RVA = "0x4ADDD50", Offset = "0x4ADC950", VA = "0x184ADDD50", Slot = "13")]
		[System.CLSCompliant(false)]
		public unsafe virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x10")]
		internal DecoderFallback _fallback;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x18")]
		internal DecoderFallbackBuffer _fallbackBuffer;
	}
}
