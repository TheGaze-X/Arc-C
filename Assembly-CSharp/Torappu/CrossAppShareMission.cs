using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001114 RID: 4372
	[Token(Token = "0x2001114")]
	public class CrossAppShareMission
	{
		// Token: 0x06006ED7 RID: 28375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrossAppShareMission()
		{
		}

		// Token: 0x04005DAE RID: 23982
		[Token(Token = "0x4005DAE")]
		[FieldOffset(Offset = "0x10")]
		public string shareMissionId;

		// Token: 0x04005DAF RID: 23983
		[Token(Token = "0x4005DAF")]
		[FieldOffset(Offset = "0x18")]
		public CrossAppShareMissionType missionType;

		// Token: 0x04005DB0 RID: 23984
		[Token(Token = "0x4005DB0")]
		[FieldOffset(Offset = "0x20")]
		public string relateActivityId;

		// Token: 0x04005DB1 RID: 23985
		[Token(Token = "0x4005DB1")]
		[FieldOffset(Offset = "0x28")]
		public long startTime;

		// Token: 0x04005DB2 RID: 23986
		[Token(Token = "0x4005DB2")]
		[FieldOffset(Offset = "0x30")]
		public long endTime;

		// Token: 0x04005DB3 RID: 23987
		[Token(Token = "0x4005DB3")]
		[FieldOffset(Offset = "0x38")]
		public int limitCount;

		// Token: 0x04005DB4 RID: 23988
		[Token(Token = "0x4005DB4")]
		[FieldOffset(Offset = "0x40")]
		public string condTemplate;

		// Token: 0x04005DB5 RID: 23989
		[Token(Token = "0x4005DB5")]
		[FieldOffset(Offset = "0x48")]
		public List<string> condParam;

		// Token: 0x04005DB6 RID: 23990
		[Token(Token = "0x4005DB6")]
		[FieldOffset(Offset = "0x50")]
		public List<MissionDisplayRewards> rewardsList;
	}
}
