using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02001400 RID: 5120
	[Token(Token = "0x2001400")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CharacterTrackUtil
	{
		// Token: 0x0600759F RID: 30111 RVA: 0x00034C68 File Offset: 0x00032E68
		[Token(Token = "0x600759F")]
		[Address(RVA = "0x2304590", Offset = "0x2303190", VA = "0x182304590")]
		private static bool _FetchTriggerCond(EvolvePhase evolvePhase, int level, PlayerCharacter charInfo)
		{
			return default(bool);
		}

		// Token: 0x060075A0 RID: 30112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A0")]
		[Address(RVA = "0x2304800", Offset = "0x2303400", VA = "0x182304800")]
		private static void _RecordUniEquipStage(string charId, PlayerCharacter prev, PlayerCharacter cur)
		{
		}

		// Token: 0x060075A1 RID: 30113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A1")]
		[Address(RVA = "0x2304640", Offset = "0x2303240", VA = "0x182304640")]
		private static void _RecordHandbookStage(string charId, PlayerCharacter prev, PlayerCharacter cur)
		{
		}

		// Token: 0x060075A2 RID: 30114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075A2")]
		[Address(RVA = "0x2304360", Offset = "0x2302F60", VA = "0x182304360")]
		public static void RecordTrackWhenLevelUpOrEvolve(string charId, PlayerCharacter prev, PlayerCharacter cur)
		{
		}

		// Token: 0x040072C4 RID: 29380
		[Token(Token = "0x40072C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FetchTriggerCond;

		// Token: 0x040072C5 RID: 29381
		[Token(Token = "0x40072C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RecordUniEquipStage;

		// Token: 0x040072C6 RID: 29382
		[Token(Token = "0x40072C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RecordHandbookStage;

		// Token: 0x040072C7 RID: 29383
		[Token(Token = "0x40072C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RecordTrackWhenLevelUpOrEvolve;
	}
}
