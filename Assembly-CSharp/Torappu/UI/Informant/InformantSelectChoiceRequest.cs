using System;
using Il2CppDummyDll;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A40 RID: 19008
	[Token(Token = "0x2004A40")]
	public class InformantSelectChoiceRequest
	{
		// Token: 0x0601C945 RID: 117061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C945")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InformantSelectChoiceRequest()
		{
		}

		// Token: 0x0402583C RID: 153660
		[Token(Token = "0x402583C")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0402583D RID: 153661
		[Token(Token = "0x402583D")]
		[FieldOffset(Offset = "0x18")]
		public int index;
	}
}
