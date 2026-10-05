using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public struct TMP_LinkInfo
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x58A33C0", Offset = "0x58A1FC0", VA = "0x1858A33C0")]
		internal void SetLinkID(char[] text, int startIndex, int length)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x58A32C0", Offset = "0x58A1EC0", VA = "0x1858A32C0")]
		public string GetLinkText()
		{
			return null;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x58A3220", Offset = "0x58A1E20", VA = "0x1858A3220")]
		public string GetLinkID()
		{
			return null;
		}

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x0")]
		public TMP_Text textComponent;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x8")]
		public int hashCode;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0xC")]
		public int linkIdFirstCharacterIndex;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x10")]
		public int linkIdLength;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x14")]
		public int linkTextfirstCharacterIndex;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x18")]
		public int linkTextLength;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x20")]
		internal char[] linkID;
	}
}
