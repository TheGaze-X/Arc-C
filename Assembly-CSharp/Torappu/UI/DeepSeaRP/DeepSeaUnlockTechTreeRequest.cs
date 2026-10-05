using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005155 RID: 20821
	[Token(Token = "0x2005155")]
	public class DeepSeaUnlockTechTreeRequest
	{
		// Token: 0x0601EC77 RID: 126071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC77")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaUnlockTechTreeRequest()
		{
		}

		// Token: 0x04029439 RID: 169017
		[Token(Token = "0x4029439")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402943A RID: 169018
		[Token(Token = "0x402943A")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x0402943B RID: 169019
		[Token(Token = "0x402943B")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x0402943C RID: 169020
		[Token(Token = "0x402943C")]
		[FieldOffset(Offset = "0x28")]
		public string techTreeId;
	}
}
