using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000628 RID: 1576
	[Token(Token = "0x2000628")]
	public class BuildingUpgradeCompleteRoomRequest : BuildingRequest
	{
		// Token: 0x06006257 RID: 25175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006257")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingUpgradeCompleteRoomRequest()
		{
		}

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x10")]
		public string roomSlotId;

		// Token: 0x04002DB4 RID: 11700
		[Token(Token = "0x4002DB4")]
		[FieldOffset(Offset = "0x18")]
		public int targetLevel;
	}
}
