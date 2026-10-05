using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200514D RID: 20813
	[Token(Token = "0x200514D")]
	public class DeepSeaDiscoverPlaceRequest
	{
		// Token: 0x0601EC6F RID: 126063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC6F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaDiscoverPlaceRequest()
		{
		}

		// Token: 0x0402942B RID: 169003
		[Token(Token = "0x402942B")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0402942C RID: 169004
		[Token(Token = "0x402942C")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;
	}
}
