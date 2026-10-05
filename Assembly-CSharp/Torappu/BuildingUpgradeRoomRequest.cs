using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	public class BuildingUpgradeRoomRequest : BuildingRequest
	{
		// Token: 0x0600624E RID: 25166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600624E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingUpgradeRoomRequest()
		{
		}

		// Token: 0x04002DA7 RID: 11687
		[Token(Token = "0x4002DA7")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DA8 RID: 11688
		[Token(Token = "0x4002DA8")]
		[FieldOffset(Offset = "0x18")]
		public int targetLevel;
	}
}
