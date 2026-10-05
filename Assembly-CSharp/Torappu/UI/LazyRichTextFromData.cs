using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003896 RID: 14486
	[Token(Token = "0x2003896")]
	public struct LazyRichTextFromData
	{
		// Token: 0x06016EEF RID: 93935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016EEF")]
		[Address(RVA = "0xF5A710", Offset = "0xF59310", VA = "0x180F5A710")]
		public LazyRichTextFromData(string raw)
		{
		}

		// Token: 0x06016EF0 RID: 93936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016EF0")]
		[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
		public string GetRawString()
		{
			return null;
		}

		// Token: 0x06016EF1 RID: 93937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016EF1")]
		[Address(RVA = "0xF5A690", Offset = "0xF59290", VA = "0x180F5A690")]
		public string GetRichString()
		{
			return null;
		}

		// Token: 0x0401BABD RID: 113341
		[Token(Token = "0x401BABD")]
		[FieldOffset(Offset = "0x0")]
		private string m_raw;

		// Token: 0x0401BABE RID: 113342
		[Token(Token = "0x401BABE")]
		[FieldOffset(Offset = "0x8")]
		private string m_rich;
	}
}
