using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F2 RID: 4850
	[Token(Token = "0x20012F2")]
	public class SandboxV2RacingItemInfo
	{
		// Token: 0x0600726B RID: 29291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2RacingItemInfo()
		{
		}

		// Token: 0x04006B38 RID: 27448
		[Token(Token = "0x4006B38")]
		[FieldOffset(Offset = "0x10")]
		public string racerItemId;

		// Token: 0x04006B39 RID: 27449
		[Token(Token = "0x4006B39")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006B3A RID: 27450
		[Token(Token = "0x4006B3A")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x04006B3B RID: 27451
		[Token(Token = "0x4006B3B")]
		[FieldOffset(Offset = "0x28")]
		public Blackboard blackboard;
	}
}
