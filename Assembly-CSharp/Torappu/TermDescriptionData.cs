using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013AA RID: 5034
	[Token(Token = "0x20013AA")]
	[Serializable]
	public class TermDescriptionData
	{
		// Token: 0x06007395 RID: 29589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007395")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TermDescriptionData()
		{
		}

		// Token: 0x04006FE9 RID: 28649
		[Token(Token = "0x4006FE9")]
		[FieldOffset(Offset = "0x10")]
		public string termId;

		// Token: 0x04006FEA RID: 28650
		[Token(Token = "0x4006FEA")]
		[FieldOffset(Offset = "0x18")]
		public string termName;

		// Token: 0x04006FEB RID: 28651
		[Token(Token = "0x4006FEB")]
		[FieldOffset(Offset = "0x20")]
		public string description;
	}
}
