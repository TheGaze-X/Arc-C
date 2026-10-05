using System;
using Il2CppDummyDll;

namespace TMPro
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public struct TMP_WordInfo
	{
		// Token: 0x06000117 RID: 279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x58A3840", Offset = "0x58A2440", VA = "0x1858A3840")]
		public string GetWord()
		{
			return null;
		}

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		public TMP_Text textComponent;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x8")]
		public int firstCharacterIndex;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xC")]
		public int lastCharacterIndex;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x10")]
		public int characterCount;
	}
}
