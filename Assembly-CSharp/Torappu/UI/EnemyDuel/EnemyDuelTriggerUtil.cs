using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F80 RID: 20352
	[Token(Token = "0x2004F80")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class EnemyDuelTriggerUtil
	{
		// Token: 0x0601E420 RID: 123936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E420")]
		[Address(RVA = "0x1808000", Offset = "0x1806C00", VA = "0x181808000")]
		private static string _GenModelUnlockType(string actId)
		{
			return null;
		}

		// Token: 0x0601E421 RID: 123937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E421")]
		[Address(RVA = "0x1807E60", Offset = "0x1806A60", VA = "0x181807E60")]
		public static void ConsumeModeUnlockTrack(string actId, string modeId)
		{
		}

		// Token: 0x0601E422 RID: 123938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E422")]
		[Address(RVA = "0x1807F30", Offset = "0x1806B30", VA = "0x181807F30")]
		public static void RecordModeUnlockTrack(string actId, string modeId)
		{
		}

		// Token: 0x0601E423 RID: 123939 RVA: 0x000AE090 File Offset: 0x000AC290
		[Token(Token = "0x601E423")]
		[Address(RVA = "0x1807D80", Offset = "0x1806980", VA = "0x181807D80")]
		public static bool CheckModeUnlockTrack(string actId, string modeId)
		{
			return default(bool);
		}

		// Token: 0x04028606 RID: 165382
		[Token(Token = "0x4028606")]
		private const string UNLOCK_NEW_MODE_TRACK_TYPE = "unlock_new_mode_{0}";

		// Token: 0x04028607 RID: 165383
		[Token(Token = "0x4028607")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GenModelUnlockType;

		// Token: 0x04028608 RID: 165384
		[Token(Token = "0x4028608")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConsumeModeUnlockTrack;

		// Token: 0x04028609 RID: 165385
		[Token(Token = "0x4028609")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RecordModeUnlockTrack;

		// Token: 0x0402860A RID: 165386
		[Token(Token = "0x402860A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckModeUnlockTrack;
	}
}
