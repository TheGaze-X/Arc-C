using System;
using Il2CppDummyDll;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005153 RID: 20819
	[Token(Token = "0x2005153")]
	public class DeepSeaOpenTreasureRequest
	{
		// Token: 0x0601EC75 RID: 126069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EC75")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DeepSeaOpenTreasureRequest()
		{
		}

		// Token: 0x04029434 RID: 169012
		[Token(Token = "0x4029434")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04029435 RID: 169013
		[Token(Token = "0x4029435")]
		[FieldOffset(Offset = "0x18")]
		public string placeId;

		// Token: 0x04029436 RID: 169014
		[Token(Token = "0x4029436")]
		[FieldOffset(Offset = "0x20")]
		public string nodeId;

		// Token: 0x04029437 RID: 169015
		[Token(Token = "0x4029437")]
		[FieldOffset(Offset = "0x28")]
		public string treasureId;
	}
}
