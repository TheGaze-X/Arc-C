using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FD8 RID: 4056
	[Token(Token = "0x2000FD8")]
	public class CrisisV2AchievementRuneData : ICrisisV2RuneData, IHotfixable
	{
		// Token: 0x06006D26 RID: 27942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D26")]
		[Address(RVA = "0x2100AC0", Offset = "0x20FF6C0", VA = "0x182100AC0", Slot = "4")]
		public string GetRuneId()
		{
			return null;
		}

		// Token: 0x06006D27 RID: 27943 RVA: 0x00031B78 File Offset: 0x0002FD78
		[Token(Token = "0x6006D27")]
		[Address(RVA = "0x2100B20", Offset = "0x20FF720", VA = "0x182100B20", Slot = "5")]
		public int GetRuneScore()
		{
			return 0;
		}

		// Token: 0x06006D28 RID: 27944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D28")]
		[Address(RVA = "0x2100A60", Offset = "0x20FF660", VA = "0x182100A60", Slot = "6")]
		public string GetRuneIconId()
		{
			return null;
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x00031B90 File Offset: 0x0002FD90
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0x2100B80", Offset = "0x20FF780", VA = "0x182100B80", Slot = "7")]
		public int GetRuneSortId()
		{
			return 0;
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D2A")]
		[Address(RVA = "0x2100BE0", Offset = "0x20FF7E0", VA = "0x182100BE0")]
		public CrisisV2AchievementRuneData()
		{
		}

		// Token: 0x0400560A RID: 22026
		[Token(Token = "0x400560A")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x0400560B RID: 22027
		[Token(Token = "0x400560B")]
		[FieldOffset(Offset = "0x18")]
		public string runeIcon;

		// Token: 0x0400560C RID: 22028
		[Token(Token = "0x400560C")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0400560D RID: 22029
		[Token(Token = "0x400560D")]
		[FieldOffset(Offset = "0x24")]
		public int runeScoreSum;

		// Token: 0x0400560E RID: 22030
		[Token(Token = "0x400560E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRuneId;

		// Token: 0x0400560F RID: 22031
		[Token(Token = "0x400560F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRuneScore;

		// Token: 0x04005610 RID: 22032
		[Token(Token = "0x4005610")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRuneIconId;

		// Token: 0x04005611 RID: 22033
		[Token(Token = "0x4005611")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRuneSortId;

		// Token: 0x04005612 RID: 22034
		[Token(Token = "0x4005612")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
