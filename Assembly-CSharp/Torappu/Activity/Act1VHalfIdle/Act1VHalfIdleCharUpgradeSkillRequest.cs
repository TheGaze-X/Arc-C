using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076D1 RID: 30417
	[Token(Token = "0x20076D1")]
	public class Act1VHalfIdleCharUpgradeSkillRequest
	{
		// Token: 0x0602AC1C RID: 175132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC1C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act1VHalfIdleCharUpgradeSkillRequest()
		{
		}

		// Token: 0x0403D9C2 RID: 252354
		[Token(Token = "0x403D9C2")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D9C3 RID: 252355
		[Token(Token = "0x403D9C3")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x0403D9C4 RID: 252356
		[Token(Token = "0x403D9C4")]
		[FieldOffset(Offset = "0x20")]
		public int destLvl;
	}
}
