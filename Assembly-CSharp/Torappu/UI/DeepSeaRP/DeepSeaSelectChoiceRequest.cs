using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005157 RID: 20823
	[Token(Token = "0x2005157")]
	public class DeepSeaSelectChoiceRequest
	{
		// Token: 0x0601EC79 RID: 126073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC79")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaSelectChoiceRequest()
		{
		}

		// Token: 0x0402943D RID: 169021
		[Token(Token = "0x402943D")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402943E RID: 169022
		[Token(Token = "0x402943E")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x0402943F RID: 169023
		[Token(Token = "0x402943F")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x04029440 RID: 169024
		[Token(Token = "0x4029440")]
		[FieldOffset(Offset = "0x28")]
		public int choiceIdx;
	}
}
