using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006171 RID: 24945
	[Token(Token = "0x2006171")]
	public class BossRushRelicUpgradeRequest
	{
		// Token: 0x06024000 RID: 147456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024000")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BossRushRelicUpgradeRequest()
		{
		}

		// Token: 0x04032030 RID: 204848
		[Token(Token = "0x4032030")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04032031 RID: 204849
		[Token(Token = "0x4032031")]
		[FieldOffset(Offset = "0x18")]
		public string relicId;
	}
}
