using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200141A RID: 5146
	[Token(Token = "0x200141A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class EnemyHandbookTrackTriggerUtil
	{
		// Token: 0x060076D3 RID: 30419 RVA: 0x00035178 File Offset: 0x00033378
		[Token(Token = "0x60076D3")]
		[Address(RVA = "0x241E910", Offset = "0x241D510", VA = "0x18241E910")]
		public static bool ConsumeTrack(string id)
		{
			return default(bool);
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x00035190 File Offset: 0x00033390
		[Token(Token = "0x60076D4")]
		[Address(RVA = "0x241E870", Offset = "0x241D470", VA = "0x18241E870")]
		public static bool CheckTrack(string id)
		{
			return default(bool);
		}

		// Token: 0x0400741B RID: 29723
		[Token(Token = "0x400741B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ConsumeTrack;

		// Token: 0x0400741C RID: 29724
		[Token(Token = "0x400741C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckTrack;
	}
}
