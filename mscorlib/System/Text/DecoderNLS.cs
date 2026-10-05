using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	internal class DecoderNLS : Decoder
	{
		// Token: 0x06001574 RID: 5492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001574")]
		[Address(RVA = "0x4ADD4F0", Offset = "0x4ADC0F0", VA = "0x184ADD4F0")]
		internal DecoderNLS(Encoding encoding)
		{
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001575")]
		[Address(RVA = "0x4ADD4B0", Offset = "0x4ADC0B0", VA = "0x184ADD4B0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0000FB58 File Offset: 0x0000DD58
		[Token(Token = "0x6001576")]
		[Address(RVA = "0x4ADCBE0", Offset = "0x4ADB7E0", VA = "0x184ADCBE0", Slot = "5")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0000FB70 File Offset: 0x0000DD70
		[Token(Token = "0x6001577")]
		[Address(RVA = "0x4ADCD70", Offset = "0x4ADB970", VA = "0x184ADCD70", Slot = "6")]
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x0000FB88 File Offset: 0x0000DD88
		[Token(Token = "0x6001578")]
		[Address(RVA = "0x4ADCC50", Offset = "0x4ADB850", VA = "0x184ADCC50", Slot = "7")]
		public unsafe override int GetCharCount(byte* bytes, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		[Token(Token = "0x6001579")]
		[Address(RVA = "0x4ADCF80", Offset = "0x4ADBB80", VA = "0x184ADCF80", Slot = "8")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		[Token(Token = "0x600157A")]
		[Address(RVA = "0x4ADD180", Offset = "0x4ADBD80", VA = "0x184ADD180", Slot = "9")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush)
		{
			return 0;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		[Token(Token = "0x600157B")]
		[Address(RVA = "0x4ADD010", Offset = "0x4ADBC10", VA = "0x184ADD010", Slot = "10")]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush)
		{
			return 0;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157C")]
		[Address(RVA = "0x4ADC7F0", Offset = "0x4ADB3F0", VA = "0x184ADC7F0", Slot = "12")]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600157D")]
		[Address(RVA = "0x4ADC610", Offset = "0x4ADB210", VA = "0x184ADC610", Slot = "13")]
		public unsafe override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		[Token(Token = "0x1700021E")]
		public bool MustFlush
		{
			[Token(Token = "0x600157E")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x0000FC00 File Offset: 0x0000DE00
		[Token(Token = "0x1700021F")]
		internal virtual bool HasState
		{
			[Token(Token = "0x600157F")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001580")]
		[Address(RVA = "0x4ADC600", Offset = "0x4ADB200", VA = "0x184ADC600")]
		internal void ClearMustFlush()
		{
		}

		// Token: 0x04000BED RID: 3053
		[Token(Token = "0x4000BED")]
		[FieldOffset(Offset = "0x20")]
		private Encoding _encoding;

		// Token: 0x04000BEE RID: 3054
		[Token(Token = "0x4000BEE")]
		[FieldOffset(Offset = "0x28")]
		private bool _mustFlush;

		// Token: 0x04000BEF RID: 3055
		[Token(Token = "0x4000BEF")]
		[FieldOffset(Offset = "0x29")]
		internal bool _throwOnOverflow;

		// Token: 0x04000BF0 RID: 3056
		[Token(Token = "0x4000BF0")]
		[FieldOffset(Offset = "0x2C")]
		internal int _bytesUsed;
	}
}
