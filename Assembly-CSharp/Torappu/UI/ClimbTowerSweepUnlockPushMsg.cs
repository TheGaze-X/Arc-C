using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003497 RID: 13463
	[Token(Token = "0x2003497")]
	public class ClimbTowerSweepUnlockPushMsg
	{
		// Token: 0x0601577A RID: 87930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSweepUnlockPushMsg()
		{
		}

		// Token: 0x04019B40 RID: 105280
		[Token(Token = "0x4019B40")]
		[FieldOffset(Offset = "0x10")]
		public string towerId;

		// Token: 0x04019B41 RID: 105281
		[Token(Token = "0x4019B41")]
		[FieldOffset(Offset = "0x18")]
		public bool isHard;
	}
}
