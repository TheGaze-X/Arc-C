using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02001419 RID: 5145
	[Token(Token = "0x2001419")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CrisisDataUtil
	{
		// Token: 0x060076D1 RID: 30417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076D1")]
		[Address(RVA = "0x241E670", Offset = "0x241D270", VA = "0x18241E670")]
		public static PlayerCrisisSeason GetPlayerSeason(string seasonId)
		{
			return null;
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076D2")]
		[Address(RVA = "0x241E590", Offset = "0x241D190", VA = "0x18241E590")]
		public static PlayerCrisisSeason GetPlayerSeason(string seasonId, PlayerCrisis playerCrisis)
		{
			return null;
		}

		// Token: 0x04007419 RID: 29721
		[Token(Token = "0x4007419")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPlayerSeason;

		// Token: 0x0400741A RID: 29722
		[Token(Token = "0x400741A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_GetPlayerSeason;
	}
}
