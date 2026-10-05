using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x2000626")]
	public class BuildingBuildRoomRequest : BuildingRequest
	{
		// Token: 0x06006254 RID: 25172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006254")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingBuildRoomRequest()
		{
		}

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[FieldOffset(Offset = "0x18")]
		public string roomId;
	}
}
