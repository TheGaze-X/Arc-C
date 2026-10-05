using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200110F RID: 4367
	[Token(Token = "0x200110F")]
	[Serializable]
	public class SOCharMissionGroup
	{
		// Token: 0x06006ED5 RID: 28373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SOCharMissionGroup()
		{
		}

		// Token: 0x04005D94 RID: 23956
		[Token(Token = "0x4005D94")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005D95 RID: 23957
		[Token(Token = "0x4005D95")]
		[FieldOffset(Offset = "0x18")]
		public string[] missionIds;

		// Token: 0x04005D96 RID: 23958
		[Token(Token = "0x4005D96")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005D97 RID: 23959
		[Token(Token = "0x4005D97")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;
	}
}
