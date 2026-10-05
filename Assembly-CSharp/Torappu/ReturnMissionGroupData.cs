using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200114A RID: 4426
	[Token(Token = "0x200114A")]
	public class ReturnMissionGroupData
	{
		// Token: 0x06006F24 RID: 28452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F24")]
		[Address(RVA = "0x210FDA0", Offset = "0x210E9A0", VA = "0x18210FDA0")]
		public ReturnMissionGroupData()
		{
		}

		// Token: 0x04005EDC RID: 24284
		[Token(Token = "0x4005EDC")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EDD RID: 24285
		[Token(Token = "0x4005EDD")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005EDE RID: 24286
		[Token(Token = "0x4005EDE")]
		[FieldOffset(Offset = "0x1C")]
		public ReturnMissionGroupType type;

		// Token: 0x04005EDF RID: 24287
		[Token(Token = "0x4005EDF")]
		[FieldOffset(Offset = "0x20")]
		public List<ReturnMissionItemData> missionList;
	}
}
