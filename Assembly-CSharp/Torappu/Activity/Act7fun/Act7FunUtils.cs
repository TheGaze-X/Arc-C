using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x0200719A RID: 29082
	[Token(Token = "0x200719A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act7FunUtils
	{
		// Token: 0x06029440 RID: 169024 RVA: 0x000D4EC8 File Offset: 0x000D30C8
		[Token(Token = "0x6029440")]
		[Address(RVA = "0x2491C40", Offset = "0x2490840", VA = "0x182491C40")]
		public static bool IsWinStyle()
		{
			return default(bool);
		}

		// Token: 0x06029441 RID: 169025 RVA: 0x000D4EE0 File Offset: 0x000D30E0
		[Token(Token = "0x6029441")]
		[Address(RVA = "0x2491DE0", Offset = "0x24909E0", VA = "0x182491DE0")]
		private static bool _TryGetAct7FunAvailStageState(string stageId, out int state)
		{
			return default(bool);
		}

		// Token: 0x0403AEF5 RID: 241397
		[Token(Token = "0x403AEF5")]
		public const string ACT7FUN_NEW_STAGE_TRACK_TYPE = "ACT7FUN_NEW_STAGE";

		// Token: 0x0403AEF6 RID: 241398
		[Token(Token = "0x403AEF6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsWinStyle;

		// Token: 0x0403AEF7 RID: 241399
		[Token(Token = "0x403AEF7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryGetAct7FunAvailStageState;
	}
}
