using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200515E RID: 20830
	[Token(Token = "0x200515E")]
	public class DeepSeaActiveTechTreeRequest
	{
		// Token: 0x0601EC80 RID: 126080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC80")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaActiveTechTreeRequest()
		{
		}

		// Token: 0x04029449 RID: 169033
		[Token(Token = "0x4029449")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402944A RID: 169034
		[Token(Token = "0x402944A")]
		[FieldOffset(Offset = "0x18")]
		public string techTreeId;
	}
}
