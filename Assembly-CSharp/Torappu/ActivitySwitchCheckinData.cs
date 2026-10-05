using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	public class ActivitySwitchCheckinData
	{
		// Token: 0x06006AFC RID: 27388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0x1FFCC70", Offset = "0x1FFB870", VA = "0x181FFCC70")]
		public ActivitySwitchCheckinData()
		{
		}

		// Token: 0x04004B78 RID: 19320
		[Token(Token = "0x4004B78")]
		[FieldOffset(Offset = "0x10")]
		public ActivitySwitchCheckinConstData constData;

		// Token: 0x04004B79 RID: 19321
		[Token(Token = "0x4004B79")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, ItemBundle[]> rewards;

		// Token: 0x04004B7A RID: 19322
		[Token(Token = "0x4004B7A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, ActivitySwitchCheckinRewardShowData> rewardShowDatas;

		// Token: 0x04004B7B RID: 19323
		[Token(Token = "0x4004B7B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, long> apSupplyOutOfDateDict;

		// Token: 0x04004B7C RID: 19324
		[Token(Token = "0x4004B7C")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, int> sortIdDict;
	}
}
