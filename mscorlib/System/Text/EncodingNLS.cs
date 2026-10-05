using System;
using Il2CppDummyDll;

namespace System.Text
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	[System.Serializable]
	internal abstract class EncodingNLS : Encoding
	{
		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x4AFA2F0", Offset = "0x4AF8EF0", VA = "0x184AFA2F0")]
		protected EncodingNLS(int codePage)
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x4AF9080", Offset = "0x4AF7C80", VA = "0x184AF9080", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x4AF8EA0", Offset = "0x4AF7AA0", VA = "0x184AF8EA0", Slot = "12")]
		public override int GetByteCount(string s)
		{
			return 0;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x4AF8F70", Offset = "0x4AF7B70", VA = "0x184AF8F70", Slot = "14")]
		public unsafe override int GetByteCount(char* chars, int count)
		{
			return 0;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x4AF9240", Offset = "0x4AF7E40", VA = "0x184AF9240", Slot = "20")]
		public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x4AF9680", Offset = "0x4AF8280", VA = "0x184AF9680", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x4AF9540", Offset = "0x4AF8140", VA = "0x184AF9540", Slot = "22")]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount)
		{
			return 0;
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x4AF9960", Offset = "0x4AF8560", VA = "0x184AF9960", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x4AF9B20", Offset = "0x4AF8720", VA = "0x184AF9B20", Slot = "24")]
		public unsafe override int GetCharCount(byte* bytes, int count)
		{
			return 0;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x4AF9D70", Offset = "0x4AF8970", VA = "0x184AF9D70", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x4AF9C30", Offset = "0x4AF8830", VA = "0x184AF9C30", Slot = "29")]
		public unsafe override int GetChars(byte* bytes, int byteCount, char* chars, int charCount)
		{
			return 0;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x4AFA110", Offset = "0x4AF8D10", VA = "0x184AFA110", Slot = "37")]
		public override string GetString(byte[] bytes, int index, int count)
		{
			return null;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x4AFA050", Offset = "0x4AF8C50", VA = "0x184AFA050", Slot = "32")]
		public override Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x4AFA0B0", Offset = "0x4AF8CB0", VA = "0x184AFA0B0", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}
	}
}
