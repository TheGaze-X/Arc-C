using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	internal abstract class Ucs4Decoder : Decoder
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4FE9F90", Offset = "0x4FE8B90", VA = "0x184FE9F90", Slot = "5")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600076C RID: 1900
		[Token(Token = "0x600076C")]
		internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x0600076D RID: 1901 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4FE9FA0", Offset = "0x4FE8BA0", VA = "0x184FE9FA0", Slot = "8")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4FE9D70", Offset = "0x4FE8970", VA = "0x184FE9D70", Slot = "12")]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4FEA140", Offset = "0x4FE8D40", VA = "0x184FEA140")]
		internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x4FE9500", Offset = "0x4FE8100", VA = "0x184FE9500")]
		protected Ucs4Decoder()
		{
		}

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0x20")]
		internal byte[] lastBytes;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0x28")]
		internal int lastBytesCount;
	}
}
