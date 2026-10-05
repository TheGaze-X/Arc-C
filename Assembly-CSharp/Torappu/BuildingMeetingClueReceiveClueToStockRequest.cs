using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class BuildingMeetingClueReceiveClueToStockRequest : BuildingRequest
	{
		// Token: 0x060062A9 RID: 25257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingMeetingClueReceiveClueToStockRequest()
		{
		}

		// Token: 0x04002E3D RID: 11837
		[Token(Token = "0x4002E3D")]
		[FieldOffset(Offset = "0x10")]
		public List<string> clues;
	}
}
