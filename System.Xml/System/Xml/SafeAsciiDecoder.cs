using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	internal class SafeAsciiDecoder : Decoder
	{
		// Token: 0x0600074B RID: 1867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SafeAsciiDecoder()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x4F78B60", Offset = "0x4F77760", VA = "0x184F78B60", Slot = "5")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x4FE6000", Offset = "0x4FE4C00", VA = "0x184FE6000", Slot = "8")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4FE5F60", Offset = "0x4FE4B60", VA = "0x184FE5F60", Slot = "12")]
		public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed)
		{
		}
	}
}
