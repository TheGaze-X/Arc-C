using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013C6 RID: 5062
	[Token(Token = "0x20013C6")]
	[Serializable]
	public class ZoneTable
	{
		// Token: 0x060073B7 RID: 29623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B7")]
		[Address(RVA = "0x2218120", Offset = "0x2216D20", VA = "0x182218120")]
		public ZoneTable()
		{
		}

		// Token: 0x04007093 RID: 28819
		[Token(Token = "0x4007093")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ZoneData> zones;

		// Token: 0x04007094 RID: 28820
		[Token(Token = "0x4007094")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, WeeklyZoneData> weeklyAdditionInfo;

		// Token: 0x04007095 RID: 28821
		[Token(Token = "0x4007095")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ZoneValidInfo> zoneValidInfo;

		// Token: 0x04007096 RID: 28822
		[Token(Token = "0x4007096")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, MainlineZoneData> mainlineAdditionInfo;

		// Token: 0x04007097 RID: 28823
		[Token(Token = "0x4007097")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ZoneRecordGroupData> zoneRecordGroupedData;

		// Token: 0x04007098 RID: 28824
		[Token(Token = "0x4007098")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, List<string>> zoneRecordRewardData;

		// Token: 0x04007099 RID: 28825
		[Token(Token = "0x4007099")]
		[FieldOffset(Offset = "0x40")]
		public List<string> mainlineZoneIdList;

		// Token: 0x0400709A RID: 28826
		[Token(Token = "0x400709A")]
		[FieldOffset(Offset = "0x48")]
		public ZoneMetaData zoneMetaData;
	}
}
