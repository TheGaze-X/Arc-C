using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C98 RID: 19608
	[Token(Token = "0x2004C98")]
	public class OpenServerV2MissionItemData
	{
		// Token: 0x0601D62F RID: 120367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D62F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public OpenServerV2MissionItemData()
		{
		}

		// Token: 0x04026B04 RID: 158468
		[Token(Token = "0x4026B04")]
		[FieldOffset(Offset = "0x10")]
		public MissionData missionData;

		// Token: 0x04026B05 RID: 158469
		[Token(Token = "0x4026B05")]
		[FieldOffset(Offset = "0x18")]
		public MissionPlayerState state;
	}
}
