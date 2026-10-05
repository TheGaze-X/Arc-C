using System;
using Il2CppDummyDll;
using Torappu.UI.Squad;
using XLua;

namespace Torappu.Scripts.UI.Squad
{
	// Token: 0x0200179F RID: 6047
	[Token(Token = "0x200179F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SquadNumLimitWithAssistFirst
	{
		// Token: 0x060098DE RID: 39134 RVA: 0x0003B808 File Offset: 0x00039A08
		[Token(Token = "0x60098DE")]
		[Address(RVA = "0x3149CC0", Offset = "0x31488C0", VA = "0x183149CC0")]
		public static bool TryGetSquadNumChangeInfoByRune(ExternalRuneChecker runeChecker, out ExternalRuneChecker.SquadNumChangeInfoByRune changeInfoByRune)
		{
			return default(bool);
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0003B820 File Offset: 0x00039A20
		[Token(Token = "0x60098DF")]
		[Address(RVA = "0x3149AC0", Offset = "0x31486C0", VA = "0x183149AC0")]
		public static int GetSquadMaxMemberNum4Select(ExternalRuneChecker runeChecker, int assistCount, SquadMaxNumInfo squadMaxNumInfo, int memberSlotMaxLimit)
		{
			return 0;
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x0003B838 File Offset: 0x00039A38
		[Token(Token = "0x60098E0")]
		[Address(RVA = "0x3149920", Offset = "0x3148520", VA = "0x183149920")]
		public static int GetSquadMaxCharNum(ExternalRuneChecker runeChecker, SquadMaxNumInfo squadMaxNumInfo)
		{
			return 0;
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x0003B850 File Offset: 0x00039A50
		[Token(Token = "0x60098E1")]
		[Address(RVA = "0x3149750", Offset = "0x3148350", VA = "0x183149750")]
		public static bool CheckIfSquadSlotIsLocked(ExternalRuneChecker runeChecker, int memberIndex, int assistCount, SquadMaxNumInfo squadMaxNumInfo)
		{
			return default(bool);
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x0003B868 File Offset: 0x00039A68
		[Token(Token = "0x60098E2")]
		[Address(RVA = "0x3149580", Offset = "0x3148180", VA = "0x183149580")]
		public static bool CheckIfAssistIsLocked(ExternalRuneChecker runeChecker, int memberNum, int assistIndex, SquadMaxNumInfo squadMaxNumInfo)
		{
			return default(bool);
		}

		// Token: 0x04008EE1 RID: 36577
		[Token(Token = "0x4008EE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TryGetSquadNumChangeInfoByRune;

		// Token: 0x04008EE2 RID: 36578
		[Token(Token = "0x4008EE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSquadMaxMemberNum4Select;

		// Token: 0x04008EE3 RID: 36579
		[Token(Token = "0x4008EE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSquadMaxCharNum;

		// Token: 0x04008EE4 RID: 36580
		[Token(Token = "0x4008EE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIfSquadSlotIsLocked;

		// Token: 0x04008EE5 RID: 36581
		[Token(Token = "0x4008EE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfAssistIsLocked;
	}
}
