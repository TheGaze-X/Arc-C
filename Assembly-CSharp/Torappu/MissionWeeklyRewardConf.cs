using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200110D RID: 4365
	[Token(Token = "0x200110D")]
	[Serializable]
	public class MissionWeeklyRewardConf : MissionPeriodicRewardConf
	{
		// Token: 0x06006ECF RID: 28367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ECF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionWeeklyRewardConf()
		{
		}

		// Token: 0x04005D8F RID: 23951
		[Token(Token = "0x4005D8F")]
		[FieldOffset(Offset = "0x38")]
		public long beginTime;

		// Token: 0x04005D90 RID: 23952
		[Token(Token = "0x4005D90")]
		[FieldOffset(Offset = "0x40")]
		public long endTime;
	}
}
