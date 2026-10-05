using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076CF RID: 30415
	[Token(Token = "0x20076CF")]
	public class Act1VHalfIdleCharUpgradeLevelRequest
	{
		// Token: 0x0602AC1A RID: 175130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharUpgradeLevelRequest()
		{
		}

		// Token: 0x0403D9BD RID: 252349
		[Token(Token = "0x403D9BD")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9BE RID: 252350
		[Token(Token = "0x403D9BE")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0403D9BF RID: 252351
		[Token(Token = "0x403D9BF")]
		[FieldOffset(Offset = "0x20")]
		public int destLvl;
	}
}
