using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x0200616F RID: 24943
	[Token(Token = "0x200616F")]
	public class BossRushRelicSelectRequest
	{
		// Token: 0x06023FFE RID: 147454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023FFE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BossRushRelicSelectRequest()
		{
		}

		// Token: 0x0403202E RID: 204846
		[Token(Token = "0x403202E")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403202F RID: 204847
		[Token(Token = "0x403202F")]
		[FieldOffset(Offset = "0x18")]
		public string relicId;
	}
}
