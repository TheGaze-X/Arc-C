using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012F4 RID: 4852
	[Token(Token = "0x20012F4")]
	public class SandboxV2ChallengeModeUnlockData
	{
		// Token: 0x0600726D RID: 29293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600726D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ChallengeModeUnlockData()
		{
		}

		// Token: 0x04006B43 RID: 27459
		[Token(Token = "0x4006B43")]
		[FieldOffset(Offset = "0x10")]
		public string unlockId;

		// Token: 0x04006B44 RID: 27460
		[Token(Token = "0x4006B44")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006B45 RID: 27461
		[Token(Token = "0x4006B45")]
		[FieldOffset(Offset = "0x20")]
		public string conditionDesc;
	}
}
