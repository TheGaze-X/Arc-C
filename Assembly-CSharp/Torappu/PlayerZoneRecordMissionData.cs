using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B98 RID: 2968
	[Token(Token = "0x2000B98")]
	public class PlayerZoneRecordMissionData
	{
		// Token: 0x06006835 RID: 26677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006835")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerZoneRecordMissionData()
		{
		}

		// Token: 0x04003D5B RID: 15707
		[Token(Token = "0x4003D5B")]
		[FieldOffset(Offset = "0x10")]
		public int state;

		// Token: 0x04003D5C RID: 15708
		[Token(Token = "0x4003D5C")]
		[FieldOffset(Offset = "0x18")]
		public PlayerZoneRecordMissionProcessData process;
	}
}
