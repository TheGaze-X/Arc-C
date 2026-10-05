using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012DC RID: 4828
	[Token(Token = "0x20012DC")]
	public class SandboxV2ArchiveMusicUnlockData
	{
		// Token: 0x06007259 RID: 29273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007259")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2ArchiveMusicUnlockData()
		{
		}

		// Token: 0x04006AA3 RID: 27299
		[Token(Token = "0x4006AA3")]
		[FieldOffset(Offset = "0x10")]
		public string musicId;

		// Token: 0x04006AA4 RID: 27300
		[Token(Token = "0x4006AA4")]
		[FieldOffset(Offset = "0x18")]
		public string unlockCondDesc;
	}
}
