using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public class PlayerSyncAnnounceVersionResult : PlayerSyncResult
	{
		// Token: 0x060063F5 RID: 25589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerSyncAnnounceVersionResult()
		{
		}

		// Token: 0x0400301B RID: 12315
		[Token(Token = "0x400301B")]
		[FieldOffset(Offset = "0x10")]
		public string announcementPopUpVersion;

		// Token: 0x0400301C RID: 12316
		[Token(Token = "0x400301C")]
		[FieldOffset(Offset = "0x18")]
		public string announcementVersion;
	}
}
