using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200113F RID: 4415
	[Token(Token = "0x200113F")]
	public class ReturnGroupData
	{
		// Token: 0x06006F15 RID: 28437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x210FBE0", Offset = "0x210E7E0", VA = "0x18210FBE0")]
		public ReturnGroupData()
		{
		}

		// Token: 0x04005EA5 RID: 24229
		[Token(Token = "0x4005EA5")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005EA6 RID: 24230
		[Token(Token = "0x4005EA6")]
		[FieldOffset(Offset = "0x18")]
		public int taskDays;

		// Token: 0x04005EA7 RID: 24231
		[Token(Token = "0x4005EA7")]
		[FieldOffset(Offset = "0x20")]
		public string onceGroupId;

		// Token: 0x04005EA8 RID: 24232
		[Token(Token = "0x4005EA8")]
		[FieldOffset(Offset = "0x28")]
		public List<string> missionGroupId;

		// Token: 0x04005EA9 RID: 24233
		[Token(Token = "0x4005EA9")]
		[FieldOffset(Offset = "0x30")]
		public string checkinGroupId;

		// Token: 0x04005EAA RID: 24234
		[Token(Token = "0x4005EAA")]
		[FieldOffset(Offset = "0x38")]
		public string priceGroupId;

		// Token: 0x04005EAB RID: 24235
		[Token(Token = "0x4005EAB")]
		[FieldOffset(Offset = "0x40")]
		public List<string> newsGroupId;

		// Token: 0x04005EAC RID: 24236
		[Token(Token = "0x4005EAC")]
		[FieldOffset(Offset = "0x48")]
		public List<string> giftPackageIdList;

		// Token: 0x04005EAD RID: 24237
		[Token(Token = "0x4005EAD")]
		[FieldOffset(Offset = "0x50")]
		public string checkinGpId;

		// Token: 0x04005EAE RID: 24238
		[Token(Token = "0x4005EAE")]
		[FieldOffset(Offset = "0x58")]
		public string gachaPoolId;

		// Token: 0x04005EAF RID: 24239
		[Token(Token = "0x4005EAF")]
		[FieldOffset(Offset = "0x60")]
		public int allOpenDays;

		// Token: 0x04005EB0 RID: 24240
		[Token(Token = "0x4005EB0")]
		[FieldOffset(Offset = "0x64")]
		public int campAllOpenDays;

		// Token: 0x04005EB1 RID: 24241
		[Token(Token = "0x4005EB1")]
		[FieldOffset(Offset = "0x68")]
		public List<ReturnOpenData> allOpenData;
	}
}
