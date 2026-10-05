using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200136B RID: 4971
	[Token(Token = "0x200136B")]
	[Serializable]
	public class SixStarRuneData
	{
		// Token: 0x06007337 RID: 29495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007337")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SixStarRuneData()
		{
		}

		// Token: 0x04006E34 RID: 28212
		[Token(Token = "0x4006E34")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x04006E35 RID: 28213
		[Token(Token = "0x4006E35")]
		[FieldOffset(Offset = "0x18")]
		public string runeDesc;

		// Token: 0x04006E36 RID: 28214
		[Token(Token = "0x4006E36")]
		[FieldOffset(Offset = "0x20")]
		public string runeKey;
	}
}
