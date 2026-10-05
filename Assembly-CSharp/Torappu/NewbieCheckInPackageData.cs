using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001123 RID: 4387
	[Token(Token = "0x2001123")]
	public class NewbieCheckInPackageData
	{
		// Token: 0x06006EE7 RID: 28391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NewbieCheckInPackageData()
		{
		}

		// Token: 0x04005E06 RID: 24070
		[Token(Token = "0x4005E06")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005E07 RID: 24071
		[Token(Token = "0x4005E07")]
		[FieldOffset(Offset = "0x18")]
		public long startTime;

		// Token: 0x04005E08 RID: 24072
		[Token(Token = "0x4005E08")]
		[FieldOffset(Offset = "0x20")]
		public long endTime;

		// Token: 0x04005E09 RID: 24073
		[Token(Token = "0x4005E09")]
		[FieldOffset(Offset = "0x28")]
		public string bindGPGoodId;

		// Token: 0x04005E0A RID: 24074
		[Token(Token = "0x4005E0A")]
		[FieldOffset(Offset = "0x30")]
		public int checkInDuration;

		// Token: 0x04005E0B RID: 24075
		[Token(Token = "0x4005E0B")]
		[FieldOffset(Offset = "0x34")]
		public int compensateEndDay;

		// Token: 0x04005E0C RID: 24076
		[Token(Token = "0x4005E0C")]
		[FieldOffset(Offset = "0x38")]
		public int totalCheckInDay;

		// Token: 0x04005E0D RID: 24077
		[Token(Token = "0x4005E0D")]
		[FieldOffset(Offset = "0x40")]
		public string iconId;

		// Token: 0x04005E0E RID: 24078
		[Token(Token = "0x4005E0E")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, List<NewbieCheckInPackageRewardData>> checkInRewardDict;

		// Token: 0x04005E0F RID: 24079
		[Token(Token = "0x4005E0F")]
		[FieldOffset(Offset = "0x50")]
		public long trigStartTime;

		// Token: 0x04005E10 RID: 24080
		[Token(Token = "0x4005E10")]
		[FieldOffset(Offset = "0x58")]
		public long trigEndTime;
	}
}
