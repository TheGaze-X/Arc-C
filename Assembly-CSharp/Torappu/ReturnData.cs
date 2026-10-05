using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200113E RID: 4414
	[Token(Token = "0x200113E")]
	public class ReturnData
	{
		// Token: 0x06006F14 RID: 28436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x210F8E0", Offset = "0x210E4E0", VA = "0x18210F8E0")]
		public ReturnData()
		{
		}

		// Token: 0x04005E9B RID: 24219
		[Token(Token = "0x4005E9B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ReturnGroupData> groupDataMap;

		// Token: 0x04005E9C RID: 24220
		[Token(Token = "0x4005E9C")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ReturnOnceRewardData> onceDataMap;

		// Token: 0x04005E9D RID: 24221
		[Token(Token = "0x4005E9D")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ReturnCheckinGroupData> checkinDataMap;

		// Token: 0x04005E9E RID: 24222
		[Token(Token = "0x4005E9E")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, ReturnPriceGroupData> priceDataMap;

		// Token: 0x04005E9F RID: 24223
		[Token(Token = "0x4005E9F")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, ReturnMissionGroupData> missionDataMap;

		// Token: 0x04005EA0 RID: 24224
		[Token(Token = "0x4005EA0")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, ReturnCheckinGpRewardData> checkinGpData;

		// Token: 0x04005EA1 RID: 24225
		[Token(Token = "0x4005EA1")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, ReturnNewsData> newsDataMap;

		// Token: 0x04005EA2 RID: 24226
		[Token(Token = "0x4005EA2")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, ReturnGiftPackagePicData> giftPackagePicDataMap;

		// Token: 0x04005EA3 RID: 24227
		[Token(Token = "0x4005EA3")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, ReturnOpenStyleData> openStyleData;

		// Token: 0x04005EA4 RID: 24228
		[Token(Token = "0x4005EA4")]
		[FieldOffset(Offset = "0x58")]
		public ReturnConstData constData;
	}
}
