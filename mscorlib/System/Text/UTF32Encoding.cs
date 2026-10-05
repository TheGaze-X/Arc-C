using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002A3 RID: 675
	[Token(Token = "0x20002A3")]
	[System.Serializable]
	public sealed class UTF32Encoding : Encoding
	{
		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x4B043D0", Offset = "0x4B02FD0", VA = "0x184B043D0")]
		public UTF32Encoding()
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x4B04480", Offset = "0x4B03080", VA = "0x184B04480")]
		public UTF32Encoding(bool bigEndian, bool byteOrderMark)
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x4B04400", Offset = "0x4B03000", VA = "0x184B04400")]
		public UTF32Encoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidCharacters)
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x4B04110", Offset = "0x4B02D10", VA = "0x184B04110", Slot = "5")]
		internal override void SetDefaultFallbacks()
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x4B01AC0", Offset = "0x4B006C0", VA = "0x184B01AC0", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x4B01C80", Offset = "0x4B00880", VA = "0x184B01C80", Slot = "12")]
		public override int GetByteCount(string s)
		{
			return 0;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x4B01D50", Offset = "0x4B00950", VA = "0x184B01D50", Slot = "14")]
		[System.CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x4B02280", Offset = "0x4B00E80", VA = "0x184B02280", Slot = "20")]
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x4B01E60", Offset = "0x4B00A60", VA = "0x184B01E60", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x4B02140", Offset = "0x4B00D40", VA = "0x184B02140", Slot = "22")]
		[System.CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x4B02F00", Offset = "0x4B01B00", VA = "0x184B02F00", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x4B02DF0", Offset = "0x4B019F0", VA = "0x184B02DF0", Slot = "24")]
		[System.CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x4B03200", Offset = "0x4B01E00", VA = "0x184B03200", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x4B030C0", Offset = "0x4B01CC0", VA = "0x184B030C0", Slot = "29")]
		[System.CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001658")]
		[Address(RVA = "0x4B03F10", Offset = "0x4B02B10", VA = "0x184B03F10", Slot = "37")]
		public override string GetString(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x6001659")]
		[Address(RVA = "0x4B016D0", Offset = "0x4B002D0", VA = "0x184B016D0", Slot = "15")]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x600165A")]
		[Address(RVA = "0x4B02580", Offset = "0x4B01180", VA = "0x184B02580", Slot = "21")]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x600165B")]
		[Address(RVA = "0x4B02A70", Offset = "0x4B01670", VA = "0x184B02A70", Slot = "25")]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x600165C")]
		[Address(RVA = "0x4B034E0", Offset = "0x4B020E0", VA = "0x184B034E0", Slot = "30")]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x600165D")]
		[Address(RVA = "0x4B040F0", Offset = "0x4B02CF0", VA = "0x184B040F0")]
		private uint GetSurrogate(char cHigh, char cLow)
		{
			return 0U;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x600165E")]
		[Address(RVA = "0x4B03B70", Offset = "0x4B02770", VA = "0x184B03B70")]
		private char GetHighSurrogate(uint iChar)
		{
			return '\0';
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x600165F")]
		[Address(RVA = "0x4B03B90", Offset = "0x4B02790", VA = "0x184B03B90")]
		private char GetLowSurrogate(uint iChar)
		{
			return '\0';
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001660")]
		[Address(RVA = "0x4B039D0", Offset = "0x4B025D0", VA = "0x184B039D0", Slot = "32")]
		public override Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001661")]
		[Address(RVA = "0x4B03A30", Offset = "0x4B02630", VA = "0x184B03A30", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x6001662")]
		[Address(RVA = "0x4B03BB0", Offset = "0x4B027B0", VA = "0x184B03BB0", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x4B03D40", Offset = "0x4B02940", VA = "0x184B03D40", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x4B03E60", Offset = "0x4B02A60", VA = "0x184B03E60", Slot = "6")]
		public override byte[] GetPreamble()
		{
			return null;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x1700023A")]
		public override System.ReadOnlySpan<byte> Preamble
		{
			[Token(Token = "0x6001665")]
			[Address(RVA = "0x4B044D0", Offset = "0x4B030D0", VA = "0x184B044D0", Slot = "7")]
			get
			{
				return default(System.ReadOnlySpan<byte>);
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x6001666")]
		[Address(RVA = "0x4B01620", Offset = "0x4B00220", VA = "0x184B01620", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x6001667")]
		[Address(RVA = "0x4B03A90", Offset = "0x4B02690", VA = "0x184B03A90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly UTF32Encoding s_default;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly UTF32Encoding s_bigEndianDefault;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] s_bigEndianPreamble;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] s_littleEndianPreamble;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x38")]
		private bool _emitUTF32ByteOrderMark;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x39")]
		private bool _isThrowException;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x3A")]
		private bool _bigEndian;

		// Token: 0x020002A4 RID: 676
		[Token(Token = "0x20002A4")]
		[System.Serializable]
		private sealed class UTF32Decoder : DecoderNLS
		{
			// Token: 0x06001669 RID: 5737 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001669")]
			[Address(RVA = "0x4AF5DA0", Offset = "0x4AF49A0", VA = "0x184AF5DA0")]
			public UTF32Decoder(UTF32Encoding encoding)
			{
			}

			// Token: 0x0600166A RID: 5738 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600166A")]
			[Address(RVA = "0x4B015C0", Offset = "0x4B001C0", VA = "0x184B015C0", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x0600166B RID: 5739 RVA: 0x00010440 File Offset: 0x0000E640
			[Token(Token = "0x1700023B")]
			internal override bool HasState
			{
				[Token(Token = "0x600166B")]
				[Address(RVA = "0x4B01610", Offset = "0x4B00210", VA = "0x184B01610", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000C33 RID: 3123
			[Token(Token = "0x4000C33")]
			[FieldOffset(Offset = "0x30")]
			internal int iChar;

			// Token: 0x04000C34 RID: 3124
			[Token(Token = "0x4000C34")]
			[FieldOffset(Offset = "0x34")]
			internal int readByteCount;
		}
	}
}
