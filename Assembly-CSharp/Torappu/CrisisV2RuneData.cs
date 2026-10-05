using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FC7 RID: 4039
	[Token(Token = "0x2000FC7")]
	public class CrisisV2RuneData : ICrisisV2RuneData, IHotfixable
	{
		// Token: 0x06006D11 RID: 27921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D11")]
		[Address(RVA = "0x21014B0", Offset = "0x21000B0", VA = "0x1821014B0", Slot = "4")]
		public string GetRuneId()
		{
			return null;
		}

		// Token: 0x06006D12 RID: 27922 RVA: 0x00031B48 File Offset: 0x0002FD48
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0x2101510", Offset = "0x2100110", VA = "0x182101510", Slot = "5")]
		public int GetRuneScore()
		{
			return 0;
		}

		// Token: 0x06006D13 RID: 27923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D13")]
		[Address(RVA = "0x2101450", Offset = "0x2100050", VA = "0x182101450", Slot = "6")]
		public string GetRuneIconId()
		{
			return null;
		}

		// Token: 0x06006D14 RID: 27924 RVA: 0x00031B60 File Offset: 0x0002FD60
		[Token(Token = "0x6006D14")]
		[Address(RVA = "0x2101570", Offset = "0x2100170", VA = "0x182101570", Slot = "7")]
		public int GetRuneSortId()
		{
			return 0;
		}

		// Token: 0x06006D15 RID: 27925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D15")]
		[Address(RVA = "0x21015D0", Offset = "0x21001D0", VA = "0x1821015D0")]
		public CrisisV2RuneData()
		{
		}

		// Token: 0x040055C4 RID: 21956
		[Token(Token = "0x40055C4")]
		[FieldOffset(Offset = "0x10")]
		public string runeId;

		// Token: 0x040055C5 RID: 21957
		[Token(Token = "0x40055C5")]
		[FieldOffset(Offset = "0x18")]
		public string runeGroupId;

		// Token: 0x040055C6 RID: 21958
		[Token(Token = "0x40055C6")]
		[FieldOffset(Offset = "0x20")]
		public string runeIcon;

		// Token: 0x040055C7 RID: 21959
		[Token(Token = "0x40055C7")]
		[FieldOffset(Offset = "0x28")]
		public string runeName;

		// Token: 0x040055C8 RID: 21960
		[Token(Token = "0x40055C8")]
		[FieldOffset(Offset = "0x30")]
		public int score;

		// Token: 0x040055C9 RID: 21961
		[Token(Token = "0x40055C9")]
		[FieldOffset(Offset = "0x34")]
		public int dimension;

		// Token: 0x040055CA RID: 21962
		[Token(Token = "0x40055CA")]
		[FieldOffset(Offset = "0x38")]
		public RuneTable.PackedRuneData packedRune;

		// Token: 0x040055CB RID: 21963
		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x040055CC RID: 21964
		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRuneId;

		// Token: 0x040055CD RID: 21965
		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetRuneScore;

		// Token: 0x040055CE RID: 21966
		[Token(Token = "0x40055CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRuneIconId;

		// Token: 0x040055CF RID: 21967
		[Token(Token = "0x40055CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRuneSortId;

		// Token: 0x040055D0 RID: 21968
		[Token(Token = "0x40055D0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
