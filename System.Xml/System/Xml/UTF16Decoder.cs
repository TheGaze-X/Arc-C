using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200009C RID: 156
	[Token(Token = "0x200009C")]
	internal class UTF16Decoder : Decoder
	{
		// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x4FE9220", Offset = "0x4FE7E20", VA = "0x184FE9220")]
		public UTF16Decoder(bool bigEndian)
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x4ADCBE0", Offset = "0x4ADB7E0", VA = "0x184ADCBE0", Slot = "5")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x4FE8EB0", Offset = "0x4FE7AB0", VA = "0x184FE8EB0", Slot = "6")]
		public override int GetCharCount(byte[] bytes, int index, int count, bool flush)
		{
			return 0;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x4FE8FB0", Offset = "0x4FE7BB0", VA = "0x184FE8FB0", Slot = "8")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x4FE8BC0", Offset = "0x4FE77C0", VA = "0x184FE8BC0", Slot = "12")]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0x20")]
		private bool bigEndian;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0x24")]
		private int lastByte;
	}
}
