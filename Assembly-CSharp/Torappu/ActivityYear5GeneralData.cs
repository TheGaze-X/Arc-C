using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E2D RID: 3629
	[Token(Token = "0x2000E2D")]
	public class ActivityYear5GeneralData
	{
		// Token: 0x06006B01 RID: 27393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B01")]
		[Address(RVA = "0x1FFDB50", Offset = "0x1FFC750", VA = "0x181FFDB50")]
		public ActivityYear5GeneralData()
		{
		}

		// Token: 0x04004B8A RID: 19338
		[Token(Token = "0x4004B8A")]
		[FieldOffset(Offset = "0x10")]
		public ActivityYear5GeneralConstData constData;

		// Token: 0x04004B8B RID: 19339
		[Token(Token = "0x4004B8B")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityYear5GeneralUnlimitedApRewardData> unlimitedApRewards;
	}
}
