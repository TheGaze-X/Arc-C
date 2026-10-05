using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D4D RID: 7501
	[Token(Token = "0x2001D4D")]
	public class BuildingMusicItemViewModel : IHotfixable
	{
		// Token: 0x0600B936 RID: 47414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B936")]
		[Address(RVA = "0x3360AE0", Offset = "0x335F6E0", VA = "0x183360AE0")]
		public BuildingMusicItemViewModel()
		{
		}

		// Token: 0x0400B779 RID: 46969
		[Token(Token = "0x400B779")]
		[FieldOffset(Offset = "0x10")]
		public string bgmId;

		// Token: 0x0400B77A RID: 46970
		[Token(Token = "0x400B77A")]
		[FieldOffset(Offset = "0x18")]
		public string bgmName;

		// Token: 0x0400B77B RID: 46971
		[Token(Token = "0x400B77B")]
		[FieldOffset(Offset = "0x20")]
		public string bgmDesLocked;

		// Token: 0x0400B77C RID: 46972
		[Token(Token = "0x400B77C")]
		[FieldOffset(Offset = "0x28")]
		public string bgmDesUnlocked;

		// Token: 0x0400B77D RID: 46973
		[Token(Token = "0x400B77D")]
		[FieldOffset(Offset = "0x30")]
		public string gameMusicId;

		// Token: 0x0400B77E RID: 46974
		[Token(Token = "0x400B77E")]
		[FieldOffset(Offset = "0x38")]
		public long updateTime;

		// Token: 0x0400B77F RID: 46975
		[Token(Token = "0x400B77F")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x0400B780 RID: 46976
		[Token(Token = "0x400B780")]
		[FieldOffset(Offset = "0x44")]
		public bool isPlaying;

		// Token: 0x0400B781 RID: 46977
		[Token(Token = "0x400B781")]
		[FieldOffset(Offset = "0x45")]
		public bool isUnlocked;

		// Token: 0x0400B782 RID: 46978
		[Token(Token = "0x400B782")]
		[FieldOffset(Offset = "0x46")]
		public bool isCurrBgm;

		// Token: 0x0400B783 RID: 46979
		[Token(Token = "0x400B783")]
		[FieldOffset(Offset = "0x47")]
		public bool isNew;

		// Token: 0x0400B784 RID: 46980
		[Token(Token = "0x400B784")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
