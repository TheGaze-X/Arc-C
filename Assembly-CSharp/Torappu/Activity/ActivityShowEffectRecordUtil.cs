using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D43 RID: 27971
	[Token(Token = "0x2006D43")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActivityShowEffectRecordUtil
	{
		// Token: 0x06027DEA RID: 163306 RVA: 0x000CFBA0 File Offset: 0x000CDDA0
		[Token(Token = "0x6027DEA")]
		[Address(RVA = "0x22F26D0", Offset = "0x22F12D0", VA = "0x1822F26D0")]
		public static bool CheckIfActWatched(string actId)
		{
			return default(bool);
		}

		// Token: 0x06027DEB RID: 163307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DEB")]
		[Address(RVA = "0x22F27C0", Offset = "0x22F13C0", VA = "0x1822F27C0")]
		public static void MarkActWatched(string actId)
		{
		}

		// Token: 0x06027DEC RID: 163308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DEC")]
		[Address(RVA = "0x22F28A0", Offset = "0x22F14A0", VA = "0x1822F28A0")]
		private static string _GetWatchActKey(string actId)
		{
			return null;
		}

		// Token: 0x04038851 RID: 231505
		[Token(Token = "0x4038851")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<string> s_watchedAct;

		// Token: 0x04038852 RID: 231506
		[Token(Token = "0x4038852")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfActWatched;

		// Token: 0x04038853 RID: 231507
		[Token(Token = "0x4038853")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_MarkActWatched;

		// Token: 0x04038854 RID: 231508
		[Token(Token = "0x4038854")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetWatchActKey;
	}
}
