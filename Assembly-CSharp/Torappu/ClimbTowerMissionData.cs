using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F9C RID: 3996
	[Token(Token = "0x2000F9C")]
	public class ClimbTowerMissionData : MissionData
	{
		// Token: 0x06006CDC RID: 27868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CDC")]
		[Address(RVA = "0x2100230", Offset = "0x20FEE30", VA = "0x182100230")]
		public ClimbTowerMissionData()
		{
		}

		// Token: 0x040054EF RID: 21743
		[Token(Token = "0x40054EF")]
		[FieldOffset(Offset = "0xA0")]
		public string bindGodCardId;

		// Token: 0x040054F0 RID: 21744
		[Token(Token = "0x40054F0")]
		[FieldOffset(Offset = "0xA8")]
		public string bindTowerId;
	}
}
