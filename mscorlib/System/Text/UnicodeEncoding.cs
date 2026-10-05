using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x020002AE RID: 686
	[Token(Token = "0x20002AE")]
	[System.Serializable]
	public class UnicodeEncoding : Encoding
	{
		// Token: 0x060016C1 RID: 5825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C1")]
		[Address(RVA = "0x4B21A30", Offset = "0x4B20630", VA = "0x184B21A30")]
		public UnicodeEncoding()
		{
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C2")]
		[Address(RVA = "0x4B219E0", Offset = "0x4B205E0", VA = "0x184B219E0")]
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark)
		{
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C3")]
		[Address(RVA = "0x4B21960", Offset = "0x4B20560", VA = "0x184B21960")]
		public UnicodeEncoding(bool bigEndian, bool byteOrderMark, bool throwOnInvalidBytes)
		{
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016C4")]
		[Address(RVA = "0x4B21630", Offset = "0x4B20230", VA = "0x184B21630", Slot = "5")]
		internal override void SetDefaultFallbacks()
		{
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x00010968 File Offset: 0x0000EB68
		[Token(Token = "0x60016C5")]
		[Address(RVA = "0x4B1D750", Offset = "0x4B1C350", VA = "0x184B1D750", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00010980 File Offset: 0x0000EB80
		[Token(Token = "0x60016C6")]
		[Address(RVA = "0x4B1E100", Offset = "0x4B1CD00", VA = "0x184B1E100", Slot = "12")]
		public override int GetByteCount(string s)
		{
			return 0;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00010998 File Offset: 0x0000EB98
		[Token(Token = "0x60016C7")]
		[Address(RVA = "0x4B1E1D0", Offset = "0x4B1CDD0", VA = "0x184B1E1D0", Slot = "14")]
		[System.CLSCompliant(false)]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000109B0 File Offset: 0x0000EBB0
		[Token(Token = "0x60016C8")]
		[Address(RVA = "0x4B1E2E0", Offset = "0x4B1CEE0", VA = "0x184B1E2E0", Slot = "20")]
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[Token(Token = "0x60016C9")]
		[Address(RVA = "0x4B1F010", Offset = "0x4B1DC10", VA = "0x184B1F010", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000109E0 File Offset: 0x0000EBE0
		[Token(Token = "0x60016CA")]
		[Address(RVA = "0x4B1F2F0", Offset = "0x4B1DEF0", VA = "0x184B1F2F0", Slot = "22")]
		[System.CLSCompliant(false)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000109F8 File Offset: 0x0000EBF8
		[Token(Token = "0x60016CB")]
		[Address(RVA = "0x4B1FD90", Offset = "0x4B1E990", VA = "0x184B1FD90", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00010A10 File Offset: 0x0000EC10
		[Token(Token = "0x60016CC")]
		[Address(RVA = "0x4B1FC80", Offset = "0x4B1E880", VA = "0x184B1FC80", Slot = "24")]
		[System.CLSCompliant(false)]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00010A28 File Offset: 0x0000EC28
		[Token(Token = "0x60016CD")]
		[Address(RVA = "0x4B20BF0", Offset = "0x4B1F7F0", VA = "0x184B20BF0", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00010A40 File Offset: 0x0000EC40
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x4B20AB0", Offset = "0x4B1F6B0", VA = "0x184B20AB0", Slot = "29")]
		[System.CLSCompliant(false)]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016CF")]
		[Address(RVA = "0x4B21450", Offset = "0x4B20050", VA = "0x184B21450", Slot = "37")]
		public override string GetString(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00010A58 File Offset: 0x0000EC58
		[Token(Token = "0x60016D0")]
		[Address(RVA = "0x4B1D910", Offset = "0x4B1C510", VA = "0x184B1D910", Slot = "15")]
		internal unsafe override int GetByteCount(char* chars, int count, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00010A70 File Offset: 0x0000EC70
		[Token(Token = "0x60016D1")]
		[Address(RVA = "0x4B1E5E0", Offset = "0x4B1D1E0", VA = "0x184B1E5E0", Slot = "21")]
		internal unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, EncoderNLS encoder)
		{
			return 0;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00010A88 File Offset: 0x0000EC88
		[Token(Token = "0x60016D2")]
		[Address(RVA = "0x4B1F430", Offset = "0x4B1E030", VA = "0x184B1F430", Slot = "25")]
		internal unsafe override int GetCharCount(byte* bytes, int count, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x60016D3")]
		[Address(RVA = "0x4B1FF50", Offset = "0x4B1EB50", VA = "0x184B1FF50", Slot = "30")]
		internal unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, DecoderNLS baseDecoder)
		{
			return 0;
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016D4")]
		[Address(RVA = "0x4B20F40", Offset = "0x4B1FB40", VA = "0x184B20F40", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016D5")]
		[Address(RVA = "0x4B20ED0", Offset = "0x4B1FAD0", VA = "0x184B20ED0", Slot = "32")]
		public override System.Text.Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60016D6")]
		[Address(RVA = "0x4B213A0", Offset = "0x4B1FFA0", VA = "0x184B213A0", Slot = "6")]
		public override byte[] GetPreamble()
		{
			return null;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x17000244")]
		public override System.ReadOnlySpan<byte> Preamble
		{
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x4B21A60", Offset = "0x4B20660", VA = "0x184B21A60", Slot = "7")]
			get
			{
				return default(System.ReadOnlySpan<byte>);
			}
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00010AD0 File Offset: 0x0000ECD0
		[Token(Token = "0x60016D8")]
		[Address(RVA = "0x4B21090", Offset = "0x4B1FC90", VA = "0x184B21090", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00010AE8 File Offset: 0x0000ECE8
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x4B21210", Offset = "0x4B1FE10", VA = "0x184B21210", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00010B00 File Offset: 0x0000ED00
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x4B1D600", Offset = "0x4B1C200", VA = "0x184B1D600", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00010B18 File Offset: 0x0000ED18
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x4B20FA0", Offset = "0x4B1FBA0", VA = "0x184B20FA0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly UnicodeEncoding s_bigEndianDefault;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly UnicodeEncoding s_littleEndianDefault;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly byte[] s_bigEndianPreamble;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly byte[] s_littleEndianPreamble;

		// Token: 0x04000C4C RID: 3148
		[Token(Token = "0x4000C4C")]
		[FieldOffset(Offset = "0x38")]
		internal bool isThrowException;

		// Token: 0x04000C4D RID: 3149
		[Token(Token = "0x4000C4D")]
		[FieldOffset(Offset = "0x39")]
		internal bool bigEndian;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[FieldOffset(Offset = "0x3A")]
		internal bool byteOrderMark;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[FieldOffset(Offset = "0x20")]
		private static readonly ulong highLowPatternMask;

		// Token: 0x020002AF RID: 687
		[Token(Token = "0x20002AF")]
		[System.Serializable]
		private sealed class Decoder : DecoderNLS
		{
			// Token: 0x060016DD RID: 5853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016DD")]
			[Address(RVA = "0x4B0B170", Offset = "0x4B09D70", VA = "0x184B0B170")]
			public Decoder(UnicodeEncoding encoding)
			{
			}

			// Token: 0x060016DE RID: 5854 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60016DE")]
			[Address(RVA = "0x4B0B120", Offset = "0x4B09D20", VA = "0x184B0B120", Slot = "4")]
			public override void Reset()
			{
			}

			// Token: 0x17000245 RID: 581
			// (get) Token: 0x060016DF RID: 5855 RVA: 0x00010B30 File Offset: 0x0000ED30
			[Token(Token = "0x17000245")]
			internal override bool HasState
			{
				[Token(Token = "0x60016DF")]
				[Address(RVA = "0x4B0B180", Offset = "0x4B09D80", VA = "0x184B0B180", Slot = "14")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04000C50 RID: 3152
			[Token(Token = "0x4000C50")]
			[FieldOffset(Offset = "0x30")]
			internal int lastByte;

			// Token: 0x04000C51 RID: 3153
			[Token(Token = "0x4000C51")]
			[FieldOffset(Offset = "0x34")]
			internal char lastChar;
		}
	}
}
