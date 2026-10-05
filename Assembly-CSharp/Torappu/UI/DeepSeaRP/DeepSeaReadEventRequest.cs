using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005159 RID: 20825
	[Token(Token = "0x2005159")]
	public class DeepSeaReadEventRequest
	{
		// Token: 0x0601EC7B RID: 126075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC7B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaReadEventRequest()
		{
		}

		// Token: 0x04029441 RID: 169025
		[Token(Token = "0x4029441")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04029442 RID: 169026
		[Token(Token = "0x4029442")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x04029443 RID: 169027
		[Token(Token = "0x4029443")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x04029444 RID: 169028
		[Token(Token = "0x4029444")]
		[FieldOffset(Offset = "0x28")]
		public string eventId;
	}
}
