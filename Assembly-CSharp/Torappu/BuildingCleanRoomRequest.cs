using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000624 RID: 1572
	[Token(Token = "0x2000624")]
	public class BuildingCleanRoomRequest : BuildingRequest
	{
		// Token: 0x06006252 RID: 25170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006252")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingCleanRoomRequest()
		{
		}

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;
	}
}
